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
        ray[col] = num;
        Console.Write(ray[col] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine();
int bord = bnum;
for(int j = 0; j<si; j++, bord--) 
{
for (int i = 0, bar = bnum; bar>0; bar--)
{
    for (int col = 0; col<cnum-1; col++)
    {
        if (ray[col]< ray[col+1])
        {
            int tmp = ray[col];
            ray[col] = ray[col+1];
            ray[col+1] = tmp;
            //Console.Write(ray[i] + "\t");
        }
}
}
for (int i = 0, bar = 0; bar<bnum; bar++)
{
    for (int col = 0; col<cnum; col++, i++)
    {
        Console.Write(ray[col] + "\t");
    }
        Console.WriteLine("");
}
}
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
int i = 0;
int bnum = 4;
int cnum = 4;
int si = bnum*cnum;
int[] ar = new int [si];
int[] ray = new int [si];
//int [] ray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
//int [] ray = {1, 2, 3, 4, 12, 13, 14, 5, 11, 16, 15, 6, 10, 9, 8, 7};
int [,] tab = new int[bnum, cnum];
int num1=0;
int j1=ray[9];
for (int bar = 0; bar<bnum; bar++) 
{
    // for (int j = 1, col = 0; col<cnum; i++, col++)
    // {
    //     if (bar==0)
    //     {
    //         Console.Write(ray[i] + " ");
    //     }
    //     if (bar==1 && num1>=ray[11])
    //     {
    //         Console.WriteLine("");
    //         Console.Write(ray[i] + " ");
    //         if (col==cnum-1) 
    //         {
    //             Console.Write($"{ray[cnum-1]}" + " ");
    //         }
    //     }
    //     if (bar==2)
    //     {
    //         Console.WriteLine("");
    //         Console.Write($"{ray[11]-1}" + " ");
    //         Console.Write($"{ray[12]+3}" + " ");
    //         if (col==cnum-1) 
    //         {
    //             Console.Write($"{ray[cnum-1]+cnum}" + " ");
    //         }
    //     }
    for (int j = 1, col = 0; col<cnum; i++, col++) 
    {
        num1+=j;
        ray[i] = num1;
        if (num1==ray[cnum]) {ar[i] = num1;}
        {
            //Console.WriteLine("");
            ray[i] = num1;
            Console.Write(ray[i] + " ");
            if (col==cnum-1) {Console.Write(ray[cnum]);}
        }
        if (bar==0) {Console.Write(ray[i] + " ");}
}
Console.WriteLine("");
}
}
Console.WriteLine();

//DZ1();
//DZ2();
DZ3();