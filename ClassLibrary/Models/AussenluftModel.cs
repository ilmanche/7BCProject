namespace ClassLibrary
{
    public  class AussenluftModel
    {
        public int nummer { get; }
        public double aussen_temperatur { get; set; }
        public double alm_aussen_temperatur { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}