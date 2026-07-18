# FOUND-004 — Configure Entity Framework Core & SQLite

## Sprint

Sprint 1 — Foundation

---

## Objective

Prepare the persistence infrastructure for local development by configuring Entity Framework Core with SQLite.

This issue establishes the persistence foundation only.
No business entities or repositories should be introduced.

---

## Context

The solution already contains:

- KawaibFlow.Api
- KawaibFlow.Application
- KawaibFlow.Domain
- KawaibFlow.Infrastructure
- KawaibFlow.Web
- KawaibFlow.Contracts

FOUND-003 introduced the dependency injection structure:

- ApplicationServiceCollectionExtensions
- InfrastructureServiceCollectionExtensions

FOUND-004 extends the Infrastructure layer by configuring EF Core.

---

## Requirements

### 1. Install EF Core packages

Add the required packages to **KawaibFlow.Infrastructure**.

Required packages:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Design

Do not add EF Core packages to Domain, Application, or Contracts.

---

### 2. Create Persistence folder

Create:

```
Infrastructure/
    Persistence/
```

---

### 3. Create DbContext

Create:

```
Persistence/
    KawaibFlowDbContext.cs
```

Example structure:

```csharp
public sealed class KawaibFlowDbContext : DbContext
{
    public KawaibFlowDbContext(
        DbContextOptions<KawaibFlowDbContext> options)
        : base(options)
    {
    }
}
```

The DbContext must contain **no DbSet properties**.

---

### 4. Configure Dependency Injection

Update:

```
InfrastructureServiceCollectionExtensions.cs
```

Register:

```csharp
services.AddDbContext<KawaibFlowDbContext>(options =>
    options.UseSqlite(
        configuration.GetConnectionString("DefaultConnection")));
```

Do not register repositories or other services.

---

### 5. Connection String

Add to `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=kawaibflow.db"
  }
}
```

---

### 6. Initial Migration

Create the initial migration.

Expected location:

```
Infrastructure/
    Persistence/
        Migrations/
```

The migration is expected to be empty because no entities exist yet.

---

### 7. Database Creation

Verify the following command succeeds:

```bash
dotnet ef database update
```

A SQLite database file should be created.

---

## Acceptance Criteria

- EF Core packages installed.
- SQLite provider configured.
- Connection string added.
- KawaibFlowDbContext created.
- DbContext registered in Infrastructure.
- Initial migration created.
- SQLite database successfully created.
- Solution builds successfully.

---

## Out of Scope

Do NOT implement:

- Domain entities
- DbSet properties
- Repositories
- Unit of Work
- Seed data
- Fluent API configurations
- Business logic
- Domain changes
- Application changes beyond DI registration

---

## Constraints

- Follow Clean Architecture.
- Keep Domain independent.
- Keep Application persistence-agnostic.
- Only Infrastructure references EF Core.
- Program.cs remains the Composition Root.
- Keep the implementation minimal.

---

## Expected Output

A compiling solution with:

- EF Core configured
- SQLite configured
- Empty DbContext
- Initial migration
- Database creation working

No additional functionality should be introduced.