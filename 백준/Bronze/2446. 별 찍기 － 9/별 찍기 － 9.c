#include <stdio.h>

    int main() {
        int a;
        scanf("%d",&a);
        for (int i=0;i<a;i++){
            for(int j = i;j>0;j--){
                if(i!=a-1){
                    printf(" ");
                }
            }
            for(int j = a;j>i+1;j--){
                printf("**");
            }
            if(i!=a-1){
                printf("*");
                printf(("\n"));
            }
        }
        for(int i=0;i<a;i++){
            for(int j=a;j>i+1;j--){
                printf(" ");
            }
            printf("*");
            for(int j=0;j<i;j++){
                printf("**");
            }
            printf(("\n"));
        }
        return 0;
    }