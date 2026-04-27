#include <stdio.h>
#include <string.h>
int main()
{
    int b;
    int an=0;
    int anN = 0;
    for (int i=0;i<9;i++){
        scanf("%d",&b);
        if (an<b){
            an=b;
            anN=i+1;
        }
    }
    printf("%d\n",an);
    printf("%d",anN);
}