using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApplicationÜbung3
{
    class Person : INotifyPropertyChanged
    {
        private String vorname;
        private String nachname;
        private int alter;
        private String haustier;

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
        public Person(String vorname, String nachname, int alter, String haustier)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Alter = alter;
            this.Haustier = haustier;
        }
        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public int Alter
        {
            get
            {
                return alter;
            }

             private set
            {
                alter = value;
                onPropertyChanged(new PropertyChangedEventArgs("Alter"));
            }
        }

        public string Haustier
        {
            get
            {
                return haustier;
            }

            set
            {
                haustier = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.Vorname, this.Nachname);
        }
        public int Geburtstag()
        {
            this.Alter += 1;
            return Alter;
        }
       
    }
}
