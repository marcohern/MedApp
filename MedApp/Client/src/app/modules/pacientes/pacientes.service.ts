import { Injectable } from '@angular/core';
import { Http, Request, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { Paciente } from '../../models/paciente';

@Injectable()
export class PacientesService {

    constructor(private http: Http) { }

    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Server error');
    }

    private do(data) {

    }

    public getPacientes():Observable<Paciente[]> {
        return this.http
            .get('/api/pacientes')
            .map((r: Response) => <Paciente[]>r.json())
            .catch(this.handleError)
            .do(data => this.do(data));
    }
}
