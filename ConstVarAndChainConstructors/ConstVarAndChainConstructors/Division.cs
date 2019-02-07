namespace ConstVarAndChainConstructors
{
    public class Division
    {
        public Division(double dividend) : this(dividend, 6)
        {
        }
        public Division(double dividend, double divisor)
        {
            Dividend = dividend;
            Divisor = divisor;
        }
        public double Dividend { get; set; }
        public double Divisor { get; set; }
    }
}
