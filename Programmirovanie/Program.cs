int i = 1221;
if ((i / 1000 == i % 10) && ((i / 100) % 10 == (i % 100) / 10))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("No");
}