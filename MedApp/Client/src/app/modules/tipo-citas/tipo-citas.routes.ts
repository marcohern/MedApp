
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TipoCitasListComponent } from './tipo-citas-list/tipo-citas-list.component';
import { TipoCitasDetailComponent } from './tipo-citas-detail/tipo-citas-detail.component';

const routes: Routes = [
    { path: 'tipo-citas', component: TipoCitasListComponent },
    { path: 'tipo-cita/:id', component: TipoCitasDetailComponent },
    { path: 'tipo-cita/crear', component: TipoCitasDetailComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
    providers: []
})
export class TipoCitasRoutes {

}