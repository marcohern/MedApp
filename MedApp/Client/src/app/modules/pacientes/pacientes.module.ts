import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';

import { PacientesRoutes } from './pacientes.routes';

import { PacientesListComponent } from './pacientes-list/pacientes-list.component';
import { PacientesDetailComponent } from './pacientes-detail/pacientes-detail.component';

import { PacientesService } from './pacientes.service';

@NgModule({
  imports: [
    CommonModule,
    PacientesRoutes
    ],
    providers:[ PacientesService ],
  declarations: [PacientesListComponent, PacientesDetailComponent]
})
export class PacientesModule { }
