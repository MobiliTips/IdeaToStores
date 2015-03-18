namespace Motip.Web.AzureMobileService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlaceScoring : DbMigration
    {
        public override void Up()
        {
            AddColumn("motip_ams.Places", "Score", c => c.Double());
            AddColumn("motip_ams.Users", "Latitude", c => c.Double(nullable: false));
            AddColumn("motip_ams.Users", "Longitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("motip_ams.Users", "Longitude");
            DropColumn("motip_ams.Users", "Latitude");
            DropColumn("motip_ams.Places", "Score");
        }
    }
}
