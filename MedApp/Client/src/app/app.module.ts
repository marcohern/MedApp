import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { MenuModule } from './modules/menu/menu.module';
import { PacientesModule } from './modules/pacientes/pacientes.module';
import { TipoCitasModule } from './modules/tipo-citas/tipo-citas.module';
import { CitasModule } from './modules/citas/citas.module';

import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';

import { AppRoutes } from './app.routes';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent
  ],
  imports: [
      BrowserModule,
      MenuModule,

      PacientesModule,
      TipoCitasModule,
      CitasModule,

      AppRoutes
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
