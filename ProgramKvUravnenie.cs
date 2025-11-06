// See https://aka.ms/new-console-template for more information
Console.WriteLine("Примерно решение за квадратно уравнение");
Console.Write("Въведете а");
int a=int.Parse(Console.ReadLine());
Console.Write("Въведете b");
int b = int.Parse(Console.ReadLine());
Console.Write("Въведете c");
int c = int.Parse(Console.ReadLine());
if(a==0)
{
    if(b==0)
    {
        if(c==0)
            Console.WriteLine("Всяко x е решение");
        else
            Console.WriteLine("Няма решение");
    }
    else
    {
        Console.WriteLine("x=" + (double)-c/(double)b);
    }

}
else
{
    double D = Math.Pow(b, 2) - 4 * a * c;
    if(D<0)
    {
        Console.WriteLine("Няма реални корени");
    }
    else 
        if(D==0)
            {
            Console.WriteLine("x1=x2="+-b/(2*a));
            }
        else
        {
        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
        double x2 = (-b + Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"x1={x1:f3}  x2={x2:f3}");
    }
}
