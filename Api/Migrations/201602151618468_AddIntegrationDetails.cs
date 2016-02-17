namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIntegrationDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IntegrationSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 20, storeType: "varchar"),
                        Value = c.String(nullable: false, maxLength: 50, storeType: "varchar"),
                        IntegrationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Integrations", t => t.IntegrationId, cascadeDelete: true)
                .Index(t => t.IntegrationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IntegrationSettings", "IntegrationId", "dbo.Integrations");
            DropIndex("dbo.IntegrationSettings", new[] { "IntegrationId" });
            DropTable("dbo.IntegrationSettings");
        }
    }
}
