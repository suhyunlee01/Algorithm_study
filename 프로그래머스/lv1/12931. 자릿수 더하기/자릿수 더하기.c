#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int sum = 0;
    int a = 0;
    
    while(n > 0){
        a = n % 10;
        n = n / 10;
        sum = sum + a;
    } return sum;
}