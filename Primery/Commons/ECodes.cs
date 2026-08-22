namespace Primery.Commons;

public static class ECodes
{
    public static  (int Code, string Message) ExceptionNoImpletation => (1, " Yet to be implemented.");
    public static  (int Code, string Message) ExceptionNoOp => (2, " No Operation implemented.");
    public static  (int Code, string Message) ExceptionNoInvalidCommand => (3, " Invalid Command Inserted.");
    public static  (int Code, string Message) ExceptionInvalidArgs => (4, " Too many Arguments.");
    public static  (int Code, string Message) ExceptionUnexpectedBehavior => (5, " Unexpected behavior.");
}