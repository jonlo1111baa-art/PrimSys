
using PrimeryCore.Commons;
using PrimeryCore.Modules;

namespace PrimeryCore.Handlers;

public class MathHandler
{
    public bool mFlag = false;
    public int modN = 1;

    public MathHandler(int newModN)
    {
        modN = newModN;
    }

    public void commandHandle(string argument)
    {
        switch (argument)
        {
            case "-a":
                Console.Write("Enter a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("Enter Operation (0 : +, 1 : -, 2 : * , 3 : /): ");
                var op = int.Parse(Console.ReadLine());
                var r = MathModule.MMArith(op, a, b);
                Console.WriteLine($"{a}{MathModule.ReturnOp(op)}{b}  = {r}");
                break;
            case "sin":
                Console.Write("Enter the angle in degrees: ");
                var e = double.Parse(Console.ReadLine());
                var rs = MathModule.MMSinFunc(e);
                Console.WriteLine($"[ERR] {ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                break;
            case "cos":
                Console.Write("Enter the angle in degrees: ");
                var f = double.Parse(Console.ReadLine());
                var re = MathModule.MMCosFunc(f);
                Console.WriteLine($"[ERR] {ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                break;
            default:
                Console.WriteLine($"[ERR] {ECodes.ExceptionInvalidCommand.Code} : {ECodes.ExceptionInvalidCommand.Message}");
                break;

        }
    }
}
