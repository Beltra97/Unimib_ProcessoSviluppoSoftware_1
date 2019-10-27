import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ConvenzioneService {

  baseUrl = "http://localhost:64454/api/Convenzione";

  constructor(private httpClient: HttpClient) { }
  
  public getConvenzioni() : Observable<any> {
    return this.httpClient.get(this.baseUrl + "/Get").pipe(map(res => {
      return res;
    }))
  }

  public addConvenzione(titolo, descrizione) : Observable<any> {

    return this.httpClient.post(this.baseUrl + "/Add", 
    { 
      Titolo: titolo,
      Descrizione: descrizione,
    })
    .pipe(map(res => {
      return res;
    }))
  }

  public deleteConvenzione(idConvenzione) : Observable<any> {
    return this.httpClient.delete(this.baseUrl + "/Delete/" + idConvenzione)
    .pipe(map(res => {
      return res;
    }))
  }
}
