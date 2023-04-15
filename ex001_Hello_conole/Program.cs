Console.Write("enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("ura, this is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}