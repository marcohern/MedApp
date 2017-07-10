import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { Paciente } from '../../../models/paciente';

import { PacientesService } from '../pacientes.service';

@Component({
  selector: 'app-pacientes-detail',
  templateUrl: './pacientes-detail.component.html',
  styleUrls: ['./pacientes-detail.component.css']
})
export class PacientesDetailComponent implements OnInit {

    private pacienteForm: FormGroup;
    private paciente: Paciente = null;
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
          this.ps.obtenerPaciente(id).subscribe(paciente => {
              this.paciente = paciente;
              this.pacienteForm.setValue({
                  nombre: paciente.Nombre,
                  edad: paciente.Edad,
                  sexo: paciente.Sexo
              });
          });
      } else {
          this.paciente = {
              ID: null,
              Nombre: '',
              Edad: 0,
              Sexo: 0
          }
      }
    }

  guardarPaciente(value) {

      let id = this.route.snapshot.params['id'];

      this.paciente.ID = id;
      this.paciente.Nombre = value.nombre;
      this.paciente.Edad = value.edad;
      this.paciente.Sexo = value.sexo;

      this.ps.guardarPaciente(this.paciente).subscribe(data => {
          this.regresar();
      });
    }

    regresar() {
        this.router.navigate(['/pacientes']);
    }
}
