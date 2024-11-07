Console.WriteLine("How many presentations to start?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many presentations?");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    int k = (i * (i + 1)) / 2;
    Console.WriteLine(k);
}
// amirhossein azarakhsh 


