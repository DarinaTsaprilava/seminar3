/*string name1 = "Bob";
string name2 = "Liz";
string name3 = "Sarha";
string name4 = "Jonh";
string name5 = "Ann";
*/
//string[] names = { "Bob", "Liz", "Sarha", "Jonh", "Ann" };
//Console.WriteLine(names[3]);

//names[3] = Console.ReadLine(); 
//Console.WriteLine($"Новое имя {names[3]}");

/*for (int i = 0; i < 5; i++)
{
    Console.WriteLine(names[i]);
}
*/

Console.WriteLine("Введите кол-во чисел:");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1,100);
}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]}; ");
}