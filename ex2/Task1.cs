namespace ex2
{
    public enum Preference
    {
        a, b, c, d
    }
    public class Task1
    {
        public string Title { get; set; }
        public string Desc { get; set; }

        public DateTime Target_date { get; set; }

        public Preference preference { get; set; }
        
    }
}
