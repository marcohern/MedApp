import { Entidad } from './entidad';
import { Paciente } from './paciente';
import { TipoCita } from './tipo-cita';

export interface Cita extends Entidad {
    Fecha:Date;
    PacienteID: number;
    TipoCitaID: number;
    Paciente?: Paciente;
    TipoCita?: TipoCita;
}
