namespace ExaminationSystem.Models
{
    public class Choice
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public Question Question { get; set; }


    }
}