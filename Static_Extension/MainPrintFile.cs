using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Extension
{
	class MainPrintFile
	{
		public MainPrintFile(IPrintable file)
		{
			file.Print();
		}
	}
}
