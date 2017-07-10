import { Injectable } from '@angular/core';
import { Http, Request, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Cita } from '../../models/cita';
import { TipoCita } from '../../models/tipo-cita';

@Injectable()
export class CitasService {

    constructor(private http:Http) { }

    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Server error');
    }

    private do(data) {

    }

    listaCitas(): Observable<Cita[]> {
        return this.http.get('/api/citas')
            .map((r: Response) => <Cita[]>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    obtenerCita(id: number): Observable<Cita[]> {
        return this.http.get('/api/citas/' + id)
            .map((r: Response) => <Cita>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    crearCita(cita: Cita): Observable<any> {
        return this.http.post('/api/citas', cita)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    actualizarCita(cita: Cita): Observable<any> {
        return this.http.put('/api/citas/' + cita.ID, cita)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    eliminarCita(id:number): Observable<any> {
        return this.http.delete('/api/citas/' + id)
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

    obtenerTipoCitaOpciones(): Observable<TipoCita[]> {
        return this.http.get('/api/tipo-citas')
            .map((r: Response) => <TipoCita[]>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

}
