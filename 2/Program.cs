int SumCountRec(int m,int n) 
{

    if(m==n) return m;
    else return m+(SumCountRec(m+1,n));
    
}
Console.WriteLine("Ведите M");
int M=int.Parse(Console.ReadLine());
Console.WriteLine("Ведите N");
int N=int.Parse(Console.ReadLine());
Console.WriteLine(SumCountRec(M,N));