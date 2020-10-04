namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Participants", "ParticipantID", "dbo.Experiments");
            DropIndex("dbo.Participants", new[] { "ParticipantID" });
            DropPrimaryKey("dbo.Participants");
            AddColumn("dbo.Participants", "Experiment_ExperimentID", c => c.Int());
            AlterColumn("dbo.Participants", "ParticipantID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Participants", "ParticipantID");
            CreateIndex("dbo.Participants", "Experiment_ExperimentID");
            AddForeignKey("dbo.Participants", "Experiment_ExperimentID", "dbo.Experiments", "ExperimentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "Experiment_ExperimentID", "dbo.Experiments");
            DropIndex("dbo.Participants", new[] { "Experiment_ExperimentID" });
            DropPrimaryKey("dbo.Participants");
            AlterColumn("dbo.Participants", "ParticipantID", c => c.Int(nullable: false));
            DropColumn("dbo.Participants", "Experiment_ExperimentID");
            AddPrimaryKey("dbo.Participants", "ParticipantID");
            CreateIndex("dbo.Participants", "ParticipantID");
            AddForeignKey("dbo.Participants", "ParticipantID", "dbo.Experiments", "ExperimentID");
        }
    }
}
