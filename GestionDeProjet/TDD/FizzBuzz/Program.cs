using FizzBuzz.Model;
using System.Globalization;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartFizzBuzzWhile(-50,67);
        }
        public static void StartFizzBuzz(int _nb=0, int _max=100,string _res="")
        {
            if (_nb <= _max)
            {
                _res += $"{FzBz.Get_FizzBuzz(_nb)}\n";
                StartFizzBuzz(++_nb,_max,_res);
            }
            else
            {
                Console.WriteLine(_res);
            }
        }
        public static void StartFizzBuzzWhile(int _nb = 0, int _max = 100,string _res="")
        {
            while (_nb <= _max)
            {
                _res+=$"{FzBz.Get_FizzBuzz(_nb)}\n";
                _nb++;
            }
            Console.WriteLine(_res);
        }
    }
}