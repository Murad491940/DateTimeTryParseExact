using System.Globalization;

namespace ConsoleApp19
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "16-05-23";
            string str2 = "dd-MM-yy";
            DateTime a;
            if(DateTime.TryParseExact(str,str2,CultureInfo.InvariantCulture,DateTimeStyles.None,out a))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("wrog number...");
            }
        }
    }
}