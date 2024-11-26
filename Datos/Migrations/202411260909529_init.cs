namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carnet = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        AnoNacimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstudiantesMonografias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstudianteId = c.Int(nullable: false),
                        MonografiaId = c.Int(nullable: false),
                        Monografia_IdMonografia = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estudiantes", t => t.EstudianteId, cascadeDelete: true)
                .ForeignKey("dbo.Monografias", t => t.Monografia_IdMonografia)
                .Index(t => t.EstudianteId)
                .Index(t => t.Monografia_IdMonografia);
            
            CreateTable(
                "dbo.Monografias",
                c => new
                    {
                        IdMonografia = c.Int(nullable: false, identity: true),
                        TituloMonografia = c.String(),
                        FechaDeDefensa = c.DateTime(nullable: false),
                        NotaDeDefensa = c.Double(nullable: false),
                        TiempoOtorgado = c.Double(nullable: false),
                        TiempoDeDefensa = c.Double(nullable: false),
                        TiempoDeQyA = c.Double(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        TutorId = c.Int(),
                    })
                .PrimaryKey(t => t.IdMonografia)
                .ForeignKey("dbo.Profesors", t => t.TutorId)
                .Index(t => t.TutorId);
            
            CreateTable(
                "dbo.ProfesorMonografias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfesorId = c.Int(nullable: false),
                        MonografiaId = c.Int(nullable: false),
                        Monografia_IdMonografia = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Monografias", t => t.Monografia_IdMonografia)
                .ForeignKey("dbo.Profesors", t => t.ProfesorId, cascadeDelete: true)
                .Index(t => t.ProfesorId)
                .Index(t => t.Monografia_IdMonografia);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        AñoDeNacimiento = c.DateTime(nullable: false),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monografias", "TutorId", "dbo.Profesors");
            DropForeignKey("dbo.ProfesorMonografias", "ProfesorId", "dbo.Profesors");
            DropForeignKey("dbo.ProfesorMonografias", "Monografia_IdMonografia", "dbo.Monografias");
            DropForeignKey("dbo.EstudiantesMonografias", "Monografia_IdMonografia", "dbo.Monografias");
            DropForeignKey("dbo.EstudiantesMonografias", "EstudianteId", "dbo.Estudiantes");
            DropIndex("dbo.ProfesorMonografias", new[] { "Monografia_IdMonografia" });
            DropIndex("dbo.ProfesorMonografias", new[] { "ProfesorId" });
            DropIndex("dbo.Monografias", new[] { "TutorId" });
            DropIndex("dbo.EstudiantesMonografias", new[] { "Monografia_IdMonografia" });
            DropIndex("dbo.EstudiantesMonografias", new[] { "EstudianteId" });
            DropTable("dbo.Profesors");
            DropTable("dbo.ProfesorMonografias");
            DropTable("dbo.Monografias");
            DropTable("dbo.EstudiantesMonografias");
            DropTable("dbo.Estudiantes");
        }
    }
}
