import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RuoloService {

  baseUrl = "http://localhost:64454/api/Ruolo";

  constructor(private httpClient: HttpClient) { }
  
  public getRuoli() : Observable<any> {
    return this.httpClient.get(this.baseUrl + "/Get").pipe(map(res => {
      return res;
    }))
  }
}
