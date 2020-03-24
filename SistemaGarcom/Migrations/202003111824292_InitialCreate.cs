namespace SistemaGarcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        prato = c.String(maxLength: 8000, unicode: false),
                        bebida = c.String(maxLength: 8000, unicode: false),
                        quantidade = c.Int(nullable: false),
                        mesa = c.Int(nullable: false),
                        nomeCliente = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pedido");
        }
    }
}
