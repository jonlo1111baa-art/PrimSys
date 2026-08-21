using Calculator.Handlers;

namespace Calculator;

static class Program
{
    static void Main()
    {
        CommandHandl comHandl = new(mflag: false, eflag: false, oflag: false);
        Mathhandler mathHandl = new(newModN: 1);
        while(!comHandl.oFlag)
        {
            Console.Write(">");
            string x = Console.ReadLine();
            var args = x.Split();

            switch (args)
            {
                case ["help"]:
                    Console.WriteLine("[ERR] E1");
                    break;
                case ["cos"]:
                    Console.WriteLine("[ERR] E1");
                    break;
                case ["sin"]:
                    Console.WriteLine("[ERR] E1");
                    break;
                case ["mem"]:
                    Console.WriteLine("[ERR] E1");
                    break;
                case ["math"]:
                    Console.Write("Enter var a:");
                    var a = int.Parse(Console.ReadLine());
                    Console.Write("Enter var b: ");
                    var b = int.Parse(Console.ReadLine());
                    Console.Write("enter the operation to be realized: ");
                    var o = int.Parse(Console.ReadLine());
                    var r = mathHandl.aritmeticOps(o, a, b);
                    Console.WriteLine($"The calculated result {r}");
                    break;
                default:
                    Console.WriteLine("invalid function for list of valid fuctions type help");
                    break;
            }
        }
    }
}
