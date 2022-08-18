void DZ1() 
{
    
Console.WriteLine("54.");
Console.WriteLine();
Random ra = new Random();
int bnum = ra.Next(3, 6);
int cnum = ra.Next(3, 6);
int si = bnum*cnum;
int [] ray = new int[si];
int [,] tab = new int[bnum, cnum];
for (int bar = 0; bar<bnum; bar++) 
{
    for (int col = 0; col<cnum; col++)
    {
        int num = ra.Next(3, 12);
        ray[col] = num;
        Console.Write(ray[col] + "\t");
    }
    Console.WriteLine("");
}
Console.WriteLine();
for (int bar = 0; bar<bnum-1; bar++)
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
for (int bar = 0; bar<bnum; bar++)
{
    for (int col = 0; col<cnum; col++)
    {
        Console.Write(tab[bar,col] + "\t");
    }
        Console.WriteLine("");
}
Console.WriteLine();
}

void DZ2() 
{
Console.WriteLine("56.");
Console.WriteLine();
Random ra = new Random();
int bnum = ra.Next(2, 11);
int cnum = ra.Next(7, 18);
int si = bnum*cnum;
int [] ray = new int[si];
int [,] tab = new int[bnum, cnum];
int co = 0;
int comin = co;
int sum = 0;
int mins = sum;
BuildRay(ray);
void BuildRay(int [] ray)
{
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
}
Console.WriteLine("Строка с наименьшим значением суммы " + mins + " находится на " + comin + " месте.");
Console.WriteLine();
}

void DZ3() 
{
Console.WriteLine("58.");
Console.WriteLine();
int bnum = 4;
int cnum = 4;
int[,] mat = new int[bnum, cnum];
int tmp = 1;
int bar = 0;
int col = 0;
while (tmp <= bnum*cnum)
{
    mat[bar, col] = tmp;
    tmp++;
    if (bar <= col + 1 && bar + col < cnum - 1) col++;
    else if (bar < col && bar + col >= bnum - 1) bar++;
    else if (bar >= col && bar + col > cnum - 1) col--;
    else bar--;
}
BuildRay(mat);
void BuildRay (int[,] rix)
{
  for (int bar = 0; bar < bnum; bar++)
  {
    for (int col = 0; col < cnum; col++)
    {
      if (rix[bar,col] / 10 <= 0)
      Console.Write($" {rix[bar,col]} ");

      else Console.Write($"{rix[bar,col]} ");
    }
    Console.WriteLine();
  }
}
}
Console.WriteLine();

DZ1();
DZ2();
DZ3();