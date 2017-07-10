import { Injectable } from '@angular/core';
import { Http, Request, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Cita } from '../../models/cita';

@Injectable()
export class CitasService {

    constructor(private http:Http) { }

    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Server error');
    }

    private do(data) {

    }

    listaCitas(): Observable<Cita[]> {
        return this.http.get('/citas')
            .map((r: Response) => <Cita[]>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    obtenerCita(id: number): Observable<Cita[]> {
        return this.http.get('/citas/' + id)
            .map((r: Response) => <Cita>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    crearCita(cita: Cita): Observable<any> {
        return this.http.post('/citas', cita)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    actualizarCita(cita: Cita): Observable<any> {
        return this.http.put('/citas/' + cita.ID, cita)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    eliminarCita(id:number): Observable<any> {
        return this.http.delete('/citas/' + id)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    guardarCita(cita: Cita): Observable<any> {
        if (cita.ID) {
            return this.actualizarCita(cita);
        } else {
            return this.crearCita(cita);
        }
    }

}
