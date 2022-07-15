
while (true)
{
    Console.WriteLine("Porfavor ingresa tu año denacimiento");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tu edad es: " + Edad(edad) + " años");
}

static int Edad(int num)
{
   return int.Parse(DateTime.Now.ToString("yyyy")) - num;
}