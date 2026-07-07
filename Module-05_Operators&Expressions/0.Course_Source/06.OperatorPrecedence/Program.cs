Console.WriteLine("\n::::::::: Discount Calculation :::::::::\n");


decimal productPrice = 200.00m;
decimal discountRate = 0.10m;
decimal taxRate = 0.05m;

// decimal finalAmount = productPrice - productPrice * discountRate + productPrice * taxRate;

decimal discountedPrice = productPrice * discountRate;

decimal taxAmount = productPrice * taxRate;

decimal finalAmount = productPrice - discountedPrice + taxAmount;

Console.WriteLine("----- Invoice -----\n" +
                  "Product Price    : $" + productPrice + "\n" +
                  "Discount         : -$" + discountedPrice + "\n" +
                  "Tax              : +$" + taxAmount + "\n" +
                  "--------------------------------------\n" +
                  "Final Amount     : $" + finalAmount);


// Evaluation Direction

//    • When operators have the same precedence level:
//    • They are evaluated from left to right.

//  Key Rules
//    • Operators have fixed precedence rules.
//    • Parentheses override precedence.
//    • Same-level operators evaluate left to right.
//    • Clear code is better than clever code.

//  Common Mistakes
//    • Assuming expressions execute left to right without precedence.
//    • Writing complex expressions without parentheses.
//    • Ignoring readability in financial calculations.