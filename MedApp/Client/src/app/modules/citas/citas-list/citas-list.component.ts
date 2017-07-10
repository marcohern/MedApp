import { Component, OnInit } from '@angular/core';
import { CitasService } from '../citas.service';
import { Cita } from '../../../models/cita';

@Component({
  selector: 'app-citas-list',
  templateUrl: './citas-list.component.html',
  styleUrls: ['./citas-list.component.css']
})
export class CitasListComponent implements OnInit {

    private citas: Cita[];
  constructor(private cs:CitasService) { }

  ngOnInit() {
      this.cs.listaCitas().subscribe(citas => {
          this.citas = citas;
      });
  }

}
