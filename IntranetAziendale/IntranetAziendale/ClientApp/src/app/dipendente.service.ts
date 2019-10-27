import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DipendenteService {

  baseUrl = "http://localhost:64454/api/Dipendente";

  constructor(private httpClient: HttpClient) { }
  
  public getDipendenti() : Observable<any> {
    return this.httpClient.get(this.baseUrl + "/Get").pipe(map(res => {
      return res;
    }))
  }

  public addDipendente(cognome, nome, username, password, idRuolo) : Observable<any> {

    return this.httpClient.post(this.baseUrl + "/Add", 
    { 
      Cognome: cognome,
      Nome: nome,
      Username: username,
      Psw: password,
      IDRuolo: idRuolo
    })
    .pipe(map(res => {
      return res;
    }))
  }

  public deleteDipendente(idDipendente) : Observable<any> {
    return this.httpClient.delete(this.baseUrl + "/Delete/" + idDipendente)
    .pipe(map(res => {
      return res;
    }))
  }
}
