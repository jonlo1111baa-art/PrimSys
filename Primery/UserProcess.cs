using Primery.Commons;
using Primery.Handlers;

namespace Primery;

static class UserProcess
{
    static void Main()
    {
        MainHandler mainHandler = new(mflag: false, eflag: false, oflag: false);
        MathHandler mathHandler = new(newModN: 1);
        while (!mainHandler.oFlag)
        {
            Console.Write(">");
            string x = Console.ReadLine();
            var args = x.Split(' ');
            var command = args[0];
            string argument = "";
            if (args.Length < 2)
            {
                mainHandler.CommandHandle(mainHandler, mathHandler, command, argument);
            }
            else
            {
                argument = args[1];
                mainHandler.CommandHandle(mainHandler, mathHandler, command, argument);
            }
        }
    }
}