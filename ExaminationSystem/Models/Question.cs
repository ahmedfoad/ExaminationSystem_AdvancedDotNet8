namespace ExaminationSystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public HashSet<Choice> choices { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; }
    }
}
