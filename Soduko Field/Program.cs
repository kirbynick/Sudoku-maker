internal class Program
{
    private static void Main(string[] args)
    {
        //int column = 1;
        //int row = 1;

        for (int row = 1; row<10; row++)
        {

            for (int column = 1; column<9; column++)
            {
                
                Random random = new Random();

                int num = random.Next(-9, 10);

                if(num>0)
                {
                    Console.Write("[");
                    Console.Write(num);
                    Console.Write("]");  
                } else
                {
                    Console.Write("[ ]");
                }
            }
            
                {
                    Random random = new Random();

                    int num1 = random.Next(-9, 10);

                if(num1>0)
                    {    
                        Console.Write("[");
                        Console.Write(num1);
                        Console.WriteLine("]");
                    } else
                    {
                        Console.WriteLine("[ ]");
                    }
                } 
        }  
    }

        
}