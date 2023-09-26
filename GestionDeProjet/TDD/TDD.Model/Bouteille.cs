namespace TDD.Model
{
    public class Bouteille
    {
        public bool Open { get; private set; }
        public int CapaciteMl { get; private set; }
        public int ContenueMl { get; private set; } 

        public Bouteille(int _capaciteMl, int _contenueMl)
        {
            Open = false;
            CapaciteMl = _capaciteMl;
            ContenueMl = _contenueMl;
        }
        public Bouteille(int _capaciteMl) : this(_capaciteMl,_capaciteMl)
        {

        }
        public Bouteille() : this(1000, 1000)
        {

        }

    }
}