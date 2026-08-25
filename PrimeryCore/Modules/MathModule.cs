
using PrimeryCore.Commons;
namespace PrimeryCore.Modules;

static class MathModule //Yet to be implemented, make sure to overhaul MathHandler to handle MathModule
{
    public struct Optypes
    {
        public static string Op0 = " + ";
        public static string Op1 = " - ";
        public static string Op2 = " * ";
        public static string Op3 = " / ";
    }
    public static string ReturnOp(int op)
    {
        switch (op)
        {
            case 0:
                return Optypes.Op0;
            case 1:
                return Optypes.Op1;
            case 2:
                return Optypes.Op2;
            case 3:
                return Optypes.Op3;
        }
        return string.Empty;
    }
    public static double MMArith(int op, double a, double b)
    {
        double r = 0;
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
            default:
                return ECodes.ExceptionNoOp.Code; //No OP error code

        }
        return r;
    }
    public static double MMSinFunc(double a)
    {
        double ar = a * (3.14 / 180);
        double r = ar; //Yet to implement sin(x) (Im not smart enough yet)
        return r;
    }
    public static double MMCosFunc(double a)
    {
        double ar = a * (3.14 / 180);
        double r = 1 / ar; //Yet to implement cos(x) (Im not smart enough yet)
        return r;
    }
    public static double MMPower(int p, double a)
    {
        double r;
        for (int i = 0; i < p; i++)
        {
            a = a * a;
        }
        return r = a;
    }
}