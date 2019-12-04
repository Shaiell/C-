namespace BancoDeDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novoup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Categoria_categoriaID", c => c.Int());
            CreateIndex("dbo.Produtos", "Categoria_categoriaID");
            AddForeignKey("dbo.Produtos", "Categoria_categoriaID", "dbo.Categoria", "categoriaID");
            DropColumn("dbo.Produtos", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtos", "Categoria", c => c.String());
            DropForeignKey("dbo.Produtos", "Categoria_categoriaID", "dbo.Categoria");
            DropIndex("dbo.Produtos", new[] { "Categoria_categoriaID" });
            DropColumn("dbo.Produtos", "Categoria_categoriaID");
        }
    }
}
