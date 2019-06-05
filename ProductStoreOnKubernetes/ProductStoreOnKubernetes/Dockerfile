FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 3317
EXPOSE 44361

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ProductStoreOnKubernetes/ProductStoreOnKubernetes.csproj ProductStoreOnKubernetes/
RUN dotnet restore ProductStoreOnKubernetes/ProductStoreOnKubernetes.csproj
COPY . .
WORKDIR /src/ProductStoreOnKubernetes
RUN dotnet build ProductStoreOnKubernetes.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProductStoreOnKubernetes.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProductStoreOnKubernetes.dll"]
