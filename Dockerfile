FROM microsoft/dotnet:2.2-sdk as build-env
WORKDIR /app

COPY . .

WORKDIR /app/IntranetAziendale/IntranetAziendale
RUN dotnet publish -c Release -o /publish

FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /publish
COPY --from=build-env /publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet IntranetAziendale.dll
