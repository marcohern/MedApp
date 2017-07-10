namespace MedApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cita",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PacienteID = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        TipoCitaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Paciente", t => t.PacienteID, cascadeDelete: true)
                .ForeignKey("dbo.TipoCita", t => t.TipoCitaID, cascadeDelete: true)
                .Index(t => t.PacienteID)
                .Index(t => t.TipoCitaID);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Edad = c.Int(nullable: false),
                        Sexo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoCita",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cita", "TipoCitaID", "dbo.TipoCita");
            DropForeignKey("dbo.Cita", "PacienteID", "dbo.Paciente");
            DropIndex("dbo.Cita", new[] { "TipoCitaID" });
            DropIndex("dbo.Cita", new[] { "PacienteID" });
            DropTable("dbo.TipoCita");
            DropTable("dbo.Paciente");
            DropTable("dbo.Cita");
        }
    }
}
