import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';

import { TipoCita } from '../../../models/tipo-cita'
import { Cita } from '../../../models/cita'

import { CitasService } from '../citas.service'

@Component({
  selector: 'app-citas-detail',
  templateUrl: './citas-detail.component.html',
  styleUrls: ['./citas-detail.component.css']
})
export class CitasDetailComponent implements OnInit {

    private citaForm: FormGroup;
    private tiposCita: TipoCita[] = [];

    constructor(
        private fb: FormBuilder,
        private router: Router,
        private route: ActivatedRoute,
        private cs: CitasService
    ) { }

    ngOnInit() {
        this.citaForm = this.fb.group({
            tipoCita: [''],
            fecha: [''],
            paciente: ['']
        });
    }

}
