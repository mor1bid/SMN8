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
Console.WriteLine();
for (int imin = 0, imax = 0, j = 0, t = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; j++, col++)
    {
        if(bar+1==bnum) 
        {
            t = ray[imin];
            ray[imin] = ray[imax];
            ray[imax] = t;
            imax++;
        }
        else if (bar>0) Console.Write(ray[j] + "\t");
        if (bar==0) 
        {
            Console.Write(ray[imin] + "\t");
            Console.Write(ray[t] + "\t");
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