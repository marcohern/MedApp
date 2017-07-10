import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MenuLinksComponent } from './menu-links/menu-links.component';

@NgModule({
  imports: [
      CommonModule,
      RouterModule
  ],
  declarations: [MenuLinksComponent],
  exports: [MenuLinksComponent]
})
export class MenuModule { }
