
namespace Calculator.Handlers
{
    public class CommandHandl
    {

        public string[] comList = ["help", "math", "sin", "cos", "comp"];
        public string[] comDesList = ["help : when given no arguments will list all commands, when given a the name of a command as argument will give a detailed description", "math : will enter math mode will not accept arguments", "sin : activates the trigometry mode, giving the sin() of the calculated result, identical to the -s flag", "cos : Will print the cos() of the calculated result, identica to the -c flag but global", "comp : activate compute mode"];
        public string[] flagList = ["-h", "-m" , "-i" , "-s" , "-c" , "-o"];
        public bool mFlag = false;
        public bool eFlag = false;
        public bool oFlag = false;

        public CommandHandl(bool mflag, bool eflag, bool oflag)
        {
            mFlag = mflag;
            eFlag = eflag;
            oFlag = oflag;
        }
        public void HelpFunc(string[] args)
        {
            if (args.Length != 1)
            {
                switch (args)
                {
                    case ["help"]:
                        Console.WriteLine("Describes the complete fucntionality of a fuction when given as a argument:");
                        Console.WriteLine("");
                        Console.WriteLine("Shape: help <command> or help for complete command list");
                        Console.WriteLine("Can also be command -h");
                        break;

                }
            }
            else
            {
                Console.WriteLine("The complete command list is as follows");
                foreach (string i in comDesList)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("");
                } 
                Console.WriteLine();
                Console.WriteLine("The complete flag list is as follows");
                foreach (string i in flagList)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("");
                }
            }

        }
        public int ComputeOp(int a, int b, int o)
        {
            var r = 0;
            switch (o)
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
                case 4:
                    r = a % b;
                    break;
            }
            return r;
        }

    }
}