FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["src/KawaibFlow.Api/KawaibFlow.Api.csproj", "src/KawaibFlow.Api/"]
COPY ["src/KawaibFlow.Application/KawaibFlow.Application.csproj", "src/KawaibFlow.Application/"]
COPY ["src/KawaibFlow.Contracts/KawaibFlow.Contracts.csproj", "src/KawaibFlow.Contracts/"]
COPY ["src/KawaibFlow.Domain/KawaibFlow.Domain.csproj", "src/KawaibFlow.Domain/"]
COPY ["src/KawaibFlow.Infrastructure/KawaibFlow.Infrastructure.csproj", "src/KawaibFlow.Infrastructure/"]

RUN dotnet restore "src/KawaibFlow.Api/KawaibFlow.Api.csproj"

COPY . .
RUN dotnet publish "src/KawaibFlow.Api/KawaibFlow.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .
RUN mkdir -p /app/data && chown -R $APP_UID:$APP_UID /app/data

USER $APP_UID
ENTRYPOINT ["dotnet", "KawaibFlow.Api.dll"]
