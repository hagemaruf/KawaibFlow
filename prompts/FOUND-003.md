# FOUND-003 – Configure Dependency Injection

## Issue

FOUND-003

## Sprint

Sprint 1 – Foundation

## Objective

Establish the Dependency Injection (DI) entry points for KawaibFlow following Clean Architecture principles.

This issue creates the Composition Root integration only. No services should be registered yet.

## Context

This project follows:

- KawaibFlow Engineering Handbook v1.0
- KawaibFlow Development Workflow v1.0
- Clean Architecture
- Modular Monolith
- SOLID Principles

The API project is the Composition Root.

Each architectural layer exposes a single public extension class responsible for registering that layer.

## Files Expected to Change

```
src/
├── KawaibFlow.Api/
│   └── Program.cs
│
├── KawaibFlow.Application/
│   └── ApplicationServiceCollectionExtensions.cs
│
└── KawaibFlow.Infrastructure/
    └── InfrastructureServiceCollectionExtensions.cs
```

No other files should be modified.

---

## Requirements

### 1. Application

Create:

```
ApplicationServiceCollectionExtensions.cs
```

Implement:

```csharp
namespace KawaibFlow.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        return services;
    }
}
```

Do not register any services.

---

### 2. Infrastructure

Create:

```
InfrastructureServiceCollectionExtensions.cs
```

Implement:

```csharp
namespace KawaibFlow.Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
```

Do not register any services.

---

### 3. API

Update `Program.cs`.

Register both layers:

```csharp
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
```

`Program.cs` should remain the Composition Root and should not contain layer-specific registrations.

---

### 4. Build

Ensure the solution builds successfully.

## Constraints

Do **NOT**:

- Configure Entity Framework Core
- Register DbContext
- Register repositories
- Configure Authentication
- Configure Authorization
- Configure Logging
- Configure AI providers
- Configure HttpClient
- Configure Messaging
- Configure Caching
- Add MediatR
- Add FluentValidation
- Add AutoMapper
- Install NuGet packages
- Add business logic
- Modify project references
- Modify unrelated files

This issue establishes only the DI entry points.

## Acceptance Criteria

- `ApplicationServiceCollectionExtensions` exists.
- `InfrastructureServiceCollectionExtensions` exists.
- `AddApplication()` is implemented.
- `AddInfrastructure()` is implemented.
- `Program.cs` delegates registration to those extension methods.
- No services are registered.
- The solution builds successfully.

## Definition of Success

The task is complete when:

- Both extension classes exist.
- `Program.cs` contains only the high-level registration calls.
- No infrastructure or application services have been registered yet.
- The solution builds without errors.
- Only the expected files have been modified.

## Expected Output

Provide:

1. Summary of modified files.
2. Explanation of the DI structure.
3. Confirmation that the solution builds successfully.
4. Any assumptions made during implementation.