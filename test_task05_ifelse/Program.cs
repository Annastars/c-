Console.Write("add username: ");
string username = Console.ReadLine();

if (username.ToLower() == "marie")
{
	Console.WriteLine("Yahoo, This is MARIE!");
}
else
{
	Console.Write("Hello, ");
	Console.WriteLine(username);
}