using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanKomposisi
{
    public class Mobil
    {
        public string Merk { get; set; }
        private Mesin mesin;

        public Mobil()
        {
            mesin = new Mesin();
            mesin.Type = "INLINE";
        }
        public Mesin GetInfoMesin()
        {
            return mesin;
        }
    }
}
