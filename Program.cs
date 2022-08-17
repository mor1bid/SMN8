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
        //Console.Write(ray[i] + "\t");
    }
    Console.WriteLine("");
    j += cnum;
}
}
Console.WriteLine("");

void DZ2() 
{
Random ra = new Random();
int bnum = 6;
int cnum = 3;
int si = bnum*cnum;
int [] ray = new int[si];
int [,] table = new int[bnum, cnum];
int co = 0;
int comin = co;
int sum = 0;
for (int i = 0, bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; i++, col++)
    {
        int num = ra.Next(3, 12);
        ray[i] = num;
        Console.Write(ray[i] + "\t");
        sum += ray[i];
        if (col == cnum-1) Console.WriteLine("--> " + sum);
    }
    Console.WriteLine("");
}
Console.WriteLine();
//int min = ray[0];
// for (int i = 0, tmp = 0, bar = 1; bar<bnum; bar++)
// {
//     co++;
//     tmp = sum;
//     int mins = tmp;
//     sum = 0;
//     for (int col = 1; col<cnum; i++, col++)
//     {
//         sum += ray[i];
//         if (col == cnum-1) Console.WriteLine("--> " + sum);
//     }
//     if (bar==1) mins = sum;
//     if (sum<mins && bar>1) 
//     { 
//         mins = sum;
//         comin = co+1;
//     }
//     if(bar==bnum-1) Console.WriteLine("Строка с наименьшим значением суммы" + mins + " находится на " + comin + " месте.");
// }
}

//DZ1();
DZ2();
//DZ3();