// Write output to console and use of variables
Console.WriteLine("Hello World");
string name = "John";
int age;
age = 22;
Console.WriteLine("There was a man, named " + name);
Console.WriteLine("He is " + age);
name = "Mike";
age = 33;
Console.WriteLine("Now his name is " + name);
Console.WriteLine("and hes " + age);

// Data types
string phrase = "What do you want?";
char grade = 'A';  // use single quotes with Char (only single characters in char)
int number = 0; //number doesnt need quotes also can be negative number
double gpa = 3.2; //use decimal when precision needed also when using whole number you need to have .0 like 3.0
bool isMale = false; //classic boolean no explanation readed

// Strings

Console.WriteLine("Hello\nWorld");  //new line character \n
Console.WriteLine("QuoationMark\"test"); //prints out quation Mark
string phrase = "This is text" + "this is joined to text"; // you can add values to your strings with + sign
Console.WriteLine(phrase);  //prints out phrase value
Console.WriteLine(phrase.Length); // Length method will tell you how many characters there are inside your string (methods are called with . )
Console.WriteLine(phrase[0]); //positional index - starts with 0 not 1 
Console.WriteLine(phrase.Substring(8, 3)); // takes string starting from position 8 index for next 3 characters

// Working with numbers

Console.WriteLine(5 + 8); // prints out result 
Console.WriteLine(4 + 2 * 3); // Multiplication will takes 1st you can control order with aprethesis (4+2)*3 will result as 6*3
Console.WriteLine();

// Building Calculator


