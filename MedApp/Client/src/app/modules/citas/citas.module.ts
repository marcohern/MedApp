import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CitasRoutes } from './citas.routes';

import { CitasListComponent } from './citas-list/citas-list.component';
import { CitasDetailComponent } from './citas-detail/citas-detail.component';

@NgModule({
  imports: [
    CommonModule,

    CitasRoutes
  ],
  declarations: [CitasListComponent, CitasDetailComponent]
})
export class CitasModule { }
