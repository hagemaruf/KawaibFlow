# KawaibFlow Engineering Handbook

Version: 1.0

Status: Active

Last Updated: July 2026

---

# 1. Vision

KawaibFlow is an Enterprise AI Automation Platform designed to help organizations build intelligent workflows, AI agents, browser automation, desktop automation, and enterprise integrations.

The platform focuses on enterprise-grade architecture, maintainability, extensibility, and modern software engineering practices.

---

# 2. Mission

Build an open-source AI automation platform that demonstrates enterprise software architecture and AI engineering best practices.

The project is intended to become a portfolio-quality system rather than a demo application.

---

# 3. Technology Stack

Frontend

- Blazor Web App (.NET 10)

Backend

- ASP.NET Core Web API (.NET 10)

Architecture

- Clean Architecture
- Modular Monolith
- Future Microservices

Database

- SQLite (Development)
- SQL Server (Production)

AI

- Microsoft.Extensions.AI
- Ollama
- OpenAI (Future)
- Azure OpenAI (Future)

Messaging

- RabbitMQ
- MassTransit (Future)

Automation

- Playwright
- Windows UI Automation (Future)

Deployment

- Docker
- Docker Compose

---

# 4. Architecture Principles

The project starts as a Modular Monolith.

Microservices will only be introduced when there is a clear architectural benefit.

Core principles:

- Domain-Driven Design
- Clean Architecture
- SOLID
- Dependency Injection
- Separation of Concerns
- Event-Driven Architecture (Future)

---

# 5. Solution Structure

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

---

# 6. Layer Responsibilities

Domain

Contains business rules only.

No external dependencies.

Application

Contains use cases, interfaces, orchestration, and application services.

Infrastructure

Contains EF Core, AI providers, persistence, messaging, integrations, and external services.

API

Exposes REST APIs.

Web

Blazor frontend.

Contracts

Shared DTOs and contracts.

---

# 7. Development Workflow

GitHub Issue

↓

Architecture Review

↓

Ready for Codex

↓

Implementation (Codex)

↓

Architecture Review

↓

Testing

↓

Pull Request

↓

Merge

↓

Close Issue

---

# 8. Team Roles

Software Architect

- System design
- Domain modeling
- Architecture decisions
- Technical review
- Sprint planning

Tech Lead

- Owns backlog
- Approves architecture
- Runs Codex
- Testing
- Merge Pull Requests

Senior Developer (Codex)

- Implementation
- Refactoring
- Unit Tests
- Build validation

---

# 9. Git Strategy

Main Branch

main

Feature Branch

feature/<issue-id>-<short-description>

Bugfix

bugfix/<issue-id>

Hotfix

hotfix/<issue-id>

---

# 10. Commit Convention

Use Conventional Commits.

Examples

feat(workflow): add workflow aggregate

fix(api): correct validation

docs(readme): update roadmap

refactor(domain): simplify workflow entity

chore(solution): initialize solution

---

# 11. GitHub Issue Convention

Every change starts with a GitHub Issue.

Issue Format

Issue ID

Title

Objective

Acceptance Criteria

Definition of Done

Labels

Milestone

Codex Prompt

Review Notes

---

# 12. Code Review Policy

Every implementation must be reviewed before merge.

Review Categories

Must Fix

Should Improve

Future Idea

No direct commits to main.

---

# 13. Definition of Done

A task is Done when:

- Acceptance Criteria satisfied
- Solution builds successfully
- No compile errors
- Code reviewed
- Tests pass (if applicable)
- Documentation updated
- Pull Request merged
- GitHub Issue closed

---

# 14. Coding Principles

Prefer composition over inheritance.

Avoid public setters for entities.

Protect invariants.

Keep Domain independent.

Use dependency injection.

Small focused services.

Readable code over clever code.

---

# 15. Current Roadmap

Phase 1

Foundation

Phase 2

Workflow Engine

Phase 3

Visual Workflow Builder

Phase 4

AI Execution Engine

Phase 5

RabbitMQ Integration

Phase 6

Microservices

Phase 7

Enterprise Connectors

Phase 8

Browser Automation

Phase 9

Desktop Automation

Phase 10

Computer Use Agent

---

# 16. Current Sprint

Sprint

Sprint 1

Milestone

Foundation

Current Status

In Progress

Completed

FOUND-001
Create Initial Solution Structure

Next Task

FOUND-002

---

# 17. Architecture Decision Records

Every significant technical decision must be documented.

Examples

ADR-001 Modular Monolith

ADR-002 Clean Architecture

ADR-003 AI Provider Abstraction

ADR-004 RabbitMQ Messaging

ADR-005 Microservice Migration

---

# 18. Long-Term Vision

KawaibFlow aims to become an enterprise-grade AI automation platform capable of orchestrating:

- AI Agents
- Enterprise APIs
- Browser Automation
- Desktop Automation
- Human Approval
- Scheduling
- Multi-Agent Collaboration
- Event-Driven Processing
- Cloud Deployment

---

# 19. Working Agreement

We follow these principles:

1. No coding without a GitHub Issue.

2. Architecture first.

3. Small Pull Requests.

4. One Issue = One Goal.

5. Review before merge.

6. Keep build green.

7. Keep Domain clean.

8. Document important decisions.

9. Prefer simplicity.

10. Build software like an enterprise team.


# 20. Engineering Philosophy

KawaibFlow is built to demonstrate professional software engineering rather than rapid feature development.

Every architectural decision should prioritize:

- Maintainability over shortcuts.
- Simplicity over unnecessary complexity.
- Extensibility over hard-coded solutions.
- Clear documentation over implicit knowledge.
- Long-term quality over short-term speed.

AI is used to accelerate implementation, not replace engineering judgment.

Human decisions remain responsible for architecture, design, and software quality.