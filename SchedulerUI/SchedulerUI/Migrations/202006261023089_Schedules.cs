namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedules : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Participants", new[] { "Experiment_ExperimentID" });
            AddColumn("dbo.Experiments", "ParticipantId", c => c.Int(nullable: false));
            AddColumn("dbo.Experiments", "Participant_ParticipantId", c => c.Int());
            CreateIndex("dbo.Experiments", "ParticipantId");
            CreateIndex("dbo.Experiments", "Participant_ParticipantId");
            CreateIndex("dbo.Participants", "Experiment_ExperimentId");
            AddForeignKey("dbo.Experiments", "Participant_ParticipantId", "dbo.Participants", "ParticipantId");
            AddForeignKey("dbo.Experiments", "ParticipantId", "dbo.Participants", "ParticipantId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Experiments", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Experiments", "Participant_ParticipantId", "dbo.Participants");
            DropIndex("dbo.Participants", new[] { "Experiment_ExperimentId" });
            DropIndex("dbo.Experiments", new[] { "Participant_ParticipantId" });
            DropIndex("dbo.Experiments", new[] { "ParticipantId" });
            DropColumn("dbo.Experiments", "Participant_ParticipantId");
            DropColumn("dbo.Experiments", "ParticipantId");
            CreateIndex("dbo.Participants", "Experiment_ExperimentID");
        }
    }
}
