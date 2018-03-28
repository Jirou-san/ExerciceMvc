namespace WebMVCExercice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextAppliv3 : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.StudentViewModels");
        }
    }
}
