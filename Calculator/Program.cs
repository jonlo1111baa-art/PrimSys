
using System.ComponentModel;
using Calculator.Handlers;

namespace Calculator;

static class Program
{
    static void Main(string[] args)
    {
        CommandHandl comHandl = new(mflag: false , eflag : false , oflag : false , Args : []);

        switch (args)
        {
            case ["help"]:
                Console.WriteLine("Yet implemented");
                break;


        }
        while (true)
        {
            if (comHandl.oFlag == false)
            {
                break; 
            }
            else break;
        }
    }
}
