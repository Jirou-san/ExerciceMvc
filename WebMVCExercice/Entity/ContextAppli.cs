using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebMVCExercice.Entity
{
    public class ContextAppli : DbContext
    {

        public ContextAppli() : base("BDDMVCTest")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ContextAppli>()); //Pour la création de la base
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<FilRougeDBContext, Migrations.Configuration>()); //Pour la migration
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}