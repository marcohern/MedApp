import { Component, OnInit } from '@angular/core';
import { PacientesService } from '../pacientes.service';

@Component({
  selector: 'app-pacientes-list',
  templateUrl: './pacientes-list.component.html',
  styleUrls: ['./pacientes-list.component.css']
})
export class PacientesListComponent implements OnInit {

    constructor(private ps: PacientesService) { }

    ngOnInit() {
        this.ps.getPacientes().subscribe(pacientes => {
            console.log(pacientes);
        });
    }

}
