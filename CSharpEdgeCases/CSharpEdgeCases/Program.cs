#region Case - 1 String & Int Concatenation Trap
//Case Output: 24

//Case Answer

int first = 2;
string second = "4";

// When you use + with a string, C# performs string concatenation
string result = first + second;
Console.WriteLine(result);

// Explanation:
// Even though `first` is an int, `second` is a string.
// C# converts `first` to string automatically and concatenates.
// This is NOT numeric addition.
#endregion

#region Case - 2 Implicit vs Explicit Type Conversion
/* Case OutPut: 
int: 3
decimal: 3
*/

//Case Answer
int myInt = 3;
decimal myDecimal = myInt;
Console.WriteLine($"int: {myInt}");
Console.WriteLine($"decimal: {myDecimal}");

// Explanation:
// This is an implicit (widening) conversion.
// Every int value safely fits into a decimal.
#endregion

#region Case - 3 Explicit Cast Causes Data Loss
/*Case Output:
decimal: 3.14
int: 3
 */

//Case Answer:
decimal myDecimal = 3.14m;
int myInt = (int)myDecimal;

Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"int: {myInt}");

// Explanation:
// Casting from decimal to int truncates the value.
// The fractional part is completely removed.
#endregion

#region Case - 4 Cast vs Convert Difference
/*Case Output:
5
6
*/

//Case Answer: 
int castResult = (int)5.5m;
int convertResult = Convert.ToInt32(5.5m);

Console.WriteLine(castResult);
Console.WriteLine(convertResult);

// Explanation:
// Casting simply removes the decimal part.
// Convert.ToInt32 rounds the number to the nearest integer.
#endregion

#region Case - 5 Safe String to Number Conversion
//Case Output: Measurement: 102

//Case Answer:
string value = "102";
int result;

if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Explanation:
// TryParse does not throw exceptions.
// It returns false if conversion fails.
#endregion

#region Case - 6 Mixed Data Processing (Numbers + Text)
/* Case Output:
Message: ABCDEF
Total: 68.3
*/

//Case Answer:
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;

    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

// Explanation:
// Numeric values are summed.
// Alphabetic values are concatenated.
// This simulates real-world unreliable input.
#endregion

#region Case - 7 Array Sorting and Reversing
/* Case Output: 
A11
A13
B12
B14
*/

//Case Answer: 
string[] pallets = { "B14", "A11", "B12", "A13" };

Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine(pallet);
}

// Explanation:
// Array.Sort performs alphanumeric sorting.
// Letters are sorted first, then numbers.
#endregion

#region Case - 8 Clearing Array Without Breaking Structure
/* Case Output:
0
0
0
*/

//Case Answer:
int[] numbers = { 10, 31, 52 };

Array.Clear(numbers, 0, numbers.Length);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Explanation:
// Array.Clear does NOT remove elements.
// It resets them to default values.
#endregion

#region Case - 9 Order Validation with Error Detection
/* Case OutPut: 
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
*/

//Case Answer:
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');

Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

// Explanation:
// Valid codes must be exactly 4 characters.
// Invalid entries are flagged instead of crashing the program.
#endregion

#region Case - 10 Financial Formatting & Report Output
// Case Problem: Generate a formatted financial comparison reports.

//Case Answer: 
string customerName = "Ms. Aykız Tırpan";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.");
Console.WriteLine($"Your potential profit would be {newProfit:C}.");

// Explanation:
// N = number formatting
// P = percentage
// C = currency
// Used for clean and professional output
#endregion

#region 🚨 ALERT 🚨 HARDCORE 🚨 CASE: Handling Mixed Data, Type Conversions, Arrays and Formatted Output in a Single Flow
//----------------------------------------------------------

/* CASE INFOS:
 * All incoming data is initially string-based
 * Some values are numeric, some are text
 * I need to:
   Convert data safely
   Avoid run time crashes
   Handle Precision corretly
   work with arrays
   validate values
   Produce clean, professional output
The goal is not just to make it work, but to understand:
* which data type to use
* when conversion causes data loss
* how formatting affects output

//----------------------------------------------------------

CASE APPROACH:
* I treat all external data as untrusted
* I use TryParse instead of Parse
* I use decimal for financial values
* I keep array structure intact
* I format output for humans, not machines
*/

//Case Answer:

// STEP 1:
// Incoming data stream (simulating external input)
// Everything arrives as string
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(',');

        // STEP 2:
        // Sort orders alphanumerically
        // This helps detect invalid patterns more clearly
        Array.Sort(orders);

        // STEP 3:
        // Financial and numeric tracking
        decimal totalNumericValue = 0m;
        string invalidOrdersMessage = "";

        // STEP 4:
        // Loop through each order safely
        foreach (string order in orders)
        {
            // Rule:
            // A valid order must be exactly 4 characters
            if (order.Length == 4)
            {
                Console.WriteLine(order);

                // Extract numeric part of the order (example: B123 -> 123)
                string numericPart = order.Substring(1);

                // Try converting numeric part safely
                if (decimal.TryParse(numericPart, out decimal number))
                {
                    // decimal is used to avoid precision issues
                    totalNumericValue += number;
                }
            }
            else
            {
                // Invalid data is NOT ignored
                // It is logged clearly
                Console.WriteLine(order + "\t- Error");
                invalidOrdersMessage += order + " ";
            }
        }

        Console.WriteLine();

        // STEP 5:
        // Demonstrate conversion behavior differences
        decimal preciseValue = 5.5m;

        int castResult = (int)preciseValue;              // Truncates
        int convertResult = Convert.ToInt32(preciseValue); // Rounds

        Console.WriteLine($"Casting result: {castResult}");
        Console.WriteLine($"Convert result: {convertResult}");

        Console.WriteLine();

        // STEP 6:
        // Financial formatting example
        decimal profit = totalNumericValue * 1000;

        Console.WriteLine($"Total numeric value: {totalNumericValue:N}");
        Console.WriteLine($"Estimated profit: {profit:C}");

        Console.WriteLine();

        // STEP 7:
        // Demonstrating array clearing without breaking structure
        int[] sampleNumbers = { 10, 31, 52 };

        // This resets values but keeps array size
        Array.Clear(sampleNumbers, 0, sampleNumbers.Length);

        Console.WriteLine("Cleared array values:");
        foreach (int number in sampleNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        // STEP 8:
        // Final message formatting using interpolation
        Console.WriteLine($"Invalid orders detected: {invalidOrdersMessage}");

/* EXPECTED CASE OUTPUT:
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error

Casting result: 5
Convert result: 6

Total numeric value: 1,053
Estimated profit: $1,053,000.00

Cleared array values:
0
0
0

Invalid orders detected: C15 G3003
*/

#endregion
#region Case - 11 IndexOf() basic usage

// Case Answer
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition); // (index of opening parenthesis)
Console.WriteLine(closingPosition); // (index of closing parenthesis)

/* Case Output:
13
36
*/
#endregion

#region Case - 12 Substring() Without Skipping Opening Symbol

// Case Answer
string message= "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); // (includes '(')

/* Case Output:
(inside the parentheses
*/
#endregion 

#region Case - 13 Substring() skipping '(' Corretly

// Case Answer
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1; // (skip '(')

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

/* Case Output:
inside the parentheses
*/
#endregion

#region Case - 14 Extract text between <span> tags (hardcoded length)

// Case Answer
    
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6; // (length of "<span>")
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

/* Case Output:
between the tags
*/
#endregion

#region Case - 15 IndexOfAny() with multiple opening symbols

// Case Answer

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

/* Case Output:
What if
different symbols
open symbol
matching closing symbol
*/
#endregion

#region Case - 16 Remove() method

// Case Answer

string data = "123ruhi    Çenet123";

string updatedData = data.Remove(3, 13);
Console.WriteLine(updatedData);

/* Case Output
123123
*/
#endregion    

#region Case - 17 Replace()

// Case Answer
    
string message = "This--is--ex-amp-le--da-ta";

message = message.Replace("--", " ");
message = message.Replace("-", "");

Console.WriteLine(message);

/* Case Output: 
This is example data
*/
#endregion

#region Case - 18 Extraction, Replace and Remove Task

// Case Answer

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;

quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";

output = input.Replace(tradeSymbol, regSymbol);

const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);

output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

/* Case Output
Quantity: 5000
Output: <div><h2>Widgets &reg;</h2><span>5000</span>
*/
#endregion
