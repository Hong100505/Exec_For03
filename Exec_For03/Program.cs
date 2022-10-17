using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				int countOfEmpty = 5 - i;
				int countStar = i * 2 - 1;
				string row = new string(' ', countOfEmpty) + new string('*', countStar);
				Console.WriteLine(row);
			}
		}
	}
}
