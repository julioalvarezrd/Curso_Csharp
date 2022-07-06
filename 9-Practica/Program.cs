Console.WriteLine(Edad(1992));

static int Edad(int num)
{
   return int.Parse(DateTime.Now.ToString("yyyy")) - num;
}