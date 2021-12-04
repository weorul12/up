 
double getResult(int n,int x){
    return n/(Math.Pow(x,n));
}

Console.WriteLine("Введите X:");
int x=Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n=Int32.Parse(Console.ReadLine());

double c=0;
for (int i=1; i<=n; i++)
{
c=c+getResult(i,x);
}
Console.WriteLine("Ответ:{0}",c);
