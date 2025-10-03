AzureAdSSO
Introduction

AzureAdSSO demonstrates how to establish Single Sign-On (SSO) using SAML with Azure Active Directory (Azure AD). This project is built with C# (.NET) and provides a reference for integrating enterprise authentication into web applications.

Table of Contents

Installation

Usage

Configuration

Features

Dependencies

Examples

Troubleshooting

Contributors

License

Installation

Clone the repository:

git clone https://github.com/Vivan-23/AzureAdSSO.git
cd AzureAdSSO


Open the solution file in Visual Studio:

AzureAdTest.sln


Restore dependencies:

dotnet restore


Build and run the project:

dotnet run

Usage

The application demonstrates how to connect to Azure AD via SAML authentication.

Launch the project and navigate to the configured endpoint to test the SSO login flow.

Use the provided controllers (in Controllers/) and constants (in ApplicationSamlConstants.cs) to extend the authentication logic.

Configuration

Update appsettings.json with your Azure AD details:

Entity ID

SAML Metadata URL

Reply URL (Assertion Consumer Service URL)

Client ID / Tenant ID (if required)

Ensure your application is registered in the Azure AD App Registrations portal.

Configure SAML-based Single Sign-On for the registered app in Azure AD.

Features

SSO integration using Azure AD + SAML.

Configurable via appsettings.json.

Example controllers and test HTTP requests (AzureAdTest.http).

Works with ASP.NET Core.

Dependencies

.NET Core / .NET 6+

Microsoft Identity Platform (Azure AD)

SAML authentication libraries (native/custom implementation in repo)

Examples

To test endpoints, use AzureAdTest.http with a REST client (e.g., Visual Studio Code REST Client extension or Postman).

Extend WeatherForecastController to secure APIs with SSO authentication.

Troubleshooting

Ensure Azure AD metadata URL is correct.

Verify Reply URL in Azure AD matches the one configured in appsettings.json.

If login fails, check logs in Visual Studio Output or console.

Confirm the application is using HTTPS, as Azure AD requires secure endpoints.

Contributors

Vivan-23

License

This project does not specify a license yet. If you plan to share it publicly, consider adding an open-source license (e.g., MIT, Apache 2.0).
