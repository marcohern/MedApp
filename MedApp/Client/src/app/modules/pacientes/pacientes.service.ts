import { Injectable } from '@angular/core';
import { Http, Request, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import { Paciente } from '../../models/paciente';

@Injectable()
export class PacientesService {

    constructor(private http: Http) { }

    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Server error');
    }

    private do(data) {

    }

    public listaPacientes():Observable<Paciente[]> {
        return this.http
            .get('/api/pacientes')
            .map((r: Response) => <Paciente[]>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    public obtenerPaciente(id:number): Observable<Paciente> {
        return this.http
            .get('/api/pacientes/'+id)
            .map((r: Response) => <Paciente>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    public crearPaciente(paciente: Paciente): Observable<any> {
        return this.http
            .post('/api/pacientes', paciente)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    public actualizarPaciente(paciente: Paciente): Observable<any> {
        return this.http
            .put('/api/pacientes/' + paciente.ID, paciente)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    public eliminarPaciente(id:number): Observable<any> {
        return this.http
            .delete('/api/pacientes/' + id)
            .catch(this.handleError)
            .do(data => this.do(data));
    }

    public guardarPaciente(paciente: Paciente): Observable<any> {
        if (paciente.ID) {
            return this.actualizarPaciente(paciente);
        } else {
            return this.crearPaciente(paciente);
        }
    }
}
