
using System;
namespace ProvincePicker
{
	class ProvincePicker
	{
		static void Main( )
		{

			string provinceAbbrev;

			Console.WriteLine("Enter the province "
								+ "abbreviation. "); 
			Console.WriteLine("Its full name will"
								+ " be displayed");
			Console.WriteLine( );
			provinceAbbrev = Console.ReadLine();

			switch(provinceAbbrev)
			{
				case "ONT":	
					Console.WriteLine("Ontario");
					break;		
				case "QUE":
					Console.WriteLine("Quebec");
					break;		
				case "PEI":
					Console.WriteLine("Prince Edward Island");
					break;		
				case "BC":
					Console.WriteLine("British Columbia");
					break;		
				default:
					Console.WriteLine("No match");	
					break;
			}
			Console.ReadLine();
		}
	}
}
