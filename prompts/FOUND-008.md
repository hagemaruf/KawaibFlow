# FOUND-008 — Configure Structured Logging

## Sprint

Sprint 1 — Foundation

---

## Objective

Configure structured logging for KawaibFlow using the built-in ASP.NET Core logging infrastructure.

This issue establishes a centralized logging strategy for both the API and Blazor Web application.

No custom logging implementation should be introduced.

---

## Context

Current project status:

- Solution structure completed.
- Dependency Injection configured.
- Entity Framework Core configured.
- ASP.NET Core API configured.
- Blazor Web configured.
- Strongly typed configuration implemented.

The next foundation step is observability through structured logging.

---

## Requirements

### 1. Configure Logging

Use the default ASP.NET Core logging infrastructure.

Do not introduce custom logging abstractions.

---

### 2. Configure appsettings.json

Ensure both applications contain a Logging section.

Example:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning",
      "Microsoft.EntityFrameworkCore": "Warning"
    }
  }
}
```

Apply the same configuration to:

- appsettings.json
- appsettings.Development.json (override values if needed)

---

### 3. Verify Dependency Injection

The default `ILogger<T>` should be available through Dependency Injection.

Do not create wrapper interfaces.

Do not create a custom Logger service.

---

### 4. Startup Logging

Log one informational message during application startup.

Example:

```text
KawaibFlow API started successfully.
```

and

```text
KawaibFlow Web started successfully.
```

Use:

```csharp
ILogger<Program>
```

or an equivalent logger created through `ILoggerFactory`.

---

### 5. Keep Existing Configuration

Do not modify the existing middleware pipeline.

Do not change Dependency Injection registration.

---

## Acceptance Criteria

- Logging configuration exists.
- API writes a startup log.
- Web writes a startup log.
- `ILogger<T>` is available through DI.
- Solution builds successfully.

---

## Out of Scope

Do NOT implement:

- Serilog
- NLog
- Seq
- Elasticsearch
- OpenTelemetry
- Application Insights
- Log enrichment
- Correlation IDs
- Request logging middleware
- File logging
- Database logging

---

## Constraints

- Use only the built-in ASP.NET Core logging system.
- Do not introduce additional NuGet packages.
- Keep the implementation minimal.
- Follow existing coding conventions.

---

## Expected Output

The solution has a consistent structured logging foundation using the built-in ASP.NET Core logging infrastructure.