namespace Domain.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Iin { get; set; }
        public int Score { get; set; }
        public Profile Profile1 { get; set; }
        public Profile Profile2 { get; set; }
        public College College { get; set; }
    }
}