using System;
namespace DateTimeLecture 
{
	class program 
	{
		static void Main(string[] args)
		{
			DateTime myDate = new DateTime();
			Console.WriteLine(myDate);

			DateTime today =  DateTime.Today;
			Console.WriteLine(today);

			DateTime now =  DateTime.Now;
			Console.WriteLine(now);

			DateTime myDate1 = new DateTime();
			Console.WriteLine(myDate1.ToLongDateString());
			Console.WriteLine(myDate1.AddDays(10));

			string  formatedDate = string.Format("Date is {0:yyyy M d}",myDate);
			Console.WriteLine(formatedDate);

		}
	}
}