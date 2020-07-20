namespace SistemaSSAdvogados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLienteTb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        Documento = c.String(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Telefone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CLienteTb");
        }
    }
}
