namespace PrimeryCore.Commons;

public static class ECodes
{
    public static  (int Code, string Message , string Severity) ExceptionNoImpletation => (1, " Yet to be implemented." , "[ERR]");
    public static  (int Code, string Message , string Severity) ExceptionNoOp => (2, " No Operation implemented." , "[WARN]");
    public static  (int Code, string Message , string Severity) ExceptionInvalidCommand => (3, " Invalid Command Inserted." , "[WARN]");
    public static  (int Code, string Message , string Severity) ExceptionInvalidArgs => (4, " Invalid arguments" , "[WARN]");
    public static  (int Code, string Message , string Severity) ExceptionUnexpectedBehavior => (5, " Unexpected behavior." , "[FATAL]");
}