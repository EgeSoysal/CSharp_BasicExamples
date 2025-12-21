string permission = "Admin|Manager";
// The "permission" uses the "level" combination to apply business rules
int level = 55;
// Your application will use the permission business rules and the level combination to evaluate in this testing scenario. The full list of business rule conditions will be specified in the next step. Your completed solution must use permission and level.

// You need to use the Contains() helper method on permission to determine if the assigned value in the string contains any of the permission values specified by "business rules". For example, when using the first data values specified in the code above, the expression permission.Contains("Admin") will return true.

// Business Rules your solution must meet:

// #1 If the user is an Admin with a level greater than 55, output this message:
// Output: Welcome, Super Admin user.

// #2 If the user is an Admin with a level of 55 or less, output this message:
// Output: Welcome, Admin user.

// #3 If the user is an Admin with a level of 20 or greater, output this message:
// Output: Contact an Admin for access.

// #4 If the user is an Admin with a level less than 20, output this message:
// Output: You do not have sufficient privileges.

// #5 If the user is neither an Admin nor a Manager, output this message:
// Output: You do not have sufficient privileges.

if ((level > 55) && permission.Contains("Admin|Manager"))
{
    Console.WriteLine("Welcome, Super Admin User.");
}
else if ((level <= 55) && permission.Contains("Admin|Manager"))
{
    Console.WriteLine("Welcome, Admin User.");
}
else if ((level >= 20) && permission.Contains("Admin|Manager"))
{
    Console.WriteLine("Contact an Admin for Access.");
}
else if ((level < 20) && !permission.Contains("Admin|Manager"))
{
    Console.WriteLine("Contact an Admin for Access.");
}
else if ((level < 20) && permission.Contains("Admin|Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if (!permission.Contains("Admin|Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}

