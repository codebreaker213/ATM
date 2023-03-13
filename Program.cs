namespace atm
{

    static class Atm
    {
        static public int a;
        static string output="";
        static int n200 = 100;
        static int n100 = 100;
        static int n50 = 100;
        static int n20 = 100;
        static int n10 = 100;
        static int n5 = 100;
        static int n1 = 100;

        static public void Calcuate (int a)
        {
            if (a > 10000)
            {
                a = 0;
                Console.WriteLine("Impossible Amount!");
            }
            output = "";
            while (a >= 200 && n200>0)
            {
                output += "200" + " ";
                a -= 200;
                n200 -= 1;                   
            }
            while (a >= 100 && n100>0)
            {
                output += "100" + " ";
                a -= 100;
                n100 -= 1;
            }
            while(a >= 50 && n50 >0)
            {
                output += "50" + " ";
                a -= 50;
                n50 -= 1;
            }
            while(a >= 20 && n20>0)
            {
                output += "20" + " ";
                a -= 20;
                n20 -= 1;
            }
            while (a >= 10 && n10>0)
            {
                output += "10" + " ";
                a -= 10;
                n10 -= 1;
            }
            while (a >= 5 && n5>0)
            {
                output += "5" + " ";
                a -= 5;
                n5 -= 1;
            }
            while(a >= 1 && n1>0)
            {
                output += "1" + " ";
                a -= 1;
                n1-= 1;
            }

            if (a!=0) 
            { 
                output="Impossible Amount of banknotes";
            }
        }
        static public void Print()
        {
            Console.Write("output: ");
            Console.WriteLine(output);
        }

    }


    class test
    {
        static void Main()
        {
            

            while (true)
            {            
                
                Console.WriteLine("Please enter the amount you want:");
                try
                {   
                    int amount = 0;
                    amount = Convert.ToInt32(Console.ReadLine());
                    Atm.Calcuate(amount);
                    Atm.Print();
                    Console.WriteLine("Thanks for using ATM");
                }
                catch 
                {
                    Console.WriteLine("Enter A Number");
                    return;
                }



            }
            
        }

    }
}


