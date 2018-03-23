using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatentransferDLL
{
    public class DTOtxt : IDTO
    {
        public List<Kunde> GetAllCustomers()
        {
            List<Kunde> liKunde = new List<Kunde>();
            try
            {
                String[] lines = File.ReadAllLines(@"H:\Eigene Dateien\C# 2017_2018\GitHub\WWM-12\MehrschichtG2\DatentransferDLL\kunden.txt");

                foreach(String s in lines)
                {
                    liKunde.Add(MkKundenObject(s));
                }
            }
            catch(Exception )
            {
                liKunde = null;
            }
            return liKunde;
        }

        private Kunde MkKundenObject(string s)
        {
            Kunde k = new Kunde();
            String[] temp = s.Split(';');
            k.KundenId = temp[0];
            k.KundenName = temp[1];
            k.Ansprechpartner = temp[2];
            k.Strasse = temp[3];
            k.Ort = temp[4];
            return k;
                 
        }
    }
}
