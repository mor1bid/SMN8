void DZ1() 
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

// int min = ray[0];
// //int max = ray[0];
// int tmp = 0;
for (int i = 0, j = 0, bar = 0; bar<bnum; bar++)
{
    int min = ray[j];
    int tmp = 0;
    for (int col = 0; col<cnum; i++, col++)
    {
        if (ray[i]<=min) 
        { 
            tmp = min;
            min = ray[i];
            Console.Write(ray[i] + "\t");
            ray[i] = tmp;
        }
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
    j += cnum;
}

}
DZ1();