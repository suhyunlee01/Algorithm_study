#include <stdio.h>

int main(void) {
    int a; //가로
    int b; //세로
    scanf("%d %d", &a, &b);
    
    for(int i = 0; i < b; i++){
            for(int i = 0; i < a; i++){
                printf("*");
            }printf("\n");
        }
}