using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelased
    {
        private string _Nimi;
        private string _Asukoht;

        public Kangelased(string Nimi, string Asukoht)
        {
            _Nimi = Nimi;
            _Asukoht = Asukoht;
        }

        public string Nimi { get => _Nimi; set => _Nimi = value; }
        public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

        public int Päästa(int Ohustatud)
        {
            return (int)Math.Round(Ohustatud * 0.95);
        }

        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + " turvalisena.";
        }
    }
}
