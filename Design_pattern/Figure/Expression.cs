namespace Figure
{
    public abstract class Expression
    {
        public abstract string ToStringBis();
        public string Formate()
        {
            return ToStringBis();
        }
    }
}