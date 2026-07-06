//! NOTES:		 `const` defines a (constant) value
//?		- The value must be known at compile time
//?		- The value cannot change after declaration

//! Why Constants?
//*   • Prevent accidental changes
//*   • Replace magic numbers
//*   • Make intent clear 
//*			• It is confusing in the code if you see a number like 30, 50, 100, etc. without any context.
//*			• Like: if (studentGrade = "A") { ... } - What does "A" mean in domain? Is it a grade? Is it a character? Is it a string? Is it a constant? Is it a variable?
//*				• But if we made it clear by using a constant like: ``` const char GradeA = 'A'; ``` - Then it is clear that "A" is a grade and it is a constant value [[const]] that cannot be changed.
//*			• Like: if we have ``` int number = 10 ```; => Intent isn't Clear !! => Is this Age? or Distance? or Count? or Limit? or MaxStudents? or TaxRate? or Price? or Salary? or Grade? or Score? or Level? or Rank? or Index? or ID? or Code? - It is confusing and unclear what this number 10 means in the domain of the program.


//! ========== ALLOWED TYPES FOR CONSTANTS [[const]] ==========
//! Rule: [[const]] can ONLY be used with specific types:
//*		1. Value Types (int, double, char, bool, decimal, etc.)
//*		2. Enum Types
//*		3. String Type (special reference type - allows literal values)
//*		4. Reference Types (ONLY with [[null]] value)

//! --------- All the (const) values below are known at compilation time and cannot be changed after declaration --- So; Compiler can fix the value at compile time in the program! ---------
//? Convention: Use [PascalCase] for constant names



#region (1). Rule: Constant Expression Must Be Constant

//! Rule: The expression being assigned to a constant [[const]] must be constant [[const]] itself.
char gradeB_Var = 'B';
//const char GradeB = gradeB_Var; //* [[Error]]: The expression being assigned to 'GradeB' must be constant
//! Fix - ``` [[const]] = [[const]] ```
const char GradeB = 'B';
const char StudentGrade1 = GradeB;
const char StudentGrade2 = (char)('A' + 1); // 'B' - The expression is constant at compile time

#endregion

#region (2). Value Types (✓ ALLOWED)

Console.WriteLine("\n\n========== CASE 1: Value Types (✓ ALLOWED) ==========");
const int MaxStudents = 30;
const double TaxRate = 0.15;
const char GradeA = 'A';
const bool IsActive = true;
const decimal Price = 99.99m;
Console.WriteLine($"MaxStudents: {MaxStudents}");
Console.WriteLine($"TaxRate: {TaxRate}");
Console.WriteLine($"GradeA: {GradeA}");
Console.WriteLine($"IsActive: {IsActive}");
Console.WriteLine($"Price: {Price}");

#endregion

#region (3). String Type (✓ ALLOWED - Special Reference Type)

Console.WriteLine("\n\n========== CASE 2: String Type (✓ ALLOWED - Special Reference Type) ==========");
//! String is a reference type BUT can store literal values in constants
const string CompanyName = "TechCorp";
const string EmptyString = "";
const string MultiLine = "Line1\nLine2";
Console.WriteLine($"CompanyName: {CompanyName} --  (length: {CompanyName.Length})");
Console.WriteLine($"EmptyString: '{EmptyString}' (length: {EmptyString.Length})");
Console.WriteLine($"MultiLine:\n{MultiLine} --  (length: {MultiLine.Length})");

#endregion

#region (4). Reference Types with [[NULL]] Reference Value ONLY

Console.WriteLine("\n\n========== CASE 3: Reference Types with NULL [[null]] (✓ [const ... = null] is ALLOWED) ==========");

//! You CAN use const with reference types, but ONLY if assigned null
const int[] NullArray = null;
const Exception NullException = null;
const object NullObject = null;

//! [ERROR]: You CANNOT use [[const]] with [reference types] if assigned a value (object instance)
//const object SomeObject = new { Name = "Ahmad" };

Console.WriteLine($"NullArray: {NullArray}");
Console.WriteLine($"NullException: {NullException}");
Console.WriteLine($"NullObject: {NullObject}");


#endregion

#region (5). Reference Types with Values (✗ NOT ALLOWED)

Console.WriteLine("\n\n========== CASE 4: Reference Types with Values (✗ NOT ALLOWED) ==========");


//const int[] Numbers = new int[] { 1, 2, 3 }; //* [[Error]]: A constant cannot be of type 'int[]'


//const List<int> MyList = new List<int>(); //* [[Error]]: A constant cannot be of type 'List<int>'


//const object MyObject = new object(); //* [[Error]]: A constant cannot be of type 'object' (Reference type instances CANNOT be constants)


//! Reason: The [compiler] cannot embed object [references] at [[compile time]]
Console.WriteLine("// Reference type instances CANNOT be constants");


#endregion

#region (6). Enum Types (✓ ALLOWED)

Console.WriteLine("\n\n========== CASE 5: Enum Types (✓ ALLOWED) ==========");

const Season CurrentSeason = Season.Summer;

Console.WriteLine($"CurrentSeason: {CurrentSeason}");

#endregion

#region RULES: Some Errors to Avoid: [1. No Modification of [const], 2. 'var' keyword is NOT compatible with 'const'

Console.WriteLine("\n========== RULE: Constants CANNOT Be Modified ==========");

//IsActive = false; //* [[Error]]: The left-hand side of an assignment must be a [[variable]], [[property]] or [[indexer]]
//MaxStudents = 50; //* [[Error]]: A constant [[const]] value cannot be modified

Console.WriteLine("// Once assigned, [[const]] values are [[IMMUTABLE]]");

Console.WriteLine("\n========== WRONG: Using 'var' with const (✗ NOT ALLOWED) ==========");

//const var limit = 50; //* [[Error]]: The type of a constant must be a value type, enum type, or string type.
//! Reason: 'var' cannot be used with const - the type MUST be explicitly specified
Console.WriteLine("// 'var' keyword is NOT compatible with 'const' - always use explicit type");

#endregion

#region Summary Table

Console.WriteLine("\n========== SUMMARY TABLE ==========");
Console.WriteLine("Type Category          | Can Use const | Notes");
Console.WriteLine("---------------------- | ------------- | ----");
Console.WriteLine("Value Types (int, etc) | ✓ YES         | All primitive types allowed");
Console.WriteLine("String                 | ✓ YES         | Special reference type - literals allowed"); //! يُسمح بالقيم الحرفية 
Console.WriteLine("Enum                   | ✓ YES         | Enum members are constants");
Console.WriteLine("Reference Types (null) | ✓ YES         | Only [[null]] value allowed");
Console.WriteLine("Reference Types (obj)  | ✗ NO          | Cannot embed object instances");
Console.WriteLine("var keyword            | ✗ NO          | Must specify explicit type");


#endregion


//! Type declarations (Enums or Classes or Structs or Interfaces, ... etc.) MUST come AFTER all executable statements in top-level programs
enum Season { Spring, Summer, Fall, Winter }
