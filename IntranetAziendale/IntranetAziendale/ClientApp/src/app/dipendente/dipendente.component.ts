import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DipendenteService } from '../dipendente.service';
import { RuoloService } from '../ruolo.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-dipendente',
  templateUrl: './dipendente.component.html',
  styleUrls: ['./dipendente.component.css']
})
export class DipendenteComponent implements OnInit {

  listDipendenti = [];
  listRuoli = [];

  dipendenteForm;
  
  constructor(private service: DipendenteService, private serviceRuolo: RuoloService, private router: Router, private formBuilder: FormBuilder) {}

  ngOnInit() {
    this.service.getDipendenti().subscribe(res => {
      this.listDipendenti = res;
    });
    
    this.serviceRuolo.getRuoli().subscribe(res => {
      this.listRuoli = res;
    });   

    this.dipendenteForm = this.formBuilder.group({
      cognome: '',
      nome: '',
      username: '',
      psw: '',
      selectedRuolo: ''
    });
  }

  public onSubmit() {

    if(this.dipendenteForm.value.cognome != "" && this.dipendenteForm.value.nome != "" &&
      this.dipendenteForm.value.username != "" && this.dipendenteForm.value.psw != ""){
      this.service.addDipendente(this.dipendenteForm.value.cognome, this.dipendenteForm.value.nome,
      this.dipendenteForm.value.username, this.dipendenteForm.value.psw, this.dipendenteForm.value.selectedRuolo).subscribe(res => {
        if(res == true)
          window.location.reload();
        else
          alert("Dipendente non aggiunto");
      })
    }
  }
  

  public deleteDipendente(idDipendente){
    if (confirm("Vuoi cancellare questo elemento")) {
      this.service.deleteDipendente(idDipendente).subscribe(res => {
        if(res == true){
          window.location.reload();
        }
      })
    }
  }
}
