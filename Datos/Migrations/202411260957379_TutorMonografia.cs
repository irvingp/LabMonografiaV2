namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TutorMonografia : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Monografias", "TutorId", "dbo.Profesors");
            DropIndex("dbo.Monografias", new[] { "TutorId" });
            CreateTable(
                "dbo.TutorMonografias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TutorId = c.Int(nullable: false),
                        MonografiaId = c.Int(nullable: false),
                        Monografia_IdMonografia = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profesors", t => t.TutorId, cascadeDelete: true)
                .ForeignKey("dbo.Monografias", t => t.Monografia_IdMonografia)
                .Index(t => t.TutorId)
                .Index(t => t.Monografia_IdMonografia);
            
            DropColumn("dbo.Monografias", "TutorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Monografias", "TutorId", c => c.Int());
            DropForeignKey("dbo.TutorMonografias", "Monografia_IdMonografia", "dbo.Monografias");
            DropForeignKey("dbo.TutorMonografias", "TutorId", "dbo.Profesors");
            DropIndex("dbo.TutorMonografias", new[] { "Monografia_IdMonografia" });
            DropIndex("dbo.TutorMonografias", new[] { "TutorId" });
            DropTable("dbo.TutorMonografias");
            CreateIndex("dbo.Monografias", "TutorId");
            AddForeignKey("dbo.Monografias", "TutorId", "dbo.Profesors", "Id");
        }
    }
}
