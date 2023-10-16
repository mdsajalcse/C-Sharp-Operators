//c sharp bitwise shift operator
Console.WriteLine("Shift Operator");

uint m = 0B_1001;
Console.WriteLine($"Before:{Convert.ToString(m, toBase: 2),4}");

uint n = m >> 2;
Console.WriteLine($"After:{Convert.ToString(n, toBase: 2),4}");


