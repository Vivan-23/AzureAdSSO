
# AzureAdSSO

## Introduction

**AzureAdSSO** demonstrates how to establish **Single Sign-On (SSO)** using **SAML** with **Azure Active Directory (Azure AD)**. This project is built with **C# (.NET)** and provides a reference for integrating enterprise authentication into web applications.

---

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Configuration](#configuration)
4. [Features](#features)
5. [Dependencies](#dependencies)
6. [Examples](#examples)
7. [Troubleshooting](#troubleshooting)
8. [Contributors](#contributors)

---

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/Vivan-23/AzureAdSSO.git
   cd AzureAdSSO
   ```
2. Open the solution file in **Visual Studio**:

   ```bash
   AzureAdTest.sln
   ```
3. Restore dependencies:

   ```bash
   dotnet restore
   ```
4. Build and run the project:

   ```bash
   dotnet run
   ```

---

## Usage

* The application demonstrates how to connect to Azure AD via **SAML authentication**.
* Launch the project and navigate to the configured endpoint to test the SSO login flow.
* Use the provided controllers (in `Controllers/`) and constants (in `ApplicationSamlConstants.cs`) to extend the authentication logic.

---

## Configuration

1. Update **`appsettings.json`** with your Azure AD details:

   * **Entity ID**
   * **SAML Metadata URL**
   * **Reply URL (Assertion Consumer Service URL)**
   * **Client ID / Tenant ID** (if required)

2. Ensure your application is registered in the **Azure AD App Registrations** portal.

3. Configure **SAML-based Single Sign-On** for the registered app in Azure AD.

---

## Features

* SSO integration using **Azure AD + SAML**.
* Configurable via `appsettings.json`.
* Example controllers and test HTTP requests (`AzureAdTest.http`).
* Works with **ASP.NET Core**.

---

## Dependencies

* **.NET Core / .NET 6+**
* **Microsoft Identity Platform** (Azure AD)
* SAML authentication libraries (native/custom implementation in repo)

---

## Examples

* To test endpoints, use `AzureAdTest.http` with a REST client (e.g., **Visual Studio Code REST Client extension** or **Postman**).
* Extend `WeatherForecastController` to secure APIs with SSO authentication.

---

## Troubleshooting

* Ensure Azure AD metadata URL is correct.
* Verify **Reply URL** in Azure AD matches the one configured in `appsettings.json`.
* If login fails, check logs in **Visual Studio Output** or console.
* Confirm the application is using **HTTPS**, as Azure AD requires secure endpoints.

---

## Contributors

* [Vivan-23](https://github.com/Vivan-23)

---
