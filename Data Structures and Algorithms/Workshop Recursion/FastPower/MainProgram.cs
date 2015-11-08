namespace FastPower
{
    public class Program
    {
        private const int MOD = 1000000007;

        public static long PowMod(long a, long p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p % 2 == 1)
            {
                return (PowMod(a, p - 1) * a) % MOD;
            }

            a = PowMod(a, p / 2);
            return (a * a) % MOD;
        }

        public static void Main(string[] args)
        {
            PowMod(10, 10);
        }
    }
}
