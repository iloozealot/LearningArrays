
//0-based counting - 0,1,2,3,4,5

//string[] firstNames = new string[6];

//firstNames[0] = "Justin";
//firstNames[1] = "Amanda";
//firstNames[2] = "Sebastian";
//firstNames[3] = "Killian";
//firstNames[4] = "Rory";
//firstNames[5] = "Cinnamon";

//Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}");// etc...

//single quote identifies a char

string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

Console.WriteLine(firstNames[1]);

Console.WriteLine(firstNames.Length);

string[] lastNames = new string[] { "Corey", "Smith", "Jones" };

int[] ages = new int[] { 2, 3, 4 };