# FOUND-005 — Configure ASP.NET Core API

## Objective

Configure the ASP.NET Core API host as the application's entry point.

This issue establishes the HTTP hosting infrastructure without introducing any business endpoints or domain logic.

---

## Context

Project: KawaibFlow

Architecture:

- Clean Architecture
- Modular Monolith
- ASP.NET Core (.NET 10)

Current state:

- Solution structure created.
- Project references configured.
- Dependency Injection composition root implemented.
- Entity Framework Core and SQLite configured.
- Infrastructure registered via `AddInfrastructure()`.
- Application registered via `AddApplication()`.

The API project acts as the Composition Root.

---

## Requirements

### 1. Configure Controllers

Register MVC controllers.

```csharp
builder.Services.AddControllers();
```

Map controllers.

```csharp
app.MapControllers();
```

Do **not** create any controllers in this issue.

---

### 2. Configure OpenAPI

Register OpenAPI.

```csharp
builder.Services.AddOpenApi();
```

Expose OpenAPI only in Development.

```csharp
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
```

Do not introduce Swagger UI unless already included by the template.

---

### 3. Configure HTTPS

Ensure HTTPS redirection remains enabled.

```csharp
app.UseHttpsRedirection();
```

---

### 4. Configure Health Endpoint

Expose a lightweight health endpoint.

```
GET /health
```

Return HTTP 200.

Example response:

```json
{
  "status": "Healthy"
}
```

Use a Minimal API endpoint for now.

Do **not** introduce ASP.NET Core Health Checks yet.

---

### 5. Composition Root

Program.cs should remain responsible only for:

- service registration
- middleware
- endpoint mapping

Business logic must remain outside the API project.

---

## Expected Program.cs

The final Program.cs should resemble:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/health", () =>
    Results.Ok(new
    {
        Status = "Healthy"
    }));

app.Run();
```

The exact formatting may differ.

---

## Acceptance Criteria

- API starts successfully.
- Controllers are registered.
- Controllers are mapped.
- OpenAPI is available in Development.
- HTTPS redirection is enabled.
- `/health` returns HTTP 200.
- Program.cs remains clean and focused on composition.
- Solution builds successfully.

---

## Out of Scope

- Authentication
- Authorization
- Identity
- JWT
- API Versioning
- CORS
- Rate Limiting
- SignalR
- ProblemDetails
- Exception middleware
- Business controllers
- CQRS
- Workflow endpoints

---

## Constraints

- Do not move business logic into the API project.
- Do not modify Domain.
- Do not modify Application.
- Do not introduce new NuGet packages unless required by ASP.NET Core.
- Keep Program.cs concise.
- Follow existing coding conventions.

---

## Expected Output

- Updated `Program.cs`
- API configured with Controllers
- OpenAPI enabled in Development
- Health endpoint available
- Solution builds successfully