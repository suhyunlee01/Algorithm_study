#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int sum = 0;
    for(int yaksu = 1; n>=yaksu; yaksu++){
        if(n % yaksu == 0){
         sum = sum + yaksu;   
        }
    }return sum;
}