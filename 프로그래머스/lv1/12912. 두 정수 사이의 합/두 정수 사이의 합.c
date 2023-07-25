#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

long long solution(int a, int b) {
    int small = (a < b) ? a : b;
    int big = (a > b) ? a : b;
    long long sum = 0;
    
    for(int i = small; i <= big; i++){
        sum = sum + i;
    }return sum;
}