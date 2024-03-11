using System.Collections;

namespace Collections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] massiv = { 3, - 3, 9, - 9, 0 };
			int count = 0;
			for (int i = 1; i < massiv.Length; i++)
			{
				if ((massiv[i - 1] > 0 && massiv[i]<0) || (massiv[i - 1] < 0 && massiv[i] > 0))
				{
					count++;
					massiv[i - 1] *= -1;
					massiv[i] *= -1;
				}
				else
				{
					count++;
				}
			}
            Console.WriteLine(string.Join(",",massiv));
            Console.WriteLine(count);
        }
	}
}
