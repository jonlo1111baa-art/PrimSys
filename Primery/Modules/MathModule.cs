
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
}