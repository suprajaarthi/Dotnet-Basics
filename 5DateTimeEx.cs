using System;
namespace DateTimeLecture 
{
	class program 
	{
		static void Main(string[] args)
		{
			DateTime myDate = DateTime.Now; 

			string formated1="";
			string formated2="";
			string formated3="";
			//1st format =>  04-03-2021 11:35:51
			formated1=string.Format("{0:dd-MM-yyyy HH:mm:ss}",myDate);
			Console.WriteLine(formated1);

			// 2nd format => Thursday of month Mar year 2021
			formated2=string.Format("{0:dddd 'of month' MMM 'year' yyyy}",myDate);
			Console.WriteLine(formated2);

			// 3rd format => 
			// Thursday of month Mar year 2021
 		// 		Day
 		// 		Month March
 		// 		2021
			formated3=string.Format("{0: 'Day' \n 'Month' MMMM '\n' yyyy}",myDate);
			Console.WriteLine(formated3);
	}
}
}