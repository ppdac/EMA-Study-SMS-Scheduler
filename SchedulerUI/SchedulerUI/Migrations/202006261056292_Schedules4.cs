namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedules4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Experiments", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "Experiment_ExperimentId", "dbo.Experiments");
            DropIndex("dbo.Experiments", new[] { "ScheduleId" });
            DropIndex("dbo.Schedules", new[] { "Experiment_ExperimentId" });
            DropColumn("dbo.Experiments", "ScheduleId");
            DropColumn("dbo.Schedules", "Experiment_ExperimentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "Experiment_ExperimentId", c => c.Int());
            AddColumn("dbo.Experiments", "ScheduleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Schedules", "Experiment_ExperimentId");
            CreateIndex("dbo.Experiments", "ScheduleId");
            AddForeignKey("dbo.Schedules", "Experiment_ExperimentId", "dbo.Experiments", "ExperimentId");
            AddForeignKey("dbo.Experiments", "ScheduleId", "dbo.Schedules", "ScheduleId", cascadeDelete: true);
        }
    }
}
