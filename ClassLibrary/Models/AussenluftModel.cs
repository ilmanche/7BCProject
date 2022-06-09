namespace ClassLibrary
{
    public  class AussenluftModel
    {
        public int nummer { get; }
        public double temperature { get; set; }
        public double alm_aussen { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}