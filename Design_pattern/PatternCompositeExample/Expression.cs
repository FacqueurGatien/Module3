namespace PatternCompositeExample
{
    public abstract class Expression
    {
        public abstract int Evalue();
        public string Formate()
        {
            return string.Format("{0}={1}",ToString(), Evalue());
        }
    }
}