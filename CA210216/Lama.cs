using System;

namespace CA210216
{
    public class Lama
    {
        public enum Izek
        {
            Edes,
            Sos
        }

        public readonly string Nev;
        public readonly ushort Eletkor;
        public readonly Izek KedvencIz;

        public Lama(string nev, ushort szulEv, Izek kedvencIz)
        {
            Nev = nev;
            Eletkor = (ushort) (DateTime.Now.Year - szulEv);
            KedvencIz = kedvencIz;
        }
    }
}