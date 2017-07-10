import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DatepickerModule } from 'ngx-bootstrap/datepicker';
import { HttpModule } from '@angular/http';
import { CitasRoutes } from './citas.routes';

import { CitasListComponent } from './citas-list/citas-list.component';
import { CitasDetailComponent } from './citas-detail/citas-detail.component';

import { CitasService } from './citas.service';

@NgModule({
  imports: [
    CommonModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    DatepickerModule.forRoot(),
    CitasRoutes
  ],
  declarations: [CitasListComponent, CitasDetailComponent],
  providers:[CitasService]
})
export class CitasModule { }
