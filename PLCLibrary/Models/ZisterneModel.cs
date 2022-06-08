namespace PLCLibrary
{
    public  class ZisterneModel
    {
        public int nummer { get; }
        public double unten { get; set; }
        public double oben { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}