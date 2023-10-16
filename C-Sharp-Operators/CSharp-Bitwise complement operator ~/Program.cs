//C # Bitwise operator

Console.WriteLine("#region Example 4 - Bitwise complement operator ~");

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
uint t1 = 0b_1111_0000_1111_0000_1111_0000_1111_0011;
uint b = ~t1;
Console.WriteLine(Convert.ToString(b, toBase: 2));
uint c = ~t;
Console.WriteLine(Convert.ToString(c, toBase: 2));

uint bitwiseCompOpt= 0b_0011_1100_1111_0000_1001_1010_0001_1110;
uint c1 = ~bitwiseCompOpt;
Console.WriteLine(Convert.ToString(c1, toBase: 2));

uint x = 0B_1100_1111_0000_1010_0101_0011_1100_1001;
uint y = ~x;
Console.WriteLine(Convert.ToString(y, toBase: 2));





