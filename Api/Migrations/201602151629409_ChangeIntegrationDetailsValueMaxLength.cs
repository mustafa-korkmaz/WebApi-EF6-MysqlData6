namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIntegrationDetailsValueMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IntegrationSettings", "Value", c => c.String(nullable: false, maxLength: 100, storeType: "varchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IntegrationSettings", "Value", c => c.String(nullable: false, maxLength: 50, storeType: "varchar"));
        }
    }
}
