

using System.Text;

int monthlyWage = 1234;

int months = 12, bonus = 1000;

bool isActive = true;

double rating = 99.25;

double ratePerHour = 11.44;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour + numberOfHoursWorked;

//Console.WriteLine(currentMonthWage);

int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);


bool isUpper = char.IsUpper(upperVersion);
bool isDigit = char.IsDigit(upperVersion);

//Console.WriteLine(isUpper);
//Console.WriteLine(isDigit);

//Working with dates

DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

DateTime startDate = hireDate.AddDays(15);

//Console.WriteLine(startDate);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(endHour);

//Console.ReadLine();


//Converting between types


long veryLongMonth = numberOfHoursWorked;
double d = 1231413423423432.0;
int x =(int)d;


string fname = "Bethany";
string lname = "Smith";

var userName = "BethanyS";


int l = fname.Length;

bool a = fname.Contains('q');//false

string fullName = String.Concat(fname, lname);



//Console.WriteLine(fullName);


string displayName = $"Welcome!\n{fname}\t{lname}";
//Console.WriteLine(displayName);



StringBuilder sb = new StringBuilder();

string name = "Bethany";

string lastName = "Smith";

sb.Append("First Name: ");
sb.Append(name);
sb.Append("\n");
sb.Append("Last name: ");
sb.Append(lastName);

//Console.WriteLine(sb);

//tryParse


//Console.WriteLine("Enter the wage:");
//string wage = Console.ReadLine();

//int wageValue;

//if (int.TryParse(wage, out wageValue))
//{
//    Console.WriteLine("Parsing success "+wageValue);

//}
//else
//{
//    Console.WriteLine("Parsing failed");
//}




































