# HHH_ConnectAzureEntraID

A simple **ASP.NET MVC 5** project that demonstrates how to integrate with **Microsoft Azure Entra ID** (formerly Azure Active Directory).  
This project is part of my portfolio, showcasing authentication and secure sign-in using enterprise identity.

 🚀 Features
- 🔐 Authentication via **Azure Entra ID** (OpenID Connect + OWIN middleware)
- 👤 Login with corporate / organizational accounts
- 📄 Protected pages accessible only after login
- 🎨 Built with **ASP.NET MVC 5** + **OWIN 4**
- 📚 Easy to extend for role-based access and multi-factor authentication

---

 🛠️ Built With
- ASP.NET MVC 5
- OWIN Middleware
- Microsoft Identity Platform (Azure Entra ID)
- Visual Studio 2017

---

 💡 How to Run
1. Clone or download this repository
2. Open `HHH_ConnectAzureEntraID.sln` in **Visual Studio 2017**
3. Build and run the project
4. [Visual Studio](https://visualstudio.microsoft.com/) with ASP.NET MVC workload
- An **Azure Entra ID tenant** (free developer account available)
- App Registration created in Azure Portal with:
  - Client ID
  - Tenant ID
  - Redirect URI (`https://localhost:44300/signin-oidc` or your app’s URL)

## 🙋‍♂️ Author
**Htwe Htwe Hlaing**  
🧑‍💻 .NET Developer  
📧 [htwehtwehlaing.93@example.com]  
🔗 [LinkedIn](https://www.linkedin.com/in/htwe-htwe-hlaing-37140a338) | [GitHub](https://github.com/htwehtwehlaing-codes)
