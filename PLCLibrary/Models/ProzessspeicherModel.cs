namespace PLCLibrary
{
    public  class ProzessspeicherModel
    {
        public int nummer { get; }
        public double oben { get; set; }
        public double unten { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}