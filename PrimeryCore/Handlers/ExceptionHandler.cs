using PrimeryCore.Commons;
namespace PrimeryCore.Handlers;

public static class Exceptionhandler
{
    public static void EMessageHandler(int Ecode)
    {
        switch (Ecode)
        {
            case 1: // Exception No implementation
                Console.WriteLine($"{ECodes.ExceptionInvalidArgs.Severity} {ECodes.ExceptionInvalidArgs.Code} : {ECodes.ExceptionInvalidArgs.Message}");
                break;
            case 2: //Excection No Op
                Console.WriteLine($"{ECodes.ExceptionNoOp.Severity} {ECodes.ExceptionNoOp.Code} : {ECodes.ExceptionNoOp.Message}");
                break;
            case 3: //Exception Invalid Command
                Console.WriteLine($"{ECodes.ExceptionInvalidCommand.Severity} {ECodes.ExceptionInvalidCommand.Code} : {ECodes.ExceptionInvalidCommand.Message}");
                break;
            case 4: //Exception Invalid Arguments
                Console.WriteLine($"{ECodes.ExceptionInvalidArgs.Severity} {ECodes.ExceptionInvalidArgs.Code} : {ECodes.ExceptionInvalidArgs.Message}");
                break;
            case 5: //Exception Unexpected Code Behaviour
                Console.WriteLine($"{ECodes.ExceptionUnexpectedBehavior.Severity} {ECodes.ExceptionUnexpectedBehavior.Code} : {ECodes.ExceptionUnexpectedBehavior.Message}");
                Environment.Exit(5);
                break;
        }
    }
}