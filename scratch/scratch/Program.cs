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
			//Formatting test = new Formatting();
			iViewable a = new Formatting();
			List<iViewable> masterlist = new List<iViewable>();
			masterlist.Add(new Formatting());
			masterlist.Add(new TimeSpans());
			masterlist.Add(new Formatting());

			while (true)
			{

				Console.WriteLine("choose one");
				int cntr = 0;
				foreach (iViewable clas in masterlist)
				{
					Console.Write(cntr++);
					Console.WriteLine(": {0}", clas.ToString());
				}

				int choice = int.Parse(Console.ReadKey().KeyChar.ToString());
				Console.WriteLine("\nYou chose {0}: {1}", choice, masterlist[choice]);

				masterlist[choice].View();
				Console.ReadKey();
			}
		}
	}

	class Formatting : iViewable
	{
		public void View()
		{
			Console.WriteLine("formatting and comparing strings");
			string a = string.Format("this is a {0} with 3 {1} {2}.", "string", "format", "parameters");
			Console.WriteLine(a);
			string b = string.Format("This is a {0} with an {1} of 4 {2} {3}.", new string[] { "string", "array", "format", "parameters" });
			Console.WriteLine(b);
			Console.WriteLine("this is a {0} with 3 {1} {2} that bypasses string.Format", "string", "format", "parameters");
			string c = "this is a string with 3 format parameters.";
			string d = "THIS IS A STRING WITH 3 FORMAT PARAMETERS.";
			Console.Write("\"{0}\".equals(\"{1}\"): ", a, c);
			Console.WriteLine(a.Equals(c));
			Console.Write("\"{0}\".equals(\"{1}\"): ", c, d);
			Console.WriteLine(c.Equals(d));
			Console.Write("\"{0}\".equals(\"{1}\"); ignorecase: ", c, d);
			Console.WriteLine(c.Equals(d, StringComparison.CurrentCultureIgnoreCase));
			Console.WriteLine();
			Console.Write("\"{0}\".CompareTo(\"{1}\"): ", a, c);
			Console.WriteLine(a.CompareTo(c));
			Console.Write("\"{0}\".CompareTo(\"{1}\"): ", c, d);
			Console.WriteLine(c.CompareTo(d));
			Console.Write("String.Compare(\"{0}\", \"{1}\"); ignorecase: ", c, d);
			Console.WriteLine(String.Compare(c, d, true));
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
		}
	}

	interface iViewable 
	{
		void View();
	}
}
