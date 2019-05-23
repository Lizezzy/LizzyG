using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Superkangelane:Kangelane
    {
        private double _Osavus;

        public Superkangelane(string Name, string Location) : base (Name, Location)
        {
            _Osavus = SingleRandom.Instance.Next(1, 51)/10.0;
        }

        public override int Save(int Dangered)
        {
            return (int)Math.Round((95 + _Osavus) / 100 * Dangered, 0);
        }

        public override string ToString()
        {
            return base.ToString() + " to on selles " + _Osavus + " protsenti parem kui lihtsalt kangelased";
        }
    }
}
