using System; 
public class 1Datatype 
{
	public  static void Main()
	{
		int x=4;
		Console.WriteLine("x is "+x);
		double y = 0.2d;
		Console.WriteLine("y is "+y);
        float z=5.5f;
		Console.WriteLine("z is "+z);
		char letter='a';
		Console.WriteLine("a is "+letter);
		string fname="supraja";
		Console.WriteLine("fname is "+fname);
		string lname="arthi";
		Console.WriteLine("Hello "+fname+" "+lname);
		string city,gender;
		city="Chennai";
		gender="Female";
		Console.WriteLine(city+" "+gender);
		bool isworking ; 
		isworking=true;
		Console.WriteLine(isworking);

		isworking=false;
		Console.WriteLine(isworking);

		int num1,num2;
		num1=50;
		num2=100;
		int temp;
		temp=num2;
		Console.WriteLine(temp);

	}
}

// Output
// x is 4
// y is 0.2
// z is 5.5
// a is a
// fname is supraja
// Hello supraja arthi
// Chennai Female
// True
// False
// 100