using Primery.Commons;
using Primery.Handlers;

namespace Primery;

static class UserProcess
{
    static void Main()
    {
        MainHandler commandHandler = new(mflag: false, eflag: false, oflag: false);
        MathHandler mathHandler = new(newModN: 1);
        while (!commandHandler.oFlag)
        {
            Console.Write(">");
            string x = Console.ReadLine();
            var args = x.Split(' ');
        
            var command = args[0];
            string argument = "";
            try
            {
                if (args.Length < 1) 
                {
                    args[1] = "";
                    argument = args[1]; 
                    commandHandler.CommandHandle(commandHandler, mathHandler, command, argument);
                }
                else
                {
                    argument = args[1];
                    commandHandler.CommandHandle(commandHandler, mathHandler, command, argument);
                }
            }
            catch
            {
                Console.WriteLine($"E{ECodes.ExceptionInvalidArgs.Code} : {ECodes.ExceptionInvalidArgs.Message}");
            }
            
            }
    }
}
