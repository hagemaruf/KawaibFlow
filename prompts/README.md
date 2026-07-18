# KawaibFlow Prompts

Welcome to the KawaibFlow AI prompt repository.

This directory stores all version-controlled prompts used during the
development of KawaibFlow. Prompts are treated as engineering artifacts
and maintained alongside the source code.

## Purpose

-   Keep AI prompts under version control.
-   Make AI-assisted development reproducible.
-   Preserve implementation history.
-   Standardize prompt quality.

## Directory Structure

``` text
prompts/
├── README.md
├── foundation/
├── workflow-engine/
├── visual-builder/
├── ai-engine/
├── browser-automation/
├── desktop-automation/
├── connectors/
└── experiments/
```

## Naming Convention

Use the GitHub Issue ID as the filename (e.g. FOUND-001.md).

## Standard Prompt Sections

-   Issue
-   Sprint
-   Objective
-   Context
-   Requirements
-   Acceptance Criteria
-   Constraints
-   Expected Output
-   Notes

## Prompt Lifecycle

``` text
Draft → Architecture Review → Tech Lead Approval → Codex Execution → Review → Git
```

## Responsibilities

**Software Architect** - Create prompts - Review architecture - Review
implementation

**Tech Lead** - Approve prompts - Execute Codex - Test, commit, merge

**Codex** - Implement approved prompts - Do not change architecture

## Principles

-   One issue = one prompt.
-   One prompt = one implementation goal.
-   Prompts are version-controlled engineering artifacts.
