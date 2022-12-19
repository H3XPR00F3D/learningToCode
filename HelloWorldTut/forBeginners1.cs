/* LESSON 2 VARIABLES
// Variables
// Create, Read, Update, Delete Data : CRUD
//

// Textbook Definition - Names given to data we need to store in memory.

var testVar = "noob";
int a = 99; //-2,147,483,648 +2,147,483,648 cannot be a decimal
string b = "abc"; // always treated as 'text'. Letters on a page
byte c = 255; // numeral between 0-255
char d = 'a';
double testDouble = 14.43; // 5.0x10^308 4.1111111111111111111111111
float testFloat = 0.11156154f; // 5.0x10^38 4.1111111111
decimal testDecimal = .1212121m; // 28 digits of precision 4.1111111111111111111111111111

double testVariable = (1 - 2) * ((6 / 2) + 4);

 +=
 -=
 *=

int learnVariables = 1;
learnVariables += 1;


Console.WriteLine(testVar);
Console.WriteLine(testVariable);
Console.WriteLine(learnVariables);
Console.WriteLine("Goodbye World");
*/
/* LESSON 3 TYPE CASTING

 Converting data after it has been assigned at compilation
 Implicit & Explicit

----------------------------------------------------------------------------

double x = 1234.7;
int a;
// cast double to int
a = (int)x;
Console.WriteLine(a);

string value = "lasdflalsdjflasdlfjlasdjflajsldfjla5skjdf";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine("Success: " + result);
}
else
{
    Console.WriteLine("Failure");
}

// Stack is for value type and a Heap is for reference types.
*/
/* LESSON 4 STACK HEAP
  
// Stack is for value type and a Heap is for Reference types
using HelloWorldTut;

----------------------------------------------------------
int testValue = 4;
byte lowLevelValue = 3;
bool boolValue = false;
string stringValue = "String";

StackHeapExample stackHeap = new StackHeapExample();

stackHeap.AddFive(1);

*/
/* LESSON 5 ARRAYS

// Array - Collection of fixed sets of values
   Fixed vs Dynamic

--------------------------------------------------------------------
// FIXED ARRAYS:

int[] vs = new int[5];

string[] vs1 = new string[2];

object[] vs3 = new object[4];

vs[0] = 1;

vs1[0] = ("Hello World");
vs1[1] = ("This is a test for Arrays");

Console.WriteLine(vs[0]);
Console.WriteLine(vs1[0]);



// Dynamic ARRAYS

int[] staticIntArray = new int[] { 1, 2, 3, 4, 5 };

Array.Sort(staticIntArray);
staticIntArray.Average();

//Linq
//Array



Console.WriteLine(staticIntArray);

*/
/* LESSON 6 BUILD SIMPLE NETWORK TOOL
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


using System;
namespace Tutorialling
{
    internal class Networkenin
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}

*/