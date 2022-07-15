Console.WriteLine("ingrese el Id");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese el Nombre:");
string name = Console.ReadLine();

Console.WriteLine("ingrese el Email:");
string email = Console.ReadLine();

Console.WriteLine("Ingrese el Password:");
string password = Console.ReadLine();

Console.WriteLine("Ingrese el Numero de Telefono:");
string phoneNumber = Console.ReadLine();


User user = new User(id, name, email, password, phoneNumber);
Console.WriteLine(user.GetUser());


class User
{
    int id;
    String name;
    String email;
    String password;
    String phoneNumber;

    public User(int id, String name, String email, String password, String phoneNumber)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.phoneNumber = phoneNumber;
    }

    public string GetUser()
    {
        return $"Nombre: {name} Email: {email} Telefono {phoneNumber}";
    }
}
    