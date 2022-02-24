# GlucoseControl

## Docker

### Iniciando um novo projeto

  #### Pré Requisitos

    * VS Code (recomendado) ou outra IDE de sua preferência;
    * Docker For Windows
    * Ter uma conta no Docker HUB

  #### Passo a passo

    1. Clonar o projeto em seu diretório local desejado;
    2. Abrir a pasta do projeto no VS Code;
    3. No VS Code:
       3.1 Instalar extensões
         3.1.1 C# for Visual Studio Code (ou similar, no caso de outra IDE)
         3.1.2 Docker for Visual Studio Code (ou similar, no caso de outra IDE)
       3.2 Abrir o terminal
       3.3 Navegar até o diretório clonado
       3.4 docker --version
       3.5 docker image build -t seuambienteDockerHUB/glucosecontrolapi .
       3.6 docker container run --name DockerDotnetAPI -p 8080:80 seuambienteDockerHUB/glucosecontrolapi
       3.7 docker image push seuambienteDockerHUB/glucosecontrolapi
       3.8 docker-compose up -d

## API

### Editing the API

  #### Requirements

    * VS Code (recommended) or another IDE of your personal preference
    * Docker For Windows
    * Have an account on Docker HUB

  #### Step by Step

    1. Clone the project inside your local folder choosen;
    2. Open the project folder in VS Code;
    3. In VS Code:
      3.1 Install extensions
        3.1.1 C# for Visual Studio Code (or similar, if you prefer another IDE)
        3.1.2 Docker for Visual Studio Code (or similar, if you prefer another IDE)
    4. Make your changes
    5. Update your docker container

### Updating docker container

  #### Requirements

    * VS Code (recommended) or another IDE of your personal preference
    * Docker For Windows
    * Have an account on Docker HUB

  #### Step by Step

  1. Clone the project inside your local folder choosen (if you did not yet)
  2. Open the terminal
  3. Navigate to the cloned folder
  4. Build your new image version with your modifications

  ```powershell
  $ docker image build -t yourEnvDockerHUB/glucosecontrolapi:version-name .
  ```

  5. Create the container with the new image version

  ```powershell
  $ docker container run --name GlucoseControlApi -p 8080:80 yourEnvDockerHUB/glucosecontrolapi:version-name
  ```

  6. Push the image for the DockerHUB repository

  ```powershell
  $ docker image push yourEnvDockerHUB/glucosecontrolapi:version-name
  ```

  7. Update your docker compose file with the new dockerfile updated version

  ```powershell
  $ docker-compose up -d
  ```

### Executing the API

  #### Requirements

    * Git Bash;
    * Docker For Windows

  #### Recommended

    * Git Extensions, Source Tree or Smart Git

  #### Step by Step

    1. Clone the project inside your local folder choosen (if you did not yet)
    2. Open the terminal
    3. Navigate to the cloned folder
    4. > docker --version
    5. > docker-compose up -d

### Testing the API

  #### Requirements
  
    * Insomnia (recommended) or another IDE of your personal preference
    * Docker For Windows

  #### Step by Step

    1. Execute the API (as explained before)
    2. Open Insomnia
    3. API Microservices
      3.1. Meals
        GetMeals
        GetMeal
        PostMeal
        PutMeal
        DeleteMeal
      3.2. Medicines
        GetMedicines
        GetMedicine
        PostMedicine
        PutMedicine
        DeleteMedicine
      3.3. Patients
        GetPatient
        GetPatient
        PostPatient
        PutPatient
        DeletePatient
      3.3. PhysicalActivities
        GetPhysicalActivities
        GetPhysicalActivity
        PostPhysicalActivity
        PutPhysicalActivity
        DeletePhysicalActivity
      3.4. Scoutings
        GetScoutings
        GetScouting
        PostScouting
        PutScouting
        DeleteScouting

### Swagger
https://localhost:7121/swagger/

### References

#### Youtube - Les Jackson
Deploy a .NET Core API with Docker (Step-by-Step)
https://www.youtube.com/watch?v=f0lMGPB10bM

#### Udemy - Leonardo Moura Leitão, Arquiteto de Software
Docker: Ferramenta essencial para Desenvolvedores
http://www.udemy.com

#### Docker - Official Site
Dockerize an ASP.NET Core application
https://docs.docker.com/samples/dotnetcore/

#### Microsoft
Tutorial: Create a web API with ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code

#### Mozilla
405 Method Not Allowed
https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status/405

## Database

### References

#### Microsoft
Create a web API with ASP.NET Core and MongoDB
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio-code

#### Luís Dev
ASP.NET Core e MongoDB: Implementando uma API com banco de dados NoSQL
https://www.luisdev.com.br/2020/07/27/asp-net-core-e-mongodb-implementando-uma-api-com-banco-de-dados-nosql/

#### Stack Overflow
MongoDb authentication failing on accessing database while using docker?
https://stackoverflow.com/questions/62414739/mongodb-authentication-failing-on-accessing-database-while-using-docker

#### Dev.to
Developing a CRUDAPI with ASP.NET Core, MongoDB Docker, Swagger.
https://dev.to/etnicholson/developing-a-crudapi-with-asp-net-core-mongodb-docker-swagger-cf4

#### Dockerhub
mongo - Quick Reference
https://hub.docker.com/_/mongo

## Docker Compose File

### References

#### Medium - Renato Groffe
ASP.NET Core + Docker Compose: implementando soluções Web multi-containers
https://renatogroffe.medium.com/asp-net-core-docker-compose-implementando-solu%C3%A7%C3%B5es-web-multi-containers-5f46d22a2ca0

MongoDB + mongo-express + Docker Compose: montando rapidamente um ambiente para uso
https://renatogroffe.medium.com/mongodb-mongo-express-docker-compose-montando-rapidamente-um-ambiente-para-uso-824f25ca6957

#### Medium - Kristaps Dzērve-Štrāls - Software develop
Docker + MongoDB + .NET Core = a good time
https://medium.com/@kristaps.strals/docker-mongodb-net-core-a-good-time-e21f1acb4b7b


#### Github
How to setup the dev certificate when using Docker in development
https://github.com/dotnet/AspNetCore.Docs/issues/6199

#### Docker - Oficcial Site
Dockerfile Reference - EXPOSE
https://docs.docker.com/engine/reference/builder/#expose

#### Microsoft
Tutorial: Criar um aplicativo de vários contêineres com o Docker Compose
https://docs.microsoft.com/pt-br/visualstudio/containers/tutorial-multicontainer?view=vs-2022

#### Udemy - Leonardo Moura Leitão, Arquiteto de Software
Docker: Ferramenta essencial para Desenvolvedores
https://www.udemy.com/course/curso-docker/learn/lecture/7559986

#### Yarn
https://dev.to/aminnairi/preact-vite-docker-compose-in-5-easy-steps-j21

#### Vite
https://www.aroundcode.io/dockerizing-vite-react-app/

#### Sharklabs
React.js + Docker: Desenvolvendo Web Apps
https://sharklabs.com.br/reactjs-docker-desenvolvendo-web-apps/


## Terminal Summary Commands by Branch

### branch-0001

  ```powershell
  $ dotnet new webapi -o GlucoseControl
  ```

  ```powershell
  $ dotnet add package Microsoft.EntityFrameworkCore.InMemory --prerelease
  ```

  ```powershell
  $ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --prerelease
  ```

  ```powershell
  $ dotnet add package Microsoft.EntityFrameworkCore.Design --prerelease
  ```

  ```powershell
  $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --prerelease
  ```

  ```powershell
  $ dotnet tool install -g dotnet-aspnet-codegenerator --version 6.0.1 
  ```

  ```powershell
  $ dotnet aspnet-codegenerator controller -name MealsController -async -api -m Meal -dc GlucoseControlContext -outDir Controllers
  ```

  ```powershell
  $ dotnet aspnet-codegenerator controller -name MedicinesController -async -api -m Medicine -dc GlucoseControlContext -outDir Controllers
  ```
  
  ```powershell
  $ dotnet aspnet-codegenerator controller -name PatientsController -async -api -m Patient -dc GlucoseControlContext -outDir Controllers
  ```
  
  ```powershell
  $ dotnet aspnet-codegenerator controller -name ScoutingsController -async -api -m Scouting -dc GlucoseControlContext -outDir Controllers
  ```

### branch-0002

Empty

### branch-0003

Empty

### branch-0004

#### Installing MongoDB
```powershell
$ dotnet add package MongoDB.driver
```

```powershell
$ dotnet dev-certs https --trust
```

```powershell
$ dotnet tool install -g Microsoft.dotnet-httprepl
```

```powershell
$ httprepl https://localhost:7121/api/Meals
```

### branch-0005`

#### Initializes the repository crating package.json and removes the container in the end of execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1  yarn init -y
```

#### Installs react and removes the container in the end of execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1 yarn add react
```

#### Installing react with vite
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1 yarn add react vite
```

#### Starts the docker-compose services containers without creates a new container if it already exists
```powershell
$ docker-compose up -d --no-recreate
```

#### Starts the docker-compose yarn service container without creates a new container if it already exists
```powershell
$ docker-compose up -d --no-recreate yarn
```

#### Installs react-dom and removes the container in the end of execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1 yarn add react-dom
```

#### Installs babel compiler and removes the container in the end of execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1  yarn add @babel/core @babel/cli @babel/preset-env -D
```

#### Installs babel preset-react and removes the container in the end of execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1  yarn add @babel/preset-react -D
```

#### Installs webpack and webpack-cli dependencies and removes the container after its execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1  yarn add webpack webpack-cli -D
```

#### Installs babel-loeader dependency and removes the container after its execution
```powershell
$ docker-compose run --rm --name glucosecontrol-yarn-1  yarn add babel-loader -D
```