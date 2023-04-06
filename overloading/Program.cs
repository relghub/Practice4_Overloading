Console.Write("Введіть значення аргумента x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введіть значення аргумента y: ");
double y = double.Parse(Console.ReadLine());
double f;
if (x >= 2 && x < 5 && y < 3)
{
    f = EvalObj.Evaluation(ref x, ref y);
}
else if (y >= 3)
{
    f = EvalObj.Evaluation(ref y);
}
else
{
    f = EvalObj.Evaluation(x, y);
}
Console.WriteLine($"Розв'язком системи рівнянь є {f}");
class EvalObj
{
    public static double Evaluation(ref double x, ref double y)
    {
        return x - y + Math.Pow(2, x);
    }
    public static double Evaluation(ref double y)
    {
        return 5 - 6 * y;
    }
    public static double Evaluation(double ArgumentX, double ArgumentY)
    {
        return 33.3 - 2 * Math.Pow(ArgumentX - ArgumentY, 2);
    }
}
