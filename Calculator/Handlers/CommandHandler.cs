
namespace Calculator.Handlers
{
    public class CommandHandl
    {
        public string[] args = [];
        public bool mFlag = false;
        public bool eFlag = false;
        public bool oFlag = false;

        public CommandHandl(bool mflag , bool eflag , bool oflag , string[] Args)
        {
            args = Args;
            mFlag = mflag;
            eFlag = eflag;
            oFlag = oflag;
        }

    }
}