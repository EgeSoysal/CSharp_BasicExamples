🚀 C# BASIC EXAMPLES-LEARNING PROJECT COLLECTION
---
Welcome to the C# Basic Examples repository a complete learning resource designed for beginners who want to practice and understand core C# programming concepts through clean, simple, and functional console applications.

This repository is perfect for:
---
✔️ Students
✔️ Programming beginners
✔️ Anyone learning C# fundamentals
✔️ Anyone preparing for exams or practice sessions

Each folder contains independent examples, all written with clarity and comments to help you learn step-by-step.

📁 PROJECT STRUCTURE
---
Below is a full breakdown of all folders currently in this repository:

📌 Digit_Extraction_and_Sum_Calculator_in_C#
---
A program that:
* Takes a three-digit number from the user
* Extracts the hundreds, tens, and ones digits
* Displays each digit separately
* Calculates and prints the sum of all digits

Great for learning:
* Modulus (%)
* Division
* Basic number manipulation

📌 For&While_Example
---
A set of examples demonstrating:
* for loops (counting, repeating actions, controlled iteration)
* while loops (condition-based repetition)
* User & driven loops
* Practical usage of loop logic

Helpful for understanding how repetition works in C# programs.

📌 If_&_Else_Examples
---
Covers conditional statements using:
* if
* else if
* else
* Logical operators (&&, ||, !)

Includes examples such as:

* Score/grade evaluation
* City validation
* Password & username checks
* Value comparison scenarios

Perfect for mastering decision-making structures.

📌 Independent_Sample_Structures
---
A collection of standalone mini-programs focused on algorithmic thinking.
Each example is self_contained and demonstrates specific logic concepts such as:
* Basic calculations
* Input/output formatting
* Small simulations
* Logical decision structures
Excellent for practicing without relying on external code.

📌 IntDoubleCharString
---
Examples demonstrating the most important data types in C#:
* int(integers)
* double(decimal numbers)
* char(single characters)
* string(text values)

You will learn:
* Declaring variables
* Reading user input
* Type conversion
* Printing formatted output
* Performing arithmetic operations

📌 Mod_Usage_Examples
---
Shows how to use the modulus operator (%) effectively.

Examples include:
* Calculating remainders
* Checking even/odd numbers
* Math-based logic problems
* Divisibility conditions
A key concept for algorithmic problem solving.

📌 Parse_Examples
---
Focuses on converting user input from string to numeric types, including:
* int.Parse()
* double.Parse()
* char.Parse()
* Use cases for input validation
Essential for any program that accepts user input.

📌 Methods_Examples
---
This folder teaches how to use methods effectively in C#.

Covered method types include:

✔️ Void Methods
Simple actions with no return value
(e.g., printing a customer list)

✔️ Methods with Parameters
Passing values into methods
(string, int, etc.)

✔️ Return-Type Methods
Returning information back to the caller
(string returns, integer returns)

✔️ Realistic Examples
Such as an exam average calculator that returns a pass/fail message

This module helps you understand:
* Reusability
* Clean code structure
* Input/output handling
* How real applications structure logic using methods

📌 Foreach_Examples 
---
Includes examples showing how to use the foreach loop with arrays and lists.
Covers:
* Iterating through color and number arrays
* Printing only even numbers
* Reading characters from a List<char>
* A mid level project: International Student Evaluation System, where SAT, ACT, and TOEFL scores are taken, normalized, averaged, and evaluated.

📌 SQL-CSharp-ProductManagement_BasicLevel 
A simple console application project demonstrating CRUD operations (Create, Read, Update, Delete) for food products and categories using C# and SQL Server. Perfect for learning how C# interacts with a database and practicing real-world application logic.

This project includes:
---
* Adding new food categories
* Adding new food products
* Listing all products
* Updating product information
* Deleting products

The project demonstrates usage of SqlConnection, SqlCommand, and SqlDataAdapter for database operations in C#.

---

### Step-by-Step SQL Database Setup

#### 1️⃣ Create the Database
---
```sql
CREATE DATABASE FoodOrderDb;
USE FoodOrderDb;
```
#### 2️⃣ Create Categories Table
---
```sql
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100)
);
```

####3️⃣ Create Products Table
---
```sql
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100),
    ProductPrice DECIMAL(10,2),
    ProductStatus BIT,         -- 1 = active, 0 = inactive
    CategoryID INT NULL
);
```

#### 4️⃣ Insert Sample Data (Optional)
---
```sql
INSERT INTO Categories (CategoryName) VALUES ('Main Dishes');
INSERT INTO Categories (CategoryName) VALUES ('Desserts');

INSERT INTO Products (ProductName, ProductPrice, ProductStatus, CategoryID)
VALUES ('Chicken Kebab', 185, 1, 1);

INSERT INTO Products (ProductName, ProductPrice, ProductStatus, CategoryID)
VALUES ('Chocolate Cake', 120, 1, 2);
```

#### 5️⃣ Listing Data
---
```sql
SELECT * FROM Products;
SELECT * FROM Categories;

-- Join example
SELECT P.ProductID, P.ProductName, P.ProductPrice, C.CategoryName
FROM Products P
LEFT JOIN Categories C ON P.CategoryID = C.CategoryID;
```

#### 6️⃣ Updating Data
---
```sql
UPDATE Products
SET ProductName = 'Beef Burger', ProductPrice = 195
WHERE ProductID = 1;
```

#### 7️⃣ Deleting Data
---
```sql
DELETE FROM Products WHERE ProductID = 2;
DELETE FROM Categories WHERE CategoryID = 2;
```
Learning Outcomes
---
* Learn how to create and connect to a SQL Server database
* Perform CRUD operations in SQL using C#
* Use SqlCommand parameters safely
* Display and manipulate database records in a console application
* Structure a simple, practical C# project

This project is a basic-level introduction to database-driven C# applications and is fully compatible with Visual Studio Community Edition or VS Code.

📌 Student_Grade_Calculator 
---
A simple console application project for calculating students' exam averages, overall grades, and letter grades. This project also handles extra credit points and prints a formatted grade report.

This project includes:
---
* Storing student names and their exam/extra credit scores
* Calculating exam average
* Adding extra credit to compute overall grade
* Assigning letter grades automatically
* Displaying all results in a neat console table

Great for:
* Practicing arrays and loops (foreach)
* Understanding conditional statements for letter grades
* Learning basic console input/output and formatting
* Beginner-level C# practice

📌 Boolean_Permission_Evaluator ⭐ Newly Added
---
A beginner-friendly console application demonstrating **boolean-based access control** in C#.

This project includes:
---
* Role validation using string permissions
* Access level checks with boolean expressions
* Usage of `&&`, `||`, and `!`
* `if / else if / else` decision structures
* Console outputs based on business rules

Great for learning:
---
* Boolean logic
* Conditional statements
* Role-based access control fundamentals

📌 CSharpEdgeCases ⭐ Newly Added
---
A collection of 11 C# edge cases focused on confusing and non-obvious behaviors that beginners often struggle with.

Each case includes:
---
* Clearly titled case scenarios (Case 1 – Case 11)
* Well-commented C# code
* Explanation-focused solutions
* Expected output at the end of each case



🎯 PURPOSE OF THIS REPOSITORY
---
This project exists to help beginners:

✔️ Understand fundamental coding concepts
✔️ Practice real console applications
✔️ Build algorithmic thinking
✔️ Learn how data types and conditions work
✔️ Strengthen C# skills through hands-on examples
✔️ Gain confidence by running working code


Every file is clean, simple, and well-documented.


⚡ HOW TO USE
---
1) Clone or download the repository
2) Open any folder in Visual Studio, VS Code, Rider, or similar
3) Run the program
4) Study the code and modify it to practice
5) Build your own examples based on the structure

⭐ HIGHLIGHTED PROJECT — SQL-CSharp-ProductManagement_BasicLevel
---
Located in:

📂 SQL-CSharp-ProductManagement_BasicLevel
---
This program teaches:
* How to create and connect to a SQL Server database
* Performing CRUD operations (Create, Read, Update, Delete) using C#
* Adding and managing food categories
* Adding, listing, updating, and deleting food products
* Using `SqlConnection`, `SqlCommand`, and `SqlDataAdapter` for database operations
* Structuring a simple, practical console application

  
📜 LICENSE
---
This repository is distributed under the MIT License.
