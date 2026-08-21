using Primery.Handlers;

namespace Primery;

static class Program
{
    static void Main()
    {
        CommandHandl comHandl = new(mflag: false, eflag: false, oflag: false);
        Mathhandler mathHandl = new(newModN: 1);
        while (!comHandl.oFlag)
        {
            Console.Write(">");
            string x = Console.ReadLine();
            var args = x.Split(' ');
            var command = args[0];
            string argument;
            if (args.Length < 2)
            {
                args[1] = "";
                argument = args[1];
            }
            else argument = args[1]; 
            if (args.Length > 2) Console.WriteLine("[ERR] E4");
            else comHandl.CommandHandle(comHandl, mathHandl, command, argument);
        }
    }
}
