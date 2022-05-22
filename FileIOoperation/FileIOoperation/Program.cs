using System;
using FileIOoperation;
class program
{
    public static void Main(string[] args)
    {
        OperationIO operationIO = new OperationIO();
        operationIO.FileExists();
        operationIO.ReadAllLines();
        operationIO.ReadAllText();
        operationIO.CopyFile();
        operationIO.DeleteFilePath();
        operationIO.UsingStreamReader();
    }
}