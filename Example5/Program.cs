Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToUpper() == "MASHA"){
    Console.WriteLine("Hey! There is MASHA!");
} else {
    Console.WriteLine("Hey, usual user " + username + "!");
}