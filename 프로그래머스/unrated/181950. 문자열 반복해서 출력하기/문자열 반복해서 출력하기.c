#include <stdio.h>
#define LEN_INPUT 11

int main(void) {
    char s1[LEN_INPUT];
    int n = 0;
    int i = 0;
    scanf("%s %d", s1, &n);
    while(i<n){
        printf("%s",s1);
        i++;
    }
    return 0;
}