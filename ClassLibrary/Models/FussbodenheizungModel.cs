namespace ClassLibrary
{
    public class FusbodenheizungModel
    {
        public int nummer { get; }
        public double vl { get; set; }
        public double rl { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}