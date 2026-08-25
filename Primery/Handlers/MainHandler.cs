
using Primery.Commons;

namespace Primery.Handlers
{
    public class MainHandler
    {

        public string[] comList = ["help", "math", "sin", "cos", "mem"];
        public string[] comDesList = ["help : when given no arguments will list all commands, when given a the name of a command as argument will give a detailed description", "math : will enter math mode will not accept arguments", "sin : activates the trigometry mode, giving the sin() of the calculated result, identical to the -s flag", "cos : Will print the cos() of the calculated result, identica to the -c flag but global", "mem : will map the output aff all math operations to memory until disabled"];
        public string[] flagList = ["-h", "-m","-s", "-c", "-o"];
        public string[] flagDesList = ["-h : when given to a command as a flag will give the extended description, similar function to help <command>" , "-m : map the output of the inmediate operation to memory, it is not global", "s- : print the sin() of the result of the next math operation, note it is not global" , "-c : print the cos() of the following math operation , like -s it is not global" , "-o : out flag will exit the program after the next operation"];
        public bool mFlag = false;
        public bool eFlag = false;
        public bool oFlag = false;

        public MainHandler(bool mflag, bool eflag, bool oflag)
        {
            mFlag = mflag;
            eFlag = eflag;
            oFlag = oflag;
        }
        public void CommandHandle(MainHandler commandHandl , MathHandler mathHandl ,string command, string argument)
        {
            switch (command)
            {
                case "help":
                    commandHandl.HelpFunc(argument);
                    break;
                case "math":
                    mathHandl.commandHandle(argument);
                    break;
                case "mem":
                    Console.WriteLine($"[ERR] {ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                    break;
                default:
                    Console.WriteLine($"[ERR] {ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                    break;
            }
        }
        public void HelpFunc(string args)
        {
            if (args == "")
            {
                Console.WriteLine("The complete command list is as follows");
                foreach (string i in comDesList)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("");
                } 
                Console.WriteLine();
                Console.WriteLine("The complete flag list is as follows");
                foreach (string i in flagDesList)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("");
                }
            }
            else
            {
                switch (args)
                {
                    case "help":
                        Console.WriteLine("Describes the complete fucntionality of a fuction when given as a argument:");
                        Console.WriteLine("");
                        Console.WriteLine("Shape: help <command> or help for complete command list");
                        Console.WriteLine("Can also be flag -h");
                        break;
                    case "math":
                        Console.WriteLine("Direct Interface with the Math module and its operations");
                        Console.WriteLine("");
                        Console.WriteLine("Shape : math <selected operation or flag>");
                        Console.WriteLine("Posible args:");
                        Console.WriteLine("-a : for aritmetic operations");
                        Console.WriteLine("sin : for sin(x) it will ask for x (NOTE NOT IMPLEMENTED!)");
                        Console.WriteLine("cos : for cos(x) it will ask for x (NOTE NOT IMPLEMENTED!)");
                        Console.WriteLine("mem : Save the next operation in memory (NOTE NOT IMPLEMENTED)");
                        break;
                    default:
                        Console.WriteLine($"{ECodes.ExceptionInvalidArgs.Code} : {ECodes.ExceptionInvalidArgs.Message}");
                        break;

                }
            }
        }
    }
}