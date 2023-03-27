string? numNLine = Console.ReadLine();
if (numNLine != null)
{
    int numN = int.Parse(numNLine);
    int startNum = numN * (-1);
    string res = String.Empty;
    while (startNum<=numN)
    {
        res = res + startNum + " ";
        startNum = startNum + 1;
    }
        Console.WriteLine (res);
    
}