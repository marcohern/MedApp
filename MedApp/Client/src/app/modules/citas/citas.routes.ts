
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CitasListComponent } from './citas-list/citas-list.component';
import { CitasDetailComponent } from './citas-detail/citas-detail.component';

const routes: Routes = [
    { path: 'citas', component: CitasListComponent },
    { path: 'cita/:id', component: CitasDetailComponent },
    { path: 'cita/crear', component: CitasDetailComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
    providers: []
})
export class CitasRoutes {

}