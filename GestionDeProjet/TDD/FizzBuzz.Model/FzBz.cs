namespace FizzBuzz.Model
{
    public static class FzBz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        public static string Get_FizzBuzz(int _nb) 
        {
            if (_nb != 0)
            {
                if (EstMultipleDeN(_nb,15))
                {
                    return $"{FIZZ}{BUZZ} ";
                }
                else if (EstMultipleDeN(_nb,3))
                {
                    return $"{FIZZ} ";
                }
                else if (EstMultipleDeN(_nb,5))
                {
                    return $"{BUZZ} ";
                }
            }
            return $"{_nb}";
        }
        public static string Get_FizzBuzz2(int _nb)
        {
            string res = "";
            if (_nb != 0)
            {
                res += EstFizz(_nb);
                res += EstBuzz(_nb);
            }
            return res.Length != 0 ? res : _nb.ToString();
        }
        private static string EstFizz(int _nb) => _nb % 3 == 0?$"{FIZZ}":"";
        private static string EstBuzz(int _nb) => _nb % 5 == 0 ? $"{BUZZ}" : "";
        private static bool EstMultipleDeN(int _nb,int _n) => _nb%_n==0;

        private const int Modulo3 = 3;
        private const int Modulo5 = 5;
        public static string FizzBuzzPourNombre(int nombre)
        {
            if (nombre != 0)
            {
                if (nombre % (Modulo3 * Modulo5) == 0)
                {
                    return "FizzBuzz";
                }
                else if (nombre % Modulo3 == 0)
                {
                    return "Fizz";
                }
                else if (nombre % Modulo5 == 0)
                {
                    return "Buzz";
                }
            }
            return nombre.ToString();  
        }

    }
}