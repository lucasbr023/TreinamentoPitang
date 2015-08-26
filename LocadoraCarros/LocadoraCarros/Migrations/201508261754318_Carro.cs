namespace LocadoraCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carroes", "Chassi", c => c.String());
            DropColumn("dbo.Carroes", "Chaci");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carroes", "Chaci", c => c.String());
            DropColumn("dbo.Carroes", "Chassi");
        }
    }
}
