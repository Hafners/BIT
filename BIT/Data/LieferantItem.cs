namespace BIT.Data
{
    public class LieferantItem
    {
        public int Id { get; set; }

        public string Name { get; set; } 

        public string Standort { get; set; }

        public string Lieferzeit { get; set; }

        public int LieferantenId { get; set; }

        public double Lieferkosten { get; set; }

        public bool Versand { get; set; } = false;
        
        public bool Verfügbarkeit { get; set; } = true; 
    }
}
