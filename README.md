# Order Processing Application

## Overview
This is a simple ASP.NET Core MVC application that processes customer orders and applies discounts based on customer type.

## Features
- Order entry form
- Discount calculation logic
- Results page displaying discount and final order total
- Automated unit tests using xUnit
- CI/CD pipeline using GitHub Actions

## Setup Instructions
### Prerequisites
- Install **.NET 8 SDK** or later
- Install **Visual Studio** with ASP.NET Core workload
- Install **Git**
- Install **xUnit** via NuGet package manager

### Clone the Repository
```sh
git clone https://github.com/kynsai06/OrderProcessingApp.git
cd OrderProcessingApp
```

### Build and Run the Application
```sh
dotnet build
dotnet run
```
Open a browser and navigate to `https://localhost:5001`

## Git Branching Strategy
This project follows a structured Git branching strategy:

- **`main`** → Stable production-ready branch
- **`feature/order-processing`** → Implements the order processing logic
- **`feature/unit-tests`** → Contains xUnit tests for discount logic
- **`feature/ci-cd`** → Handles GitHub Actions for CI/CD

### Creating a New Branch
```sh
git checkout -b feature/new-feature
```

### Merging Branches into `main`
```sh
git checkout main
git pull origin main
git merge feature/new-feature
git push origin main
```

## Running Unit Tests
```sh
dotnet test
```

## CI/CD Pipeline
This project uses **GitHub Actions** for automated testing on each commit.

## Contribution Guidelines
1. Create a new branch for each feature or bugfix.
2. Write clear and descriptive commit messages.
3. Submit a pull request for review before merging.



