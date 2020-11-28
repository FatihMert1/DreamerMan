FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o Output
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/Output .
ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000
ENTRYPOINT [ "dotnet",".\Output\DreamerMan.Api.dll" ]