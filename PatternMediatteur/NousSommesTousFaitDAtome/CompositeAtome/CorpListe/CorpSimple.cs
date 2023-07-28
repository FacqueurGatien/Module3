namespace CompositeAtome.CorpListe
{
    public abstract class CorpSimple
    {
        protected string nom;

        public CorpSimple(string _nom)
        {
            nom = _nom;
        }

        public virtual string ToStringBis()
        {
            return $"Atome:{GetType().Name}\n";
        }

    }
}