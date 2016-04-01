namespace SimpleCapaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Capa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Capas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                        UserId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false),
                        ContentType = c.String(nullable: false),
                        fileBytes = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tasks", "CapaId", c => c.Int(nullable: false));
            AddColumn("dbo.Tasks", "Step", c => c.Int(nullable: false));
            CreateIndex("dbo.Tasks", "CapaId");
            AddForeignKey("dbo.Tasks", "CapaId", "dbo.Capas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "CapaId", "dbo.Capas");
            DropForeignKey("dbo.Capas", "UserId", "dbo.Users");
            DropIndex("dbo.Capas", new[] { "UserId" });
            DropIndex("dbo.Tasks", new[] { "CapaId" });
            DropColumn("dbo.Tasks", "Step");
            DropColumn("dbo.Tasks", "CapaId");
            DropTable("dbo.Files");
            DropTable("dbo.Capas");
        }
    }
}
