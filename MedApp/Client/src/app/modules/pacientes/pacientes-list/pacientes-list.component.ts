import { Component, OnInit } from '@angular/core';
import { PacientesService } from '../pacientes.service';
import { Paciente } from '../../../models/paciente';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pacientes-list',
  templateUrl: './pacientes-list.component.html',
  styleUrls: ['./pacientes-list.component.css']
})
export class PacientesListComponent implements OnInit {

    pacientes: Paciente[];

    constructor(
        private ps: PacientesService,
        private router:Router) { }

    ngOnInit() {
        this.ps.listaPacientes().subscribe(pacientes => {
            this.pacientes = pacientes;
        });
    }

}
