using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	class Excel : IPrintable
	{
		public void Print()
		{
			Console.WriteLine("Excel printed");
		}
	}
}
