using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        StreamReader Valid = new StreamReader ("Numbers.txt");
        StreamWriter errors = new StreamWriter("errors.txt");
        string numbers = Valid.ReadLine();
        Valid.Close();
        //Console.WriteLine(numbers.Substring(0,9));
        //Console.ReadLine();
        for(int row = 0; row < 9; row++)
        {
            string checkrow = numbers.Substring(row*9,9);
            for(int square = 1; square < 10; square++)
            {
                var regex = new Regex((square.ToString()));
                int counts = regex.Count(checkrow);
            
                if (counts > 1)
                    {
                        //Console.Write(row++);
                        errors.Write("row ");
                        errors.Write(row+1);
                        errors.Write(": ");
                        errors.WriteLine(square);
                    }
            }
        }    
        for(int col = 0; col < 9; col++)
        {
            string checkCol = numbers.Substring(col, 1)+numbers.Substring(col+9, 1)+numbers.Substring(col+18, 1)+numbers.Substring(col+27, 1)+numbers.Substring(col+36, 1)+numbers.Substring(col+45, 1)+numbers.Substring(col+54, 1)+numbers.Substring(col+63, 1)+numbers.Substring(col+72, 1);
            for(int square = 1; square < 10; square++)
            {
                var regex = new Regex((square.ToString()));
                int counts = regex.Count(checkCol);
            
                if (counts > 1)
                    {
                        //Console.Write(row++);
                        errors.Write("column ");
                        errors.Write((col)+1);
                        errors.Write(": ");
                        errors.WriteLine(square);
                    }
            }
        }
        for(int box = 0; box < 9; box++)
        {
            if(box < 3)
            {
                string checkBox = numbers.Substring(box*3, 3)+numbers.Substring(box*3+9, 3)+numbers.Substring(box*3+18, 3);
                for(int square = 1; square < 10; square++)
                {
                    var regex = new Regex((square.ToString()));
                    int counts = regex.Count(checkBox);
                
                    if (counts > 1)
                        {
                            //Console.Write(row++);
                            errors.Write("Box ");
                            errors.Write((box)+1);
                            errors.Write(": ");
                            errors.WriteLine(square);
                        }
                }
            }
        
            else if(box > 2 && box < 6)
            {
                string checkBox = numbers.Substring(box*3+18, 3)+numbers.Substring(box*3+27, 3)+numbers.Substring(box*3+36, 3);
            for(int square = 1; square < 10; square++)
            {
                var regex = new Regex((square.ToString()));
                int counts = regex.Count(checkBox);
            
                if (counts > 1)
                    {
                        errors.Write("Box ");
                        errors.Write((box)+1);
                        errors.Write(": ");
                        errors.WriteLine(square);
                    }
            }
            
            }
            else 
            {
                string checkBox = numbers.Substring(box*3+36, 3)+numbers.Substring(box*3+45, 3)+numbers.Substring(box*3+54, 3);
            for(int square = 1; square < 10; square++)
            {
                var regex = new Regex((square.ToString()));
                int counts = regex.Count(checkBox);
            
                if (counts > 1)
                    {
                        errors.Write("Box ");
                        errors.Write((box)+1);
                        errors.Write(": ");
                        errors.WriteLine(square);
                    }
            }
            
            }
        }
        errors.Close();
        //Console.ReadLine();
    }

}
