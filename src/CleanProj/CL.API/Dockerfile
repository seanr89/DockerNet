FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /app

# It's important to keep lines from here down to "COPY . ." identical in all Dockerfiles
# # to take advantage of Docker's build cache, to speed up local container builds
COPY "../CleanProj.sln" "CleanProj.sln"

COPY /CL.API.csproj API/
COPY ../CL.Domain.csproj Domain/

RUN dotnet restore API/API.csproj

COPY . .
RUN dotnet publish API/API.csproj -c Release -o out

COPY . .
WORKDIR /src/Services/Catalog/Catalog.API
RUN dotnet publish --no-restore -c Release -o /app