namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experiments",
                c => new
                    {
                        ExperimentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ExperimentID);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ParticipantID = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(nullable: false),
                        ExternalDataReference = c.String(),
                        Url1 = c.String(nullable: false),
                        Url2 = c.String(),
                    })
                .PrimaryKey(t => t.ParticipantID)
                .ForeignKey("dbo.Experiments", t => t.ParticipantID)
                .Index(t => t.ParticipantID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "ParticipantID", "dbo.Experiments");
            DropIndex("dbo.Participants", new[] { "ParticipantID" });
            DropTable("dbo.Participants");
            DropTable("dbo.Experiments");
        }
    }
}
