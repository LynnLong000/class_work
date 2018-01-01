#include <stdio.h>
#include <cs50.h>

int main (void)
{

    int num = get_int("number you want factorialized: ");
    long long count = 1;

    for(int i = 1; i <= num; i++)
    {
        count *= i;
    }

    printf("factorialized:%lli \n",count);
}