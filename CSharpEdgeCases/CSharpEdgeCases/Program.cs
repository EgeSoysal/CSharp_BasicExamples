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
#region Case - 11 





    
