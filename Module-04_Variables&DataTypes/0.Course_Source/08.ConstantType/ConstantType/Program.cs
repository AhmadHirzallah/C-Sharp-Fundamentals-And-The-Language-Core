// `const` defines a constant value
// The value must be known at compile time
// The value cannot change after declaration

// Why Constants?
//   • Prevent accidental changes
//   • Replace magic numbers
//   • Make intent clear


const int MaxStudents = 30;
const double TaxRate = 0.15;
const char GradeA = 'A';
const bool IsActive = true;

Console.WriteLine("MaxStudents: " + MaxStudents);
Console.WriteLine("TaxRate: " + TaxRate);
Console.WriteLine("GradeA: " + GradeA);
Console.WriteLine("IsActive: " + IsActive);

// MaxStudents = 40; // ERROR: Constant can not be modified

int limit = 50;
// const int Max = limit; // ERROR: The expression being assigned to 'Max' must be constant

