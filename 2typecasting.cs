using System; 
public class Hello
{
	public  static void Main()
	{
		int sno=100;
		string accno="";
		accno=sno.ToString();
		Console.WriteLine(accno);
	
		float anyno=3.5f;
		// Cannot implicitly convert type 'float' to 'int'. An explicit conversion exists (are
        // you missing a cast?)
		// sno=anyno;
		// sno=Convert.ToInt32(anyno);
		// gives ceil val of float 
		sno=(int)anyno;
		// gives floor val of float
		Console.WriteLine(sno);
	}
}

// 100
// 3
// 4