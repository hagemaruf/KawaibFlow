FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["src/KawaibFlow.Web/KawaibFlow.Web.csproj", "src/KawaibFlow.Web/"]
COPY ["src/KawaibFlow.Application/KawaibFlow.Application.csproj", "src/KawaibFlow.Application/"]
COPY ["src/KawaibFlow.Contracts/KawaibFlow.Contracts.csproj", "src/KawaibFlow.Contracts/"]
COPY ["src/KawaibFlow.Domain/KawaibFlow.Domain.csproj", "src/KawaibFlow.Domain/"]

RUN dotnet restore "src/KawaibFlow.Web/KawaibFlow.Web.csproj"

COPY . .
RUN dotnet publish "src/KawaibFlow.Web/KawaibFlow.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8081

COPY --from=build /app/publish .

USER $APP_UID
ENTRYPOINT ["dotnet", "KawaibFlow.Web.dll"]
