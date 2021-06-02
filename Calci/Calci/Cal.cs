public class CalCulator  
{

    public  int calci(int num1, string op, int num2)
    {
        if (op == "+")
        {
            return num1 + num2;
        }
        else if (op == "-")
        {
            return num1 - num2;
        }
        else if (op == "/")
        {
            return num1 / num2;
        }

        else if (op == "*")
        {
            return num1 * num2;
        }
        
        else
        {
            return  -1;
        }

        //Console.ReadLine();

    }

  
}