namespace ExaminationSystem.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }

    }
}
