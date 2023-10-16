//#region Example 5 Shift operators
Console.WriteLine("#region Example 5 Shift operators");
Console.WriteLine("Example-01");

uint shiftOpt=0b_1100_1001_0000_0000_0000_0000_0001_0001;
Console.WriteLine($"Before:{Convert.ToString(shiftOpt, toBase: 2)}");

uint y = shiftOpt << 4;
Console.WriteLine($"After:{Convert.ToString(y, toBase: 2)}");


// Before: 11001001000000000000000000010001
// After: 10010000000000000000000100010000


