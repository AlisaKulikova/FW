string[] array = { };
Console.WriteLine("Enter an array elements separated by SPASE end press 'ENTER':");
string s = Console.ReadLine();
char[] separator = new char[] {' '};
array = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);