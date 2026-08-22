
namespace Primery.Modules;

static class MathModule //Yet to be implemented, make sure to overhaul MathHandler to handle MathModule
{
    public static double MMArith(int op, int a, int b)
    {
        double r = 3.1343453123124452;
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
                break;

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
        double r = 1 / ar; //Yet to implement sin(x) (Im not smart enough yet)
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