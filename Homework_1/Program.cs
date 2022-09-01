
//Task 2
Console.Write("Insert the first number: ");
int N = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Insert the second number: ");
int M = Convert.ToInt32(Console.ReadLine()); 

if (N>M)
{Console.WriteLine("max number "+N);
Console.WriteLine("min number "+M);}
else
{Console.WriteLine("max number "+M);
Console.WriteLine("min number "+N);}

//Task 4
Console.Write("Insert the first number: ");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Insert the second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the second number: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A>C && A>B)
Console.WriteLine("Max number "+A);
else if (B>C)
Console.WriteLine("Max number"+B);
else
Console.WriteLine("Max number"+C);

//Task 6
Console.Write("Insert the first number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2==0)
Console.WriteLine("yes")
else
Console.WriteLine("no");

//Task 8
Console.Write("Insert the first number: ");
int A = Convert.ToInt32(Console.ReadLine());
for (int x=1; x<A; x++)
if (x%2==0)
Console.WriteLine(x);

