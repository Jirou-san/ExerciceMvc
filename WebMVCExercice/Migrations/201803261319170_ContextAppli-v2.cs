namespace WebMVCExercice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextAppliv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsPresent = c.Boolean(nullable: false),
                        StudentId = c.Int(nullable: false),
                        ClassRoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoomId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        ClassRoomId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentClassRooms",
                c => new
                    {
                        Student_StudentId = c.Int(nullable: false),
                        ClassRoom_ClassRoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentId, t.ClassRoom_ClassRoomId })
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoom_ClassRoomId, cascadeDelete: true)
                .Index(t => t.Student_StudentId)
                .Index(t => t.ClassRoom_ClassRoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Attendances", "ClassRoomId", "dbo.ClassRooms");
            DropForeignKey("dbo.StudentClassRooms", "ClassRoom_ClassRoomId", "dbo.ClassRooms");
            DropForeignKey("dbo.StudentClassRooms", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.StudentClassRooms", new[] { "ClassRoom_ClassRoomId" });
            DropIndex("dbo.StudentClassRooms", new[] { "Student_StudentId" });
            DropIndex("dbo.Attendances", new[] { "ClassRoomId" });
            DropIndex("dbo.Attendances", new[] { "StudentId" });
            DropTable("dbo.StudentClassRooms");
            DropTable("dbo.Students");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.Attendances");
        }
    }
}
