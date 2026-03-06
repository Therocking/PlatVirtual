FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /source

COPY . .
RUN dotnet restore "./PlatVirtual/PlatVirtual.csproj" --disable-parallel
RUN dotnet publish "./PlatVirtual/PlatVirtual.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY --from=base /app ./

EXPOSE 5042

ENTRYPOINT ["dotnet", "PlatVirtual.dll"]
