FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["exercicioVolei/exercicioVolei.csproj", "exercicioVolei/"]
RUN dotnet restore "exercicioVolei/exercicioVolei.csproj"
COPY . .
WORKDIR "/src/exercicioVolei"
RUN dotnet build "exercicioVolei.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "exercicioVolei.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "exercicioVolei.dll"]
