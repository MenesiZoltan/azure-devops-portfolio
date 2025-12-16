# azure-devops-portfolio

This repository demonstrates CI/CD practices and Azure-based deployment using GitHub Actions.
It is intended as a small-scale portfolio project.

The project is developed incrementally and divided into phases. This README is updated as each
phase’s goals and achievements are completed.

---

## Phase 1 Overview

- **1/A:** Minimal .NET API
- **1/B:** CI/CD Pipelines
  - Continuous Integration (CI)
  - Continuous Deployment (CD)
- **1/C:** Azure Functions deployment

---

## 1/A — Minimal .NET API

A minimal .NET Web API was created to serve as the deployment target for CI/CD automation.

The application exposes:
- `/health` — basic health check endpoint
- `/version` — application version endpoint (used later for CI/CD validation)

---

## 1/B — CI/CD Pipelines

This phase focuses on establishing a robust CI pipeline using GitHub Actions,
with enforced branch protection to prevent faulty code from reaching the `main` branch.

---

### 1/B.1 — Continuous Integration (CI)

#### CI Pipeline

The CI pipeline is implemented using GitHub Actions and is triggered on:
- Pull requests targeting `dev` and `main`
- Pushes to `dev` and `main`

Pipeline steps:
- Restore dependencies
- Build the solution
- Run automated tests

#### Branching & Validation

The repository follows a promotion-based branching strategy:
- Feature branches are created from `dev`
- Feature branches are merged back into `dev` via pull request
- Promotions to `main` happen via pull request from `dev`

The `main` branch is protected with:
- Required pull requests before merging
- Required CI status checks
- Force-push protection

This ensures that faulty or unvalidated changes cannot reach production.

#### CI Enforcement Proof

The following pull request demonstrates that failing builds are blocked
from being merged into the protected `main` branch by required CI checks:

- ❌ Failing PR (blocked by CI):  
  https://github.com/MenesiZoltan/azure-devops-portfolio/pull/6

---

### 1/B.2 — Continuous Deployment (CD)

*Planned next iteration.*

This phase will introduce automated deployments to Azure using GitHub Actions, including:
- Secure Azure authentication
- Environment variables and secrets management
- Deployment to free-tier Azure services

---

## Next Steps

The next phase will complete Phase 1 by introducing continuous deployment
to Azure Functions using a consumption-based (free-tier) setup.
