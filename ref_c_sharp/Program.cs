//we create a method where made a condition for ref
void PracticeWithRef(ref int num)
{
    //ref will add 1 to the original number
    num++;
    Console.WriteLine($"Number in method: {num}");
}

//our original number 'before' using ref
int beforeAfter = 7;
Console.WriteLine($"Number before method: {beforeAfter}");

//our original number 'after' using ref
PracticeWithRef(ref beforeAfter);
Console.WriteLine($"Number after method: {beforeAfter}");
