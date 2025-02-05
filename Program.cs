// See https://aka.ms/new-console-template for more information
Console.WriteLine("you are welcome to our INECAPP");
Console.WriteLine("pleae enter your name:");
string? name = Console.ReadLine();
string Name = name.ToUpper();
Console.WriteLine(Name + " welcome");
Console.WriteLine("Please kindly enter your age");
int age = Convert.ToInt32(Console.ReadLine());
string final = (age>=18)? "You are eligible to vote" : "You are not eligible to vote";
Console.WriteLine(final);
