public class Program 
{
	static void staircase(int n)
	{
		int brojac=0;
		for(int i=0; i<n; i++)
		{
			for(int j=0; j<n; j++)
			{
				if(j>=n-brojac)
				{
					Console.WriteLine("#");
				}
				else if(j<brojac)
				{
					Console.WriteLine(" ");
				}
			}
		}
	}
	static void Main(string[] args)
	{
		int n= int.Parse(Console.ReadLine());
	}
}