FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy project file(s) and restore dependencies
COPY ["dockeraws/dockeraws.csproj", "dockeraws/"]
RUN dotnet restore "./dockeraws/dockeraws.csproj"

# Copy the rest of the source code and build the application
COPY . .
WORKDIR "/src/dockeraws"

# Debug: Print the build configuration
RUN echo "Building in $BUILD_CONFIGURATION mode"

# Simplified build command for troubleshooting
RUN dotnet build "./dockeraws.csproj" -c $BUILD_CONFIGURATION

# Continue with publishing if the build succeeds
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./dockeraws.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dockeraws.dll"]
