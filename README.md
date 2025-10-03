# 🔐 Azure AD SSO (SAML)

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![Azure AD](https://img.shields.io/badge/Azure%20AD-SSO-blue?logo=microsoftazure)
![License](https://img.shields.io/badge/license-MIT-green)
![Build](https://github.com/Vivan-23/AzureAdSSO/actions/workflows/dotnet.yml/badge.svg)

A reference implementation of **Single Sign-On (SSO) with Azure Active Directory** using **SAML 2.0** in a .NET application.  
This repo demonstrates how to configure your app as a **Service Provider (SP)** and integrate it with Azure AD as the **Identity Provider (IdP)**.

---

## 🏗️ Architecture

```mermaid
flowchart LR
    User[👩 User] -->|1. Accesses App| SP[📦 Service Provider (.NET App)]
    SP -->|2. Redirect AuthnRequest| IdP[☁️ Azure AD (IdP)]
    IdP -->|3. Authenticates User| IdP
    IdP -->|4. SAML Response (Assertion)| SP
    SP -->|5. Validate Token & Create Session| User
🔑 Flow Summary:

User tries to access the app

App redirects them to Azure AD login

Azure AD authenticates the user

Azure AD sends a SAML Assertion back

App validates and creates session

📂 Project Structure
plaintext
Copy code
AzureAdSSO/
 ├── Controllers/           # MVC controllers for SSO flow
 ├── Properties/            # Project settings
 ├── ApplicationSamlConstants.cs  # SAML constants (ACS URL, Entity ID, etc.)
 ├── Program.cs             # Entry point
 ├── appsettings.json       # Azure AD + SAML configuration
 ├── AzureAdTest.http       # Example HTTP test file
 └── README.md              # 📖 You are here
🚀 Features
✅ Azure AD SSO via SAML 2.0

✅ Handles Authentication Requests & Responses

✅ Secure token validation with signature & audience checks

✅ Simple, extensible .NET 8.0 project structure

✅ Example configuration & test endpoints

🛠️ Prerequisites
.NET 8.0 SDK

Azure Active Directory tenant

Admin access to register an Enterprise Application in Azure AD

Visual Studio 2022 / Rider / VS Code

⚙️ Setup Guide
1️⃣ Configure Azure AD
Go to Azure Active Directory → Enterprise Applications

Click New Application → Create your own application

Choose Integrate any other application you don’t find in the gallery (Non-gallery)

Enable SAML-based Sign-On

Configure the following:

Identifier (Entity ID):
https://localhost:5001/saml/metadata

Reply URL (ACS):
https://localhost:5001/saml/acs

Logout URL (optional):
https://localhost:5001/saml/logout

Download the Federation Metadata XML and update your project settings.

2️⃣ Update App Settings
In appsettings.json:

json
Copy code
{
  "Saml": {
    "EntityId": "https://localhost:5001/saml/metadata",
    "AssertionConsumerServiceUrl": "https://localhost:5001/saml/acs",
    "IdPMetadataUrl": "https://login.microsoftonline.com/{tenantId}/federationmetadata/2007-06/federationmetadata.xml",
    "CertificateThumbprint": "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
  }
}
3️⃣ Run the Application
bash
Copy code
dotnet restore
dotnet build
dotnet run
The app will start on https://localhost:5001.

🔍 Testing
Open browser → https://localhost:5001/

You should be redirected to Azure AD Login.

After successful login, you’ll be redirected back with a valid SAML Assertion.

📸 Screenshots (Optional)
Add screenshots of login page, redirect flow, and post-login state here.

📖 Useful Resources
Microsoft Docs: Azure AD SAML SSO

SAML 2.0 Specification

🤝 Contributing
PRs are welcome! If you’d like to add features (e.g. multi-tenant, logout flow, refresh certs), open an issue first to discuss.
