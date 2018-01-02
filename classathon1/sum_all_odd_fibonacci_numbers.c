#include <stdio.h>
#include <cs50.h>

int main (void)
{
    int num = get_int("what would you like to see sum of all off fibonacci: ");
    int prevNumber = 0;
    int currNumber = 1;
    int result = 0;

    while (currNumber <= num)
    {
        if((currNumber%2) != 0)
        {
            result = result + currNumber;
        }

        currNumber = currNumber + prevNumber;
        prevNumber = currNumber - prevNumber;
    }

    printf("Sum of all odd fibonacci numbers: %i \n",result);
}