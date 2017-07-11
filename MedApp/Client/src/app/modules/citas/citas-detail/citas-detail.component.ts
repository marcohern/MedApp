import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

import * as moment from 'moment';

import { TipoCita } from '../../../models/tipo-cita'
import { Cita } from '../../../models/cita'

import { CitasService } from '../citas.service'


const DAY = 1000 * 60 * 60 * 24;

@Component({
  selector: 'app-citas-detail',
  templateUrl: './citas-detail.component.html',
  styleUrls: ['./citas-detail.component.css']
})
export class CitasDetailComponent implements OnInit {

    private minDate: Date;
    private dateDisabled: boolean = false;
    private citaForm: FormGroup;
    private cita: Cita;
    private tiposCita: TipoCita[] = [];
    public dt: Date = new Date();

    constructor(
        private fb: FormBuilder,
        private router: Router,
        private route: ActivatedRoute,
        private cs: CitasService
    ) { }

    ngOnInit() {
        let now = new Date();
        let tomorow = new Date(now.valueOf() + DAY);
        this.minDate = tomorow;

        this.citaForm = this.fb.group({
            tipoCita: [''],
            fecha   : [''],
            paciente: [''],
            dt: ['']
        });

        this.cs.obtenerTipoCitaOpciones().subscribe(tiposCita => {
            this.tiposCita = tiposCita;
        });

        let id = this.route.snapshot.params['id'];
        if (id) {
            this.cs.obtenerCita(id).subscribe(cita => {
                this.cita = cita;
                this.citaForm.setValue({
                    tipoCita: cita.TipoCitaID,
                    fecha: cita.Fecha,
                    paciente: cita.PacienteID
                });
            });
        } else {
            this.cita = {
                ID: null,
                PacienteID: 0,
                TipoCitaID: 0,
                Fecha: new Date(0)
            };
        }
    }

    fechaCambio() {
        this.citaForm.setValue({ fecha: this.citaForm.value.dt });
    }

    guardarCita(value) {
        let id = this.route.snapshot.params['id'];
    }

    regresar() {
        this.router.navigate(['/citas']);
    }
}
