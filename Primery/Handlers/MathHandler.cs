
using Primery.Commons;

namespace Primery.Handlers;

public class Mathhandler
{
    public bool mFlag = false;
    public int modN = 1;

    public Mathhandler(int newModN)
    {
        modN = newModN;
    }

    public void commandHandle(string argument, Mathhandler mathHandler)
    {
        switch (argument)
        {
            case "":
                Console.Write("Enter a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("Enter Operation (0 : +, 1 : -, 2 : * , 3 : /): ");
                var op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine($"T{a} + {b} = {mathHandler.aritmeticOpsHandle(op, a, b)}");
                        break;
                    case 1:
                        Console.WriteLine($"{a} - {b} = {mathHandler.aritmeticOpsHandle(op, a, b)}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} * {b} = {mathHandler.aritmeticOpsHandle(op, a, b)}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} / {b} = {mathHandler.aritmeticOpsHandle(op, a, b)}");
                        break;
                    default:
                        Console.WriteLine($"[ERR] E{ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                        break;
                }
                break;
            case "sin":
                Console.WriteLine("Enter the angle in degrees: ");
                var e = double.Parse(Console.ReadLine());
                var r = mathHandler.sinOp(e);
                Console.WriteLine("[ERR] E2");
                break;
            case "cos":
                Console.WriteLine("Enter the angle in degrees: ");
                var f = double.Parse(Console.ReadLine());
                var re = mathHandler.cosOp(f);
                Console.WriteLine("[ERR] E2");
                break;
            
                
        }
    }
    public double aritmeticOpsHandle(int op, double a, double b)
    {
        double r = 0.0;
        switch (op)
        {
            case 0:
                r = a + b;
                break;
            case 1:
                r = a - b;
                break;
            case 2:
                r = a * b;
                break;
            case 3:
                r = a / b;
                break;
        }
        return r;
    }
    public double sinOp(double a)
    {
        double ar = a * (3.14 / 180);
        double r = 0;
        return r;

    }

    public double cosOp(double a)
    {
        double ar = a * (3.14 / 180);
        double r = a / 1;
        return r;
    }
}
