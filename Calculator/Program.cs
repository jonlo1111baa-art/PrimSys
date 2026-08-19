using Calculator.Handlers;

namespace Calculator;

static class Program
{
    static void Main(string[] args)
    {
        CommandHandl comHandl = new(mflag: false , eflag : false , oflag : false , Args : []);

        switch (args)
        {
            case ["help"]:
                Console.WriteLine("Yet implemented");
                break;


        }
        while (true)
        {
            if (!comHandl.oFlag)
            {
                Console.Write("Enter var a:");
                var a = int.Parse(Console.ReadLine());
                Console.Write("Enter var b");
                var b = int.Parse(Console.ReadLine());
                Console.Write("enter the operation to be realized");
                var o = int.Parse(Console.ReadLine());
                var r = comHandl.ComputeOp(a, b, o);
                Console.WriteLine($"The calculated result {r}");
            }
            else
            {
                break;
            }
        }
    }
}
