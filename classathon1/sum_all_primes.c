#include <stdio.h>
#include <cs50.h>

int isPrime(int n);

int main (void){
    int num = get_int("Sum of all primes ends: ");
    int sum = 0;
    for(int i = 2; i <= num; i++){
        if(isPrime(i) == true){
            sum = sum + i;
        }
    }
    printf("sum of all primes up to %i is %i \n",num,sum);
}



int isPrime(int num){
    for(int i = 2; i <= num; i++){
        if((num % i) == 0 && num != i){
            return false;
        }
    }
    return true;
}