using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string _Name;
        private string _Location;

        public Kangelane(string Name, string Location)
        {
            this._Name = Name;
            this._Location = Location;
        }

        public string Name { get => Name; set => Name = value; }
        public string Location { get => Location; set => Location = value; }

        public virtual int Save(int Dangered)
        {
            return (int)Math.Round(Dangered * 0.95, 0);
        }

        public override string ToString()
        {
            return Name + " Defends " + Location;
        }


    }
}
