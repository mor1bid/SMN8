void DZ1() 
{
Random ra = new Random();
int bnum = ra.Next(3, 6);
int cnum = ra.Next(3, 6);
int si = bnum*cnum;
int [] ray = new int[si];
int [,] tab = new int[bnum, cnum];
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
int j = 0;
for (int bar = 0; bar<bnum; bar++)
{
    for (int col = 0; col<cnum; col++, j++)
    {
        if (ray[j]< ray[j+1])
        {
            int tmp = ray[col];
            ray[j] = ray[j+1];
            ray[j+1] = tmp;
        }
    }
    for (int i = 0, col = 0; col<cnum; col++, i++)
    {
        Console.Write(ray[i] + "\t");
    }
    j += cnum;
    Console.WriteLine("");
}
// for (int j=0, bar = 0; bar<bnum; bar++)
// {
//     for (int col = 0; col<cnum; col++, j++)
//     {
//         Console.Write(ray[j] + "\t");
//     }
//     Console.WriteLine("");
//     //j+=cnum;
// }
}

void DZ2() 
{
Random ra = new Random();
int bnum = ra.Next(2, 11);
int cnum = ra.Next(7, 18);
int si = bnum*cnum;
int [] ray = new int[si];
int [,] table = new int[bnum, cnum];
int co = 0;
int comin = co;
int sum = 0;
int mins = sum;
for (int i = 0, bar = 1; bar<bnum; bar++) 
{
    sum = 0;
    for (int col = 0; col<cnum; i++, col++)
    {
        int num = ra.Next(3, 12);
        ray[i] = num;
        Console.Write(ray[i] + "\t");
        sum += ray[i];
        if (col == cnum-1) Console.WriteLine("--> " + sum);
    }
    Console.WriteLine("");
    if (bar == 1) { mins = sum; comin = co+1; }
    else if (bar>1 && sum<=mins) { mins = sum; comin = co+1; }
    co++;
}
Console.WriteLine("Строка с наименьшим значением суммы " + mins + " находится на " + comin + " месте.");
Console.WriteLine();
}

void DZ3() 
{
Random ra = new Random();
int bnum = 4;
int cnum = 4;
int si = bnum*cnum;
int [] ray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
//int [] ray = {1, 2, 3, 4, 12, 13, 14, 5, 11, 16, 15, 6, 10, 9, 8, 7};
int [,] tab = new int[bnum, cnum];
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        //Console.Write(ray[i] + "\t");

        if (bar==0) 
        { Console.Write(ray[i] + " "); Console.WriteLine(""); }
        if (bar>0 && ray[i]>=12 || col == cnum-1 && ray[i]==5) 
        { Console.Write(ray[i] + " "); Console.WriteLine(""); }

    //     if (col==cnum-1) 
    //     {
    //         i = 0;
    //         while(bar<=bnum)
    //         {
    //             bar++;
    //             Console.Write(ray[i] + " ");
    //             i++;
    //         }
    //     }
    //     if (bar==bnum) 
    //     {
    //         i = 0;
    //         while(col<=0)
    //         {
    //             bar++;
    //             Console.Write(ray[i] + " ");
    //             i++;
    //         }
    //     }
    // }
    // Console.WriteLine("");
}
}
}
Console.WriteLine();

DZ1();
//DZ2();
//DZ3();