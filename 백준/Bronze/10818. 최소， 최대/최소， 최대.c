#include <stdio.h>
#include <string.h>
int main()
{
    int a;
    int b;
    int anMin=1000000;
    int anMax=-1000000;
    scanf("%d",&a);
    for (int i=0;i<a;i++){
        scanf("%d",&b);
        if (anMin>b){
            anMin = b;
        }
        if(anMax<b){
            anMax = b;
        }
    }
    printf("%d %d",anMin,anMax);

    return 0;
}