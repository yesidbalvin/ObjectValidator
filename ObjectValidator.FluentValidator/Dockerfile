#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ObjectValidator.FluentValidator/ObjectValidator.FluentValidator.csproj", "ObjectValidator.FluentValidator/"]
COPY ["ObjectValidator.Domain/ObjectValidator.Domain.csproj", "ObjectValidator.Domain/"]
RUN dotnet restore "ObjectValidator.FluentValidator/ObjectValidator.FluentValidator.csproj"
COPY . .
WORKDIR "/src/ObjectValidator.FluentValidator"
RUN dotnet build "ObjectValidator.FluentValidator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ObjectValidator.FluentValidator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObjectValidator.FluentValidator.dll"]