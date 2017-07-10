import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

import { PacientesService } from '../pacientes.service';

@Component({
  selector: 'app-pacientes-detail',
  templateUrl: './pacientes-detail.component.html',
  styleUrls: ['./pacientes-detail.component.css']
})
export class PacientesDetailComponent implements OnInit {

    private pacienteForm: FormGroup;
    constructor(
        private fb: FormBuilder,
        private router: Router,
        private route: ActivatedRoute,
        private ps: PacientesService) { }

  ngOnInit() {
      this.pacienteForm = this.fb.group({
          nombre: ['', Validators.required],
          edad: ['', Validators.required],
          sexo: ['', Validators.required]
      });

      let id = this.route.snapshot.params['id'];
      if (id) {

      }
  }

  regresar() {
      this.router.navigate(['/pacientes']);
  }

}
