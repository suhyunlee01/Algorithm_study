#include <stdio.h>

int main(void) {
    int n = 0;
    scanf("%d", &n);
    
    if(n%2==0){
        printf("%d is even", n);
    }else{
        printf("%d is odd", n);
    }

    return 0;
}