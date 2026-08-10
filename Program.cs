using System.Data;
using System.Runtime.InteropServices;

class inifiles 


{
    static String Mains = "main";static String Value = "ok";

    static void Writes() 
    {

        Console.WriteLine(Value);
    
    
    }
    public static void initLoop(String[] s) 
    {
        int l1 = 0;
        int l2=0;
        foreach (String s2 in s) 
        
        {
            Value = s2;
            l1=s2.IndexOf('[')+1;
            l2= s2.IndexOf("]");
            if (!(l1 < 1)) {
                if (l2 > -1) Mains = s2.Substring(l1, l2-l1).Trim().Replace(" ", "_");
                else
                {
                    Value = "error:";
                    Writes();

                }
            }
            else 
            {
                Value = Mains + "/" + s2.Trim();
                Writes();
            
            }
           
        }
    
    
    }



}






class initini 

{
    public static void Main(String[] argv) 
    {


        int lens = argv.Length;
        String[] s = { };
        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.Clear();
        if (lens > 0) 
        
        {
            s=File.ReadAllLines(argv[0]);
            inifiles.initLoop(s);
        }
        else
        Console.WriteLine("Hello, World!");

    
    }



}
