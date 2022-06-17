namespace ClassLibrary
{
    public class WaermepumpeModel
    {
        public int nummer { get; }
        public double innen { get; set; }
        public double sole_vl { get; set; }
        public double sole_rl { get; set; }
        public string timestamp { get; set; }
        public int plcNummer { get; }
    }
}