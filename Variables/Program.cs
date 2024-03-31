//To create a variable, you must specify the type and assign it a value
//type variableName = value;

/*
Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). 
The equal sign is used to assign values to the variable.
To create a variable that should store text, look at the following example:
Create a variable called name of type string and assign it the value "John":
*/
using Microsoft.VisualBasic;

string name = "John";
Console.WriteLine(name);


/*
To create a variable that should store a number -
Create a variable called myNum of type int and assign it the value 15:
*/
int myNum = 15;
Console.WriteLine(myNum);


//you can also declare a variable without assigning the value, and assign the value later:
int myNum1;
myNum1 = 25;
Console.WriteLine(myNum1);


//Note that if you assign a new value to an existing variable, it will overwrite the previous value:
//change the value of myNum to 20:
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);


//A demonstration of how to declare variables of other types:

int myNum2 = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

Console.WriteLine(myNum2);
Console.WriteLine(myDoubleNum);
Console.WriteLine(myLetter);
Console.WriteLine(myBool);
Console.WriteLine(myText);


/*
Constants
If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
This will declare the variable as "constant", which means unchangeable and read-only:
ExampleGet your own C# Server
*/

//
//const int myNum3 = 15;
//myNum3 = 20; // error



/*
The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

Note: You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.*/


/*
The WriteLine() method is often used to display variable values to the console window.
To combine both text and a variable, use the + character:
*/

Console.WriteLine("Hello " + name);