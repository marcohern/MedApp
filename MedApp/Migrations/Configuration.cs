namespace MedApp.Migrations
{
    using MedApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MedApp.DAL.MedAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MedApp.DAL.MedAppContext context)
        {
            var tipoCitas = new List<TipoCita>
            {
                new TipoCita{ID=1, Descripcion="Medicina General"},
                new TipoCita{ID=2, Descripcion="Odontología"},
                new TipoCita{ID=3, Descripcion="Pediatría"},
                new TipoCita{ID=4, Descripcion="Neurología"}
            };
            tipoCitas.ForEach(tc => context.TipoCitas.AddOrUpdate(tcid => tcid.ID, tc));
            context.SaveChanges();

            var pacientes = new List<Paciente>
            {
                new Paciente{ ID=1, Nombre="Brad Pitt", Edad=45, Sexo = Sexo.Masculino },
                new Paciente{ ID=2, Nombre="Tom Cruise", Edad=52, Sexo = Sexo.Masculino },
                new Paciente{ ID=3, Nombre="Angelina Jolie", Edad=49, Sexo = Sexo.Femenino },
                new Paciente{ ID=4, Nombre="Blake Lively", Edad=38, Sexo = Sexo.Femenino }
            };

            pacientes.ForEach(p => context.Pacientes.AddOrUpdate(pid => pid.ID,p));
            context.SaveChanges();

            var citas = new List<Cita>
            {
                new Cita{
                    ID =1,
                    PacienteID = context.Pacientes.Single(p => p.Nombre == "Brad Pitt").ID,
                    Fecha =DateTime.Now.AddDays(1),
                    TipoCitaID = context.TipoCitas.Single(p => p.Descripcion == "Pediatría").ID
                },
                new Cita{
                    ID =1,
                    PacienteID = context.Pacientes.Single(p => p.Nombre == "Tom Cruise").ID,
                    Fecha =DateTime.Now.AddDays(1),
                    TipoCitaID = context.TipoCitas.Single(p => p.Descripcion == "Neurología").ID
                },
                new Cita{
                    ID =1,
                    PacienteID = context.Pacientes.Single(p => p.Nombre == "Angelina Jolie").ID,
                    Fecha =DateTime.Now.AddDays(1),
                    TipoCitaID = context.TipoCitas.Single(p => p.Descripcion == "Odontología").ID
                },
                new Cita{
                    ID =1,
                    PacienteID = context.Pacientes.Single(p => p.Nombre == "Blake Lively").ID,
                    Fecha =DateTime.Now.AddDays(1),
                    TipoCitaID = context.TipoCitas.Single(p => p.Descripcion == "Medicina General").ID
                },
            };

            citas.ForEach(c => context.Citas.AddOrUpdate(cid => cid.ID, c));
            context.SaveChanges();
        }
    }
}
