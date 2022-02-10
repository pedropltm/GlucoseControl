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

## Database

### References

#### Microsoft
Create a web API with ASP.NET Core and MongoDB
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio-code

## Docker Compose File

### References

#### Medium - Renato Groffe
ASP.NET Core + Docker Compose: implementando soluções Web multi-containers
https://renatogroffe.medium.com/asp-net-core-docker-compose-implementando-solu%C3%A7%C3%B5es-web-multi-containers-5f46d22a2ca0

MongoDB + mongo-express + Docker Compose: montando rapidamente um ambiente para uso
https://renatogroffe.medium.com/mongodb-mongo-express-docker-compose-montando-rapidamente-um-ambiente-para-uso-824f25ca6957