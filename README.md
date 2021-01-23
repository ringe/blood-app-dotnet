

# Installation

This project was built on a Ubuntu 20.04 workstation.

I installed Node/NPM from the snap store, and used the official APT repository from Microsoft for the .NET SDK.

# Scaffolding the project

Before I start writing my own code, I pick an approach and find something to build upon.

I built a scaffold by following this guide, adjusted for new versions:
https://www.freecodecamp.org/news/how-to-build-an-spa-with-vuejs-and-c-using-net-core/
Took some tips from here as well:
https://bjdejongblog.nl/asp-net-core-tips-and-quick-setup-identity-system/

Starting in the project root folder, I ran some commands.

    $ vue create frontend

This prompted questions that I answered based on the guide.
Had to look up packages in the NuGet gallery for some of this.

    $ dotnet tool install --global dotnet-aspnet-codegenerator
    $ dotnet new web -o backend
    $ cd backend
    $ dotnet add package Microsoft.AspNetCore.SpaServices.Extensions --version 5.0.2
    $ dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 5.0.2
    $ dotnet add package Microsoft.EntityFrameworkCore --version 5.0.2
    $ dotnet add package Microsoft.Extensions.Configuration --version 5.0.0
    $ dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.2
    $ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.1

Let's get started.

# Running the project -- development mode

I haven't set out to deploy this code, so these instructions are to get it running in dev mode.

The fronted runs a node server for live updates / compiling assets.
The backend runs an ASP.NET server that proxies frontend requests to the node server.

Start the frontend server:

    $ cd frontend; npm run serve

Start the backend by pressing F5 in Visual Studio Code, or:

    $ dotnet run
