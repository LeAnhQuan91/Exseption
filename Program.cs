using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int [] myArray = {0,1,2,3,4,5,6,7,8,9};
        
    try
    {
      Console.WriteLine(myArray [11]);
    }
  catch (System.Exception ex)   
  {
    Console.WriteLine("Loi roi");
  }
    finallycl
    {

    }
    int a = 10;
    int b = 0;
    try 
    {
        int c = a/b;
    }
    catch (FomatException ex)
    {
Console.WriteLine("exMessage");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("exMessage");
    }
}
}