# FOUND-007 — Implement Strongly Typed Configuration (Options Pattern)

## Sprint

Sprint 1 — Foundation

---

## Objective

Implement the ASP.NET Core Options Pattern to provide strongly typed access to application configuration.

This issue establishes a centralized and type-safe configuration strategy for KawaibFlow while keeping configuration models independent of the hosting layer.

---

## Context

The solution currently contains:

- ASP.NET Core API
- Blazor Web App
- Entity Framework Core
- SQLite
- Dependency Injection

Configuration currently relies on string-based access.

This issue introduces strongly typed configuration models.

---

## Requirements

### 1. Create Configuration Models

Create a new folder in the **Application** project.

```
KawaibFlow.Application/
└── Configuration/
```

Create the following classes.

```
ApiOptions.cs
```

```csharp
namespace KawaibFlow.Application.Configuration;

public sealed class ApiOptions
{
    public const string SectionName = "Api";

    public string BaseUrl { get; init; } = string.Empty;
}
```

```
DatabaseOptions.cs
```

```csharp
namespace KawaibFlow.Application.Configuration;

public sealed class DatabaseOptions
{
    public const string SectionName = "ConnectionStrings";

    public string DefaultConnection { get; init; } = string.Empty;
}
```

---

### 2. Register Options in API

In `Program.cs`, register the configuration.

```csharp
builder.Services.Configure<ApiOptions>(
    builder.Configuration.GetSection(ApiOptions.SectionName));

builder.Services.Configure<DatabaseOptions>(
    builder.Configuration.GetSection(DatabaseOptions.SectionName));
```

---

### 3. Register Options in Web

Register `ApiOptions`.

```csharp
builder.Services.Configure<ApiOptions>(
    builder.Configuration.GetSection(ApiOptions.SectionName));
```

---

### 4. Preserve Existing Configuration

Do not modify the existing configuration structure.

Existing sections should continue to work.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=kawaibflow.db"
  },

  "Api": {
    "BaseUrl": "https://localhost:7001"
  }
}
```

---

### 5. Do Not Consume Options Yet

Do not inject:

- `IOptions<ApiOptions>`
- `IOptions<DatabaseOptions>`

No services should consume these options in this issue.

This issue only establishes the configuration pattern.

---

## Acceptance Criteria

- `Configuration` folder created in Application.
- `ApiOptions` created.
- `DatabaseOptions` created.
- API registers strongly typed options.
- Web registers strongly typed options.
- Existing configuration remains unchanged.
- Solution builds successfully.

---

## Out of Scope

Do NOT implement:

- Configuration validation
- `IValidateOptions`
- DataAnnotations validation
- User Secrets
- Azure Key Vault
- Environment variables
- Feature flags
- Custom configuration providers
- Consuming options in services

---

## Constraints

- Configuration models belong in the Application project.
- API and Web are responsible only for configuration binding.
- Keep the implementation minimal.
- Do not introduce additional NuGet packages.
- Follow existing coding conventions.

---

## Expected Output

The solution supports strongly typed configuration using the ASP.NET Core Options Pattern while maintaining Clean Architecture boundaries.