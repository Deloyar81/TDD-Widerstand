using System;

namespace TDD_Widerstand
{
    public class Widerstand
    {
        public string WiderstandBerechnen(string ring1, string ring2, string ring3, string ring4)
        {
            string ausgabe = String.Empty;

            

            List<string> listRing1 = new List<string>();
            List<string> listRing2 = new List<string>();
            List<string> listRing3 = new List<string>();
            List<string> listRing4 = new List<string>();

            listRing1.Add("silber,");
            listRing1.Add("gold,");
            listRing1.Add("schwarz,");
            listRing1.Add("braun,1");
            listRing1.Add("rot,2");
            listRing1.Add("orange,3");
            listRing1.Add("gelb,4");
            listRing1.Add("grün,5");
            listRing1.Add("blau,6");
            listRing1.Add("violett,7");
            listRing1.Add("grau,8");
            listRing1.Add("weiß,9");

            listRing2.Add("silber,");
            listRing2.Add("gold,");
            listRing2.Add("schwarz,0");
            listRing2.Add("braun,1");
            listRing2.Add("rot,2");
            listRing2.Add("orange,3");
            listRing2.Add("gelb,4");
            listRing2.Add("grün,5");
            listRing2.Add("blau,6");
            listRing2.Add("violett,7");
            listRing2.Add("grau,8");
            listRing2.Add("weiß,9");

            listRing3.Add("silber,0.01");
            listRing3.Add("gold,0.1");
            listRing3.Add("schwarz,1");
            listRing3.Add("braun,10");
            listRing3.Add("rot,100");
            listRing3.Add("orange,1000");
            listRing3.Add("gelb,10000");
            listRing3.Add("grün,100000");
            listRing3.Add("blau,1000000");
            listRing3.Add("violett,10000000");
            listRing3.Add("grau,100000000");
            listRing3.Add("weiß,1000000000");

            listRing4.Add("silber,10%");
            listRing4.Add("gold,5%");
            listRing4.Add("schwarz,");
            listRing4.Add("braun,1%");
            listRing4.Add("rot,2%");
            listRing4.Add("orange,");
            listRing4.Add("gelb,");
            listRing4.Add("grün,0.5%");
            listRing4.Add("blau,0.25%");
            listRing4.Add("violett,0.1%");
            listRing4.Add("grau,0.05%");
            listRing4.Add("weiß,");

            string stelle1 = String.Empty;
            string stelle2 = String.Empty;
            int multiplikator = 0;
            string toleranz = String.Empty;

            try
            {
                stelle1 = listRing1.First(x => x.Contains(ring1));
                stelle1 = stelle1.Substring(stelle1.IndexOf(",") + 1);
            }
            catch (Exception)
            {
                Console.WriteLine($"Falsche Eingabe: {ring1}");
            }

            try
            {
                stelle2 = listRing2.First(x => x.Contains(ring2));
                stelle2 = stelle2.Substring(stelle2.IndexOf(",") + 1);
            }
            catch (Exception)
            {
                Console.WriteLine($"Falsche Eingabe: {ring2}");
            }

            try
            {
                string puffer = listRing3.First(x => x.Contains(ring3));
                multiplikator = Convert.ToInt32(puffer.Substring(puffer.IndexOf(",") + 1));
            }
            catch (Exception)
            {
                Console.WriteLine($"Falsche Eingabe: {ring3}");
            }

            try
            {
                toleranz = listRing4.First(x => x.Contains(ring4));
                toleranz = toleranz.Substring(toleranz.IndexOf(",") + 1);
            }
            catch (Exception)
            {
                Console.WriteLine($"Falsche Eingabe: {ring4}");
            }   

            string wert = stelle1 + stelle2;
            
            int ohmscherWert = Convert.ToInt32(wert) * multiplikator;

            if(ohmscherWert > 999999)
            {
                ausgabe = $"{ohmscherWert / 1000000} Megaohm";
            }
            else if(ohmscherWert > 999)
            {
                ausgabe = $"{ohmscherWert / 1000} Kiloohm";
            }
            else
            {
                ausgabe = $"{ohmscherWert} Ohm";
            }

            ausgabe += $" ({toleranz})";

            return ausgabe;
        }
    }
}