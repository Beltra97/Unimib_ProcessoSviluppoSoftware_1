# 2019_assignment1_IntranetAziendale

## Applicazione  

L'applicazione intranet aziendale permette di visualizzare la lista dei dipendenti di una azienda mostrandone nome, cognome ed email

## Membri  

Il progetto è stato sviluppato da: Beltramelli Fabio (816912) e Finati Davide (817508)

## Repository  

Il codice sorgente è disponibile su gitlab https://gitlab.com/Beltra97/2019_assignment1_intranetaziendale/

## Pipeline

È stata implementata una pipeline composta dai seguenti stages:

    - build: dotnet msbuild comando che tramite opportuni parametri consente di compilare un progetto e tutte le relative dipendenze  
    - verify: dotnet msbuild comando che tramite opportuni parametri compila il progetto mostrando il risultato di una checkstyle e code analysis  
    - unit tests: dotnet test comando per eseguire unit test  
    - integrations tests: dotnet test comando per eseguire integration test  
    - package: comando che comprime il codice in un pacchetto NuGet  

## Sviluppi futuri  

Verranno implementate gli ultimi due stages della pipeline: release e deploy