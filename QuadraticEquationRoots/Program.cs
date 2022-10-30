using B=System.Console;
class QuadraticEquationRoots
{
    public static void Main()
    {
        int a,b,c;
        double r1,r2,d;
        B.WriteLine("Enter the coefficients of quadratic equation");
        B.WriteLine("Enter 3 values:: ");
        a=int.Parse(B.ReadLine());
        b=int.Parse(B.ReadLine());
        c=int.Parse(B.ReadLine());
        d=(b*b)-(4*a*c);
        if(d>0)
        {
            r1=(-b+Math.Sqrt(d))/(2*a);
            r2=(-b-Math.Sqrt(d))/(2*a);
            B.WriteLine("Roots are:: "+r1+"and "+r2);
        }
        else if(d==0)
        {
            r1=-b/(2*a);
            B.WriteLine("Root is "+r1);
        }
        else
        {
            B.WriteLine("Roots are imaginary");
        }
    }
}