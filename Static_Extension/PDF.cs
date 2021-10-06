using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	class PDF : IPrintable
	{
		public void Print()
		{
			Console.WriteLine("PDF printed");
		}
	}
}
