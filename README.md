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