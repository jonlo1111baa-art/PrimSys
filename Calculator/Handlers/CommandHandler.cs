
namespace Calculator.Handlers
{
    public class CommandHandl
    {
        public string[] args = [];
        public string[] comList = ["help", "math" , "sin" , "cos" , "comp"];
        public string[] flagList = ["-h", "-m" , "-i" , "-si" , "-co" , "-of"];
        public bool mFlag = false;
        public bool eFlag = false;
        public bool oFlag = false;

        public CommandHandl(bool mflag, bool eflag, bool oflag, string[] Args)
        {
            args = Args;
            mFlag = mflag;
            eFlag = eflag;
            oFlag = oflag;
        }
        public void HelpFunc(string args)
        {
            if (args != "")
            {
                switch (args)
                {
                    case "help":
                        break;

                }
            }
            else
            {
                for (int i = 0; i > comList.Length; i++)
                {

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