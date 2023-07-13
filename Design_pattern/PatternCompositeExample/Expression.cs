namespace PatternCompositeExample
{
    public abstract class Expression
    {
        public abstract double Evalue();
        public string Formate()
        {
            return string.Format("{0}={1}",ToString(), Evalue());
        }
    }
}