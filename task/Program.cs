string[] array = { };
Console.WriteLine("Enter an array elements separated by SPASE end press 'ENTER':");
string s = Console.ReadLine();
char[] separator = new char[] {' '};
array = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
void Newarray(string[] newarray)
{
    Console.WriteLine("New array:");
  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[i] = array[i];
            Console.Write(newarray[i] + "  ");
        }
    }
}
Console.WriteLine();
Newarray(array);
