namespace WebMVCExercice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextAppliv4 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.StudentViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
