
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PacientesListComponent } from './pacientes-list/pacientes-list.component';
import { PacientesDetailComponent } from './pacientes-detail/pacientes-detail.component';

const routes: Routes = [
    { path: 'pacientes', component: PacientesListComponent },
    { path: 'paciente/:id', component: PacientesDetailComponent },
    { path: 'paciente/crear', component: PacientesDetailComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
    providers: []
})
export class PacientesRoutes {

}