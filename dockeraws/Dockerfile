# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=base /app/out ./

EXPOSE 80
ENTRYPOINT ["dotnet", "dockeraws.dll"]


