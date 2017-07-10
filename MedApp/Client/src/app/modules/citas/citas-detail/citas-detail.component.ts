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
    private tiposCita: TipoCita[] = [];

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
            fecha: [''],
            paciente: ['']
        });
    }

}
