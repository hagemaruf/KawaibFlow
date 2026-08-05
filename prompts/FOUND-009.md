# FOUND-009 — Configure Docker Development Environment

## Sprint

Sprint 1 — Foundation

---

## Objective

Containerize the KawaibFlow development environment using Docker and Docker Compose.

The environment should allow developers to start the API and Blazor Web applications with a single command.

---

## Context

Current project status:

- Solution structure completed.
- Dependency Injection configured.
- Entity Framework Core configured.
- ASP.NET Core API configured.
- Blazor Web configured.
- Strongly typed configuration implemented.
- Structured logging configured.

This issue prepares the solution for consistent local development.

---

## Requirements

### 1. Dockerfile for API

Create:

```
docker/api/Dockerfile
```

Use a multi-stage build.

Requirements:

- .NET 10 SDK for build stage
- .NET 10 ASP.NET runtime for runtime stage

---

### 2. Dockerfile for Web

Create:

```
docker/web/Dockerfile
```

Use a multi-stage build.

Requirements:

- .NET 10 SDK
- .NET 10 ASP.NET runtime

---

### 3. Docker Compose

Create:

```
docker/docker-compose.yml
```

Configure:

- kawaibflow-api
- kawaibflow-web

The Web container should depend on the API container.

---

### 4. Environment Variables

Configure:

```
ASPNETCORE_ENVIRONMENT=Development
```

Use Docker Compose environment variables.

---

### 5. Port Mapping

Expose:

API

```
8080
```

Web

```
8081
```

Avoid binding directly to ports commonly used by Visual Studio (5000/5001).

---

### 6. SQLite Persistence

Mount a Docker volume for the SQLite database.

Example:

```
volumes:
    - kawaibflow-data:/app/data
```

Update the connection string if necessary so the database resides in the mounted volume.

---

### 7. .dockerignore

Create:

```
.dockerignore
```

Exclude:

```
bin/
obj/
.git/
.vs/
```

---

### 8. Verification

The following command should succeed.

```bash
docker compose up --build
```

Both applications should start successfully.

---

## Acceptance Criteria

- API Dockerfile created.
- Web Dockerfile created.
- Docker Compose created.
- Docker volume configured.
- Containers build successfully.
- Containers start successfully.
- Solution builds successfully.

---

## Out of Scope

Do NOT implement:

- PostgreSQL
- Redis
- RabbitMQ
- Nginx
- Reverse Proxy
- Kubernetes
- Production optimization
- Container registry
- Multi-architecture builds

---

## Constraints

- Use multi-stage Docker builds.
- Keep images minimal.
- Keep Development configuration only.
- Do not introduce additional infrastructure.

---

## Expected Output

A reproducible Docker-based development environment for KawaibFlow.