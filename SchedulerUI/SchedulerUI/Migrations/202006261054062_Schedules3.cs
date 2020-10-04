namespace SchedulerUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Schedules3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Period = c.Int(nullable: false),
                        Jitter = c.Int(nullable: false),
                        Reps = c.Int(nullable: false),
                        Experiment_ExperimentId = c.Int(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Experiments", t => t.Experiment_ExperimentId)
                .Index(t => t.Experiment_ExperimentId);
            
            AddColumn("dbo.Experiments", "ScheduleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Experiments", "ScheduleId");
            AddForeignKey("dbo.Experiments", "ScheduleId", "dbo.Schedules", "ScheduleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "Experiment_ExperimentId", "dbo.Experiments");
            DropForeignKey("dbo.Experiments", "ScheduleId", "dbo.Schedules");
            DropIndex("dbo.Schedules", new[] { "Experiment_ExperimentId" });
            DropIndex("dbo.Experiments", new[] { "ScheduleId" });
            DropColumn("dbo.Experiments", "ScheduleId");
            DropTable("dbo.Schedules");
        }
    }
}
