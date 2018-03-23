using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DatentransferDLL
{
    public class DTO : IDTO
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
       
        
        public List<Kunde> GetAllCustomers()
        {
            con = new OleDbConnection();
            List<Kunde> allekunden = new List<Kunde>();
            OleDbConnectionStringBuilder stbuilder = new OleDbConnectionStringBuilder();
            stbuilder.DataSource = "H:\\Eigene Dateien\\C# 2017_2018\\GitHub\\WWM-12\\MehrschichtG2\\DatentransferDLL\\bin\\Debug\\Nwind.accdb";
            stbuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            con.ConnectionString = stbuilder.ConnectionString;
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

            }
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Customers";

            try
            {
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Kunde k = MkKundeObject(reader);
                    allekunden.Add(k);
                }
            }
            catch (Exception)
            {
                
            }
            return allekunden;

        }

        private Kunde MkKundeObject(OleDbDataReader reader)
        {
            Kunde k = new Kunde();
            k.KundenId = reader.GetString(0);
            k.KundenName = reader.GetString(1);
            k.Ansprechpartner = reader.GetString(2);
            k.Strasse = reader.GetString(4);
            k.Ort = reader.GetString(5);
            return k;
        }
    }
}
