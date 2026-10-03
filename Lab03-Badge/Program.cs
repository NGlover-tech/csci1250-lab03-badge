/*
* Name: Nicholas Glover
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

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

// Setting random
Random rng = new Random();

//rng for variables 
int studentIdNumber = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

//output of rng
System.Console.WriteLine($"Student ID: {studentIdNumber}");
System.Console.WriteLine($"Locker: {lockerNumber}");

//Questions for distance and walk speed
System.Console.WriteLine("What is your dorm's x-cord?");
int dormX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is your dorm's y-cord?");
int dormY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is your classroom's x-cord?");
int classroomX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is your classroom's y-cord?");
int classroomY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is your walking speed in feet per second?");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

//Calculations for distance and walking
double xPart = Math.Pow(classroomX - dormX,2);
double yPart = Math.Pow(classroomY - dormY,2);
double addingParts = xPart + yPart;
double distance = Math.Sqrt(addingParts);
double walkTimeMinutes = distance/ (int)walkingSpeed/60;
double walkTimeSeconds = Math.Round(distance / walkingSpeed%60, 0);

//Output
System.Console.WriteLine($"Distance: {distance.ToString("F1")} feet");
System.Console.WriteLine($"Walk Time: {Math.Floor(walkTimeMinutes)} minutes {walkTimeSeconds.ToString("F0")} seconds");

//The final resulting badge
System.Console.WriteLine("==================================");
System.Console.WriteLine("        ETSU STUDENT BADGE");
System.Console.WriteLine("==================================");
System.Console.WriteLine("NAME".PadRight(10) + upperfullName);
System.Console.WriteLine("USERNAME".PadRight(10) + firstInitial.ToLower() + lastName.ToLower());
System.Console.WriteLine("ID".PadRight(10) + studentIdNumber + "-" + studentIdNumber%9);
System.Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
System.Console.WriteLine("WALK".PadRight(10) + Math.Floor(walkTimeMinutes) + " min " + walkTimeSeconds.ToString("F0") + " sec");
System.Console.WriteLine("==================================");
