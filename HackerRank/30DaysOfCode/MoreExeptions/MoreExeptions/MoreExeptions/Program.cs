using System;

class Calculator
{
    public Calculator()
    {

    }

    public int power(int a, int b)
    {
        if (a < 0 || b < 0)
            throw new NegativePowerNumberExeption();


        var result= Math.Pow(a, b);
        return Convert.ToInt32(result);
    }
}
[Serializable]
class NegativePowerNumberExeption : Exception
{
    public NegativePowerNumberExeption():base("n and p should be non-negative")
    {
    }
}

class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (NegativePowerNumberExeption e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}