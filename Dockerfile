FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine AS base
WORKDIR /app
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build
WORKDIR /src
COPY ["TellMeMoreBlazor/TellMeMoreBlazor.csproj", "TellMeMoreBlazor/"]
COPY ["TellMeMoreBlazor.Shared/TellMeMoreBlazor.Shared.csproj","TellMeMoreBlazor.Shared/"]
RUN dotnet restore "TellMeMoreBlazor/TellMeMoreBlazor.csproj"
COPY . .
WORKDIR "/src/TellMeMoreBlazor"
RUN dotnet build "TellMeMoreBlazor.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TellMeMoreBlazor.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENV ASPNETCORE_ENVIRONMENT=Production
ENTRYPOINT ["dotnet", "TellMeMoreBlazor.dll"]
