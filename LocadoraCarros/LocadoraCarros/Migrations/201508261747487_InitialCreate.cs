namespace LocadoraCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Endereco_Logradouro = c.String(),
                        Endereco_Numero = c.String(),
                        Endereco_Bairro = c.String(),
                        Endereco_Cidade = c.String(),
                        Endereco_Estado = c.String(),
                        Endereco_Cep = c.String(),
                        Endereco_Complemento = c.String(),
                        DadosCartao = c.String(),
                        CodigoAluguel = c.String(),
                        Nome = c.String(),
                        Documento = c.String(),
                        DataNascimento = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Aluguels",
                c => new
                    {
                        AluguelID = c.Int(nullable: false, identity: true),
                        CarroID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        Codigo = c.String(),
                        DataAluguel = c.String(),
                        DataDevolucao = c.String(),
                    })
                .PrimaryKey(t => t.AluguelID)
                .ForeignKey("dbo.Carroes", t => t.CarroID, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.CarroID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        CarroID = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Ano = c.String(),
                        Placa = c.String(),
                        Quilometragem = c.Int(nullable: false),
                        Cor = c.String(),
                        Chaci = c.String(),
                        QtdPortas = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CodigoAluguel = c.String(),
                        Cliente_ClienteID = c.Int(),
                    })
                .PrimaryKey(t => t.CarroID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteID)
                .Index(t => t.Cliente_ClienteID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Carroes", new[] { "Cliente_ClienteID" });
            DropIndex("dbo.Aluguels", new[] { "ClienteID" });
            DropIndex("dbo.Aluguels", new[] { "CarroID" });
            DropForeignKey("dbo.Carroes", "Cliente_ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Aluguels", "ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Aluguels", "CarroID", "dbo.Carroes");
            DropTable("dbo.Carroes");
            DropTable("dbo.Aluguels");
            DropTable("dbo.Clientes");
        }
    }
}
