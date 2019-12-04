namespace BancoDeDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaMigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        categoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.categoriaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoria");
        }
    }
}
