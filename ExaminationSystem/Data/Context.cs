

using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ExaminationSystem.Data
{
    public class Context : DbContext
    {
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=True;Trusted_Connection=True;");
            optionsBuilder
                .UseSqlServer("Data Source=.;Initial Catalog=ExaminationSystemDB;" +
                "Integrated Security = True; Trusted_Connection = True; Encrypt = False")
                .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }
}
