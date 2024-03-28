//To create a variable, you must specify the type and assign it a value
//type variableName = value;

/*
Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). 
The equal sign is used to assign values to the variable.
To create a variable that should store text, look at the following example:
Create a variable called name of type string and assign it the value "John":
*/
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