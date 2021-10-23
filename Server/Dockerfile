# https://hub.docker.com/_/microsoft-dotnet
# FROM mcr.microsoft.com/dotnet/aspnet:3.1-buster-slim
# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.3-alpine AS base
# FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY EF/*.csproj ./EF/
COPY MyToDoApp/*.csproj ./MyToDoApp/
RUN dotnet restore

# copy everything else and build app
COPY EF/. ./EF/
COPY MyToDoApp/. ./MyToDoApp/
WORKDIR /source/MyToDoApp

RUN dotnet build "MyToDoApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyToDoApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyToDoApp.dll"]