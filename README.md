# Auth0 enabled Web App and API with Swagger

This repository consists of two Web applications, both using [Auth0](https://auth0.com) to identify users.

The [Web API](./swaggerapi) is built on ASP.NET Core using [Swagger](http://swagger.io) to document its methods and models.

![Swagger UI](./images/swagger.png)

The [Web App](./swaggerweb) also built on ASP.NET Core is using [Autorest](https://github.com/Azure/autorest) to auto-generate a client based on the Web API Swagger documentation.

Both applications have a configuration file that you will need to fill with your [Auth0 Account details 
](https://manage.auth0.com/).

In the [Web API appsettings.json](./swaggerapi/appsettings.json), you need to fill your Auth0 domain and client id.

    {
      "Auth0": {
        "Domain": "{YOUR_AUTH0_DOMAIN}",
        "ClientId": "{YOUR_AUTH0_CLIENTID}"
      }
    }

In the [Web App appsettings.json](./swaggerweb/appsettings.json), you need to fill some extra values plus the CallbackUrl, which should be equal to your Web App running domain.

    {
     "Auth0": {
        "Domain": "{YOUR_AUTH0_DOMAIN}",
        "ClientId": "{YOUR_AUTH0_CLIENTID}5YQtqSO6lJfVgGusKd7TnuO0gqfUfNdY",
        "ClientSecret": "{YOUR_AUTH0_CLIENTSECRET}",
        "CallbackUrl": "http://localhost:5000/signin-auth0"
      } 
    }