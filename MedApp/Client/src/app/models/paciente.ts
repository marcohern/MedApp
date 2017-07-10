import { Entidad } from './entidad';

export interface Paciente extends Entidad {
    Nombre: string;
    Edad: number;
    Sexo: number;
    SexoStr?: string;
}
