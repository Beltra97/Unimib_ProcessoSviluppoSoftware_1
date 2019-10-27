import { Component, OnInit } from '@angular/core';
import { ConvenzioneService } from '../convenzione.service';
import { Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-convenzione',
  templateUrl: './convenzione.component.html',
  styleUrls: ['./convenzione.component.css']
})
export class ConvenzioneComponent implements OnInit {

  listConvenzioni;
  convenzioneForm;
  
  constructor(private service: ConvenzioneService, private router: Router, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.service.getConvenzioni().subscribe(res => {
      this.listConvenzioni = res;
    })

    this.convenzioneForm = this.formBuilder.group({
      titolo: '',
      descrizione: ''
    });
  }

  onSubmit() {

    if(this.convenzioneForm.value.titolo != "" && this.convenzioneForm.value.descrizione != ""){
      this.service.addConvenzione(this.convenzioneForm.value.titolo, this.convenzioneForm.value.descrizione).subscribe(res => {
        if(res == true)
          window.location.reload();
        else
          alert("Convenzione non aggiunta");
      })
    }
  }


  public deleteConvenzione(idConvenzione){
    if (confirm("Vuoi cancellare questo elemento")) {
      this.service.deleteConvenzione(idConvenzione).subscribe(res => {
        if(res == true){
          window.location.reload();
        }
      })
    }
  }

}
