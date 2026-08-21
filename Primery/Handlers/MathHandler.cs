
namespace Primery.Handlers;

public class Mathhandler
{
    public bool sFlag = false;
    public bool cFlag = false;
    public bool mFlag = false;
    public int modN = 1;

    public Mathhandler(int newModN)
    {
        modN = newModN;
    }

    public void commandHandle(string argument)
    {
        
    }
    public int aritmeticOpsHandle(int op, double a, double b)
    {
        int r = 0;
        // to do : implemetn decimal aritmethic
        return r;
    }

    public double trigOpsHandle(int op, double a)
    {
        double r = 0;
        switch (op)
        {
            case 0:
                r = sinOp(a);
                break;
            case 1:
                r = cosOp(a);
                break;
        }
        return r;
    }

    public double sinOp(double a)
    {
        double r = a / 1;
        return r;
    }

    public double cosOp(double a)
    {
        double r = a / 1;
        return r;
    }
}
