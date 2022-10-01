// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Ведите ваше имя");
string name = Console.ReadLine();
System.Console.WriteLine("Hello," + name);
System.Console.WriteLine("Размер вашего члена?");
int age = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Ваш член " + age + " см");
if(age > 15)
{
    System.Console.WriteLine("Nice Dick BRO, welcome to the club");
}
else if(age < 15)
{
    System.Console.WriteLine("Сочувствую");
}
else
{
    System.Console.WriteLine(" ФИФТИ ФИФТИ БРАТ, не чухан конечно, но и не апполон");
}
