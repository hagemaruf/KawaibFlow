# FOUND-006 — Configure Blazor Web App

## Sprint

Sprint 1 — Foundation

---

## Objective

Configure the Blazor Web application as the frontend host for KawaibFlow.

This issue establishes the web application's hosting infrastructure only.
No business functionality should be implemented.

---

## Context

Current project status:

- Solution structure completed.
- Clean Architecture configured.
- Dependency Injection configured.
- Entity Framework Core configured.
- ASP.NET Core API configured.

The Blazor Web project will serve as the primary user interface.

---

## Requirements

### 1. Verify Blazor Host

Ensure the Blazor Web project starts successfully.

The application should run without runtime errors.

---

### 2. Home Page

Replace the default template content.

Display a simple landing page.

Example:

```
KawaibFlow

Enterprise Workflow Automation Platform

Status

✓ Web Host Running
```

Keep the page intentionally simple.

---

### 3. Layout

Keep the default Blazor layout.

Do not redesign the UI.

Do not introduce navigation changes.

Do not introduce authentication UI.

---

### 4. Project Structure

Create:

```
Services/
```

The folder may remain empty.

It exists to prepare for future typed API clients.

---

### 5. Configuration

Add API configuration.

Example:

```json
{
  "Api": {
    "BaseUrl": "https://localhost:7001"
  }
}
```

Do not consume this configuration yet.

---

## Acceptance Criteria

- Blazor Web starts successfully.
- Landing page displays KawaibFlow branding.
- Services folder exists.
- API BaseUrl configuration added.
- Solution builds successfully.

---

## Out of Scope

Do NOT implement:

- HttpClient registration
- API clients
- Authentication
- Authorization
- Dashboard
- Workflow Designer
- CRUD pages
- SignalR
- Theme customization
- Tabler integration
- MudBlazor
- Fluent UI

---

## Constraints

- Keep the Blazor template structure.
- Keep the implementation minimal.
- Do not modify Domain.
- Do not modify Application.
- Do not modify Infrastructure.
- Do not introduce additional NuGet packages.

---

## Expected Output

A compiling Blazor Web application with:

- Updated landing page.
- API configuration.
- Services folder.
- No business functionality.