﻿void Z1() 
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
            //Console.Write(ray[i] + "\t");

            imax++;
        }
        else if (bar>0) Console.Write(ray[j] + "\t");
        if (bar==0) 
        {
            t = ray[imin];
            ray[imin] = ray[imax];
            ray[imax] = t;
            Console.Write(ray[imin] + "\t");
            Console.Write(ray[imax] + "\t");
        }
    }
    Console.WriteLine("");
}
}
//Z1();

void Z2() 
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
if (bnum == cnum)
for (int temp = 0, i = 0, bar = 0; i<bnum; i++, bar++) 
{
    for (int j = i+1, col = 0; j<cnum; j++, col++)
    {
        temp = table[i, j];
        table[i, j] = table[j, i];
        table[j, i] = temp;
        Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
}
}
Z2();