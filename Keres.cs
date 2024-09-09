using System.Globalization;

namespace CLI24090901
{
    internal class Keres
    {
        public string Cim { get; set; }
        public DateTime Ido { get; set; }
        public string File { get; set; }
        public int Kod { get; set; }
        public int? Meret { get; set; }
        public bool Domain => !char.IsNumber(Cim[^1]);

        public Keres(string beolvasottSor)
        {
            string[] darabok = beolvasottSor.Split('*');
            Cim = darabok[0];
            Ido = DateTime.ParseExact(darabok[1], "dd/MMM/yyyy:HH:mm:ss", CultureInfo.InvariantCulture);
            File = darabok[2];
            string[] kodMeret = darabok[3].Split(' ');
            Kod = int.Parse(kodMeret[0]);
            Meret = kodMeret[1] == "-" ? null : int.Parse(kodMeret[1]);
        }
    }
}
