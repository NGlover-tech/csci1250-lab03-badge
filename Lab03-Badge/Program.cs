using Microsoft.AspNetCore.Components.Forms;

//Question for what their name is
System.Console.Write("What is your name? ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

//Varibles for badge
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string upperfullName = fullName.ToUpper();
string firstInitial = firstName.Substring(0,1);
string lastInitial = lastName.Substring(0,1);
int numbersInLast = lastName.Length;

//Output for badge
System.Console.WriteLine("Name on badge: " + upperfullName);
System.Console.WriteLine($"Username: {firstInitial.ToLower()}{lastName.ToLower()}");
System.Console.WriteLine($"Initials: {firstInitial.ToUpper()}.{lastInitial.ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {numbersInLast}");

Random rng = new Random();

int studentIdNumber = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"Student ID: {studentIdNumber}");
System.Console.WriteLine($"Locker: {lockerNumber}");