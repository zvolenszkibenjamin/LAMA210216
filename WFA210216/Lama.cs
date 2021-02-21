using System;

namespace WFA210216
{
    public class Lama
    {
        public enum Izek
        {
            Edes,
            Sos
        }

        public readonly string Nev;
        public readonly ushort SzulEv;
        public readonly Izek KedvencIz;

        public Lama(string nev, ushort szulEv, Izek kedvencIz)
        {
            Nev = nev;
            SzulEv = szulEv;
            KedvencIz = kedvencIz;
        }
    }
}