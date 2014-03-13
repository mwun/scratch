using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratch
{
	class Program
	{
		static void Main(string[] args)
		{
			//Encodings test = new Encodings();
			//TimeSpans test = new TimeSpans();
			
			
			
			
			
			
			//test.View();
			Console.ReadKey();
		}
	}

	class TimeSpans : iViewable
	{
		public void View()
		{
			Console.WriteLine("Min, Max and One Year TimeSpan:");
			TimeSpan min = TimeSpan.MinValue;
			TimeSpan max = TimeSpan.MaxValue;
			TimeSpan year = TimeSpan.FromMinutes(525600);
			TimeSpan[] tsa = { min, max, year };
			foreach (TimeSpan ts in tsa)
			{
				Console.WriteLine("string");
				Console.WriteLine(ts);
				Console.WriteLine("days, hours, minutes");
				Console.WriteLine(ts.Days + ", " + ts.Hours + ", " + ts.TotalMinutes);
				Console.WriteLine("formatted string");
				Console.WriteLine(ts.ToString(@"dd' Days 'hh' Hours 'mm' Minutes'"));
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}

	class Encodings : iViewable
	{
		public void View()
		{
			EncodingInfo[] encodings = Encoding.GetEncodings();
			foreach (EncodingInfo e in encodings)
			{
				Console.WriteLine(e.Name);
				Console.WriteLine(e.DisplayName);
				Console.WriteLine(e.CodePage);
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}

	interface iViewable 
	{
		void View();
	}
}
