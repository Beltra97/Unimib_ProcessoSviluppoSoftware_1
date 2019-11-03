FROM microsoft/dotnet:2.2-sdk as build-env
WORKDIR /app

RUN curl -sL https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install -y nodejs
RUN npm install -g @angular/cli

COPY . .

WORKDIR /app/IntranetAziendale/IntranetAziendale
RUN dotnet publish -c Release -o /publish

FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /publish
COPY --from=build-env /publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet IntranetAziendale.dll
