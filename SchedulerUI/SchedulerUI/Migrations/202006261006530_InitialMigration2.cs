namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Participants");
            AlterColumn("dbo.Participants", "ParticipantID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Participants", "ParticipantID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Participants");
            AlterColumn("dbo.Participants", "ParticipantID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Participants", "ParticipantID");
        }
    }
}
