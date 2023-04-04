
namespace SitoZiomka;
internal class Program
{
    public static void Sito(int range)
    {
        bool []allNumbers = new bool[range];
        List<int> allPrimes = new List<int>();
        
        for(int i = 0 ; i < range; i++) {
            allNumbers[i] = true;
        }

        for (int i = 0; i < range; i++)
        {
            if (i <= 1)
            {
                allNumbers[i] = false;
            }
            else if (allNumbers[i])
            {
                allPrimes.Add(i);
                for (int j = i; j < range; j+=i)
                {
                    allNumbers[j] = false;
                }
            }
        }

        foreach(int i in allPrimes)
        {
            Console.WriteLine(i);
        }
    }

    public static bool isPrime(int number)
    {
        if(number <= 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    static void Main()
    {
        Sito(100);
        Console.WriteLine(isPrime(97));
    }
}
