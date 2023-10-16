// #region Example 6 Logical Operators
Console.WriteLine("#region Example 6 Logical Operators");
uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
uint c1 = a1 & b1;
Console.WriteLine(Convert.ToString(c1, toBase: 2));
//output 
// 10011000

uint oROperation = a1 | b1;
Console.WriteLine(Convert.ToString(oROperation, toBase: 2));

uint XorOperation = a1 ^ b1;
Console.WriteLine(Convert.ToString(XorOperation, toBase: 2));
