namespace ITGnanConsole.IQ.Models
{
    public class SpritObject
    {
        public string name { get; set; }
        public string published { get; set; }
        public List<AccountBenefit> spiritAccountBenefit { get; set; }
    }

    public class AccountBenefit
    {
        public string name { get; set; }
        public Title title { get; set; }
        public List<Benefit> benefit { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Benefit
    {
        public string name { get; set; }
        public Text text { get; set; }
        public Icon icon { get; set; }
        public SortOrder sortOrder { get; set; }
    }

    public class Text
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Icon
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class SortOrder
    {
        public string type { get; set; }
        public string text { get; set; }
    }

}
