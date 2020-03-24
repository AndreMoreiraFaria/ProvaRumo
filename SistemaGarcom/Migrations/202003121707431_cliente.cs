namespace SistemaGarcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedido", "cliente", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.Pedido", "nomeCliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedido", "nomeCliente", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.Pedido", "cliente");
        }
    }
}
