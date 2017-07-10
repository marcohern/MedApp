import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TipoCitasRoutes } from './tipo-citas.routes';

import { TipoCitasListComponent } from './tipo-citas-list/tipo-citas-list.component';
import { TipoCitasDetailComponent } from './tipo-citas-detail/tipo-citas-detail.component';


@NgModule({
  imports: [
    CommonModule,
    TipoCitasRoutes
  ],
  declarations: [TipoCitasListComponent, TipoCitasDetailComponent]
})
export class TipoCitasModule { }
