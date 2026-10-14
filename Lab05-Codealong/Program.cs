//string[] names = {"Mathew Desjardins", "Sally Fields", "Joe Smith", "Susan Rice"};
System.Console.WriteLine("How many students do you want to enter? ");
int numStudents = Convert.ToInt32(Console.ReadLine());



if(numStudents > 20)
{
    numStudents = 20;
}

string[] names = new string[numStudents];

for(int i = 0; i < numStudents; i++)
{
    if(i == 0)
    {
        Console.Write($"Please enter the {i + 1}st student's full name: ");
    }

    else if (i == 1)
    {
        Console.Write($"Please enter the {i + 1}nd student's full name: ");
    }

    else if (i == 2)
    {
        Console.Write($"Please enter the {i + 1}rd student's full name: ");
    }

    else
    {
        Console.Write($"Please enter the {i + 1}th student's full name: ");
    } 
    names[i] = Console.ReadLine();
}



string[] userNames = MakeUserNameList(names);
int[] studentId = MakeStudentIds(names.Length);
int[] studentLockers = MakeStudentLockers(names.Length);

int userChoice;

do{
DisplayAllStudents(names);
System.Console.WriteLine("Which student would you like to see more information on? ");
userChoice = Convert.ToInt32(Console.ReadLine());

if(userChoice != -1)
    {
        DisplaySpecificStudentInformation(names, userNames, studentId, studentLockers, userChoice);
    }
}while(userChoice != -1);

static void DisplayAllStudents(string[] names)
{
    for(int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine($" {i = 1}. {names[i]}");
    }
}

static void DisplayStudentInformation(string[] names, string[] userNames, int[] studentId, int[] studentLockers)
{
for(int i = 0; i < names.Length; i++)
{
    System.Console.WriteLine(names[i]);
    System.Console.WriteLine(userNames[i]);
    System.Console.WriteLine(studentId[i]);
    System.Console.WriteLine(studentLockers);
}
}

static void DisplaySpecificStudentInformation(string[] names, string[] userNames, int[] studentId, int[] studentLockers, int location)
{
    System.Console.WriteLine(names[location - 1]);
    System.Console.WriteLine(userNames[location - 1]);
    System.Console.WriteLine(studentId[location - 1]);
    System.Console.WriteLine(studentLockers[location - 1]);
}

static int[] MakeStudentIds(int number)
{
    Random rng = new Random();
    int[] studentIds = new int[number];

    for(int i = 0; i < number; i++)
    {
        studentIds[i] = rng.Next(10000, 1000000);
    }
    
    return studentIds;
}

static int[] MakeStudentLockers(int number)
{
    Random rng = new Random();
    int[] studentLockers = new int[number];

    for(int i = 0; i < number; i++)
    {
        studentLockers[i] = rng.Next(1, 501);
    }
    
    return studentLockers;
}


static string[] MakeUserNameList(string[] names)
{

string[] userNames = new string[names.Length];

for(int i = 0; i < names.Length; i++)
{
    string[] splitUpName = names[i].Split(' ');
    userNames[i] = MakeUserName(splitUpName[0], splitUpName[1]);
}


static string MakeUserName(string firstName, string lastName)
{
    string userName = firstName.ToLower().Trim()[0].ToString();
    userName += lastName.ToLower().Trim();

    return userName;
}

return userNames;

}