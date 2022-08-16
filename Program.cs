void Z1() 
{
Random ra = new Random();
int bnum = ra.Next(3, 12);
int cnum = ra.Next(3, 12);
int si = bnum*cnum;
int [] ray = new int[si];
int [,] table = new int[bnum, cnum];
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        int num = ra.Next(3, 12);
        ray[i] = num;
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        if(bar>1 || bar==cnum) 
        {
            Console.WriteLine();
            Console.Write(ray[i] + "\t");
        }
    }
    Console.WriteLine("");
}
}
Z1();

void Z2() 
{

}
Z2();