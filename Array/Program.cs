//También se le conoce como Matriz, la cual almacena una colección
//de datos del mismo tipo (int, float, double, String, etc.), con
//ello se evita declarar una infinidad de variables, del mismo tipo.

string[] amigos = new string[]//Arreglo sin numero de indice
{
    "julio",
    "pedro"
};

int[] edad = new int[5]; //Arreglo sin datos
edad[0] = 18; //Asignando un valor al indice 0

Console.WriteLine(edad[0]);