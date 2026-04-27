#include <stdio.h>
#include <string.h>
int main()
{
    int l;
    scanf("%d",&l);
    for (int i=0;i<l;i++){
        for (int j=i;j<l-1;j++){
            printf(" ");
        }
        for(int j=0;j<=i;j++){
            printf("*");
        }
        printf("\n");
    }


    return 0;
}