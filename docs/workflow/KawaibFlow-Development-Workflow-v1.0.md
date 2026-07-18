# KawaibFlow Development Workflow v1.0

**Version:** 1.0\
**Status:** Active\
**Last Updated:** July 2026

## 1. Purpose

This document defines the operational workflow used by the KawaibFlow
team to plan, design, implement, review, test, and deliver software.

It complements the Engineering Handbook by describing **how the team
works**, while the handbook defines **how the software is built**.

## 2. Team Roles

### Tech Lead

-   Own product backlog
-   Create GitHub Issues
-   Plan sprints
-   Create feature branches
-   Execute Codex
-   Perform local testing
-   Commit code
-   Create Pull Requests
-   Merge approved Pull Requests

### Software Architect

-   Review architecture
-   Review GitHub Issues
-   Validate system design
-   Produce implementation plans
-   Generate Codex prompts
-   Review implementation
-   Maintain ADRs
-   Approve architecture before merge

### Senior Developer (Codex)

-   Implement approved design
-   Refactor code
-   Add tests
-   Ensure successful build
-   Never change architecture without approval

## 3. Development Lifecycle

``` text
GitHub Issue
↓
Architecture Review
↓
Architecture Approved
↓
Create Feature Branch
↓
Generate Codex Prompt
↓
Codex Implementation
↓
Local Build
↓
Architecture Review
↓
Local Testing
↓
Commit
↓
Pull Request
↓
Review
↓
Merge
↓
Close Issue
```

## 4. Branch Strategy

-   Main: `main`
-   Feature: `feature/<issue-id>-<short-description>`
-   Bugfix: `bugfix/<issue-id>`
-   Hotfix: `hotfix/<issue-id>`

## 5. GitHub Project Workflow

Backlog → Sprint Ready → Architecture Review → Ready for Codex →
Implementation → Architecture Review → Testing → Pull Request → Done

## 6. Definition of Ready (DoR)

-   Requirements understood
-   Architecture reviewed
-   Dependencies identified
-   Acceptance criteria defined
-   Scope fits one PR

## 7. Definition of Done (DoD)

-   Acceptance criteria satisfied
-   Build succeeds
-   Tests pass
-   Architecture review completed
-   PR approved
-   Merged to `main`
-   Issue closed

## 8. Code Review Checklist

-   Clean Architecture respected
-   No layer violations
-   Domain independent
-   Good abstractions
-   Proper DI
-   REST conventions
-   Validation
-   Logging
-   Tests
-   Documentation

## 9. Pull Request Checklist

-   Build succeeds
-   Tests pass
-   No debug code
-   Documentation updated
-   ADR updated if needed

## 10. Commit Workflow

Use Conventional Commits.

## 11. ADR Workflow

Create ADRs for significant architectural decisions.

## 12. Sprint Workflow

1.  Sprint Planning
2.  Backlog Review
3.  Architecture Review
4.  Implementation
5.  Code Review
6.  Testing
7.  Sprint Review
8.  Retrospective

## 13. AI Collaboration Workflow

``` text
Tech Lead
↓
Software Architect (ChatGPT)
↓
Architecture Approved
↓
Codex Implementation
↓
Software Architect Review
↓
Tech Lead Testing
↓
Merge
```

## 14. Working Agreement

-   Architecture before implementation
-   One issue = one goal
-   Small PRs
-   No direct commits to `main`
-   Keep the build green
-   Document significant decisions
-   Keep workflow and handbook up to date
