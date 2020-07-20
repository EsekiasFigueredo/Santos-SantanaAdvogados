namespace SistemaSSAdvogados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClienteAtivo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CLienteTb", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CLienteTb", "Ativo");
        }
    }
}
