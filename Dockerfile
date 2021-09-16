FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 5000

# ENV ASPNETCORE_URLS=http://+:5000
ARG BUILD_CONFIGURATION=Debug
# ENV DOTNET_USE_POLLING_FILE_WATCHER=true 
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=http://+:5000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY . .
RUN dotnet restore "aam-bonmark.sln"
# WORKDIR "/src/projects/app/aam-bonmark-api"
RUN dotnet build "projects/app/aam-bonmark-api" -c Release -o /app/build

FROM build AS publish
RUN ls -la
RUN dotnet publish "projects/app/aam-bonmark-api" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
RUN ls -la
ENTRYPOINT ["dotnet", "publish/aam-bonmark-api.dll"]
