/*
Las funciones nos ayuan a reutilizar codigo
*/

Saluda(); //Llamamos a nuestra funcion Saluda

int suma = Suma(5, 20);
Console.WriteLine(suma);
Console.WriteLine(Mul(1));

//Funcion que no recibe ni retorna
static void Saluda()
{
    Console.WriteLine("Hola");
}

//Funcion que recibe y retorna
static int Suma(int num1, int num2)
{
    return num1 + num2;
}

//Funcion con un valor predeterminado
static int Mul(int num1, int num2 = 2)
{
    return num1 * num2;
}