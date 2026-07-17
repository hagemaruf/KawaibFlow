Task: FOUND-001 – Create Initial Solution Structure

Create the initial solution structure for a new enterprise application named KawaibFlow using .NET 10.

Requirements

Create the following solution structure:

KawaibFlow.sln

src/
    KawaibFlow.Api
    KawaibFlow.Web
    KawaibFlow.Application
    KawaibFlow.Domain
    KawaibFlow.Infrastructure
    KawaibFlow.Contracts

tests/

docs/

docker/
Project Types
KawaibFlow.Api → ASP.NET Core Web API
KawaibFlow.Web → Blazor Web App
KawaibFlow.Application → Class Library
KawaibFlow.Domain → Class Library
KawaibFlow.Infrastructure → Class Library
KawaibFlow.Contracts → Class Library
Add Project References
Api
├── Application
├── Infrastructure
└── Contracts

Application
├── Domain
└── Contracts

Infrastructure
├── Application
├── Domain
└── Contracts

Web
└── Contracts

The Domain project must not reference any other project.

Contracts must not reference any other project.

Create the following folders inside each project:

Domain

Entities
Enums
Events
ValueObjects

Application

Features
Interfaces
Services
Common

Infrastructure

Persistence
AI
Messaging
DependencyInjection

Api

Endpoints
Extensions
Middleware

Ensure the solution builds successfully.

Do not implement business logic.

Do not install additional NuGet packages yet.

Return a summary of the created structure and any CLI commands used.