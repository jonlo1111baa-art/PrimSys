using System.Data;

namespace Calculator.Handlers;

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

    public int aritmeticOps(int op, int a, int b)
    {
        int r = 0;
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
}
