# 2019_assignment1_IntranetAziendale

## Applicazione  

L'applicazione intranet aziendale, scritta in .NET Core, permette di visualizzare i dettagli di dipendenti e convenzioni di un’azienda presenti nel database (mysql).  
L’applicazione permette inoltre di aggiungere un nuovo dipendete o una nuova convenzione oltre che poterne eliminare uno già presente.  
In particolare, il database presenta 3 tabelle:  
- Dipendente: (ID, Cognome, Nome, Username, Psw, IDruolo)  
- Convenzione: (ID, Titolo, Descrizione)  
- Ruolo: (ID, Nome)  

Link applicazione: http://deployintranetaziendale.herokuapp.com  

## Membri  

Il progetto è stato sviluppato da: Beltramelli Fabio (816912) e Finati Davide (817508)

## Repository  

Il codice sorgente è disponibile su gitlab: https://gitlab.com/Beltra97/2019_assignment1_intranetaziendale/

## Considerazioni

Versioni release:  
i nomi delle versioni sono state gestite nel nostro caso con questo formato: 1.0.x, dove x sta ad indicare l'ID univoco della build.  
Questo perchè abbiamo riscontrato delle difficoltà in una gestione incrementale e più ottimizzata delle stesse (1.0.1 -> 1.0.2 -> ecc)

## DEVOPS

È stata implementata una pipeline composta dai seguenti stages:

1. build: dotnet msbuild comando che tramite opportuni parametri consente di compilare un progetto e tutte le relative dipendenze  
2. verify: dotnet msbuild comando che tramite opportuni parametri compila il progetto mostrando il risultato di una checkstyle e code analysis  
3. unit-test: dotnet test comando per eseguire unit test  
4. integration-test: dotnet test comando per eseguire integration test  
5. package: dotnet pack comando che comprime il codice in un pacchetto NuGet  
6. release: comando che genera una release creando un tag associato ad un commit  
7. deploy: comando che carica un immagine docker di .NET Core direttamente su heroku che si occuperà della pubblicazione 

## Branches

Sono stati creati e utilizzati i branch master e develop.  
Nel branch master vengono eseguiti tutti gli stage della pipeline mentre nel branch develop vengono effettuati tutti gli stage fino al package (vengono esclusi release e deploy)
