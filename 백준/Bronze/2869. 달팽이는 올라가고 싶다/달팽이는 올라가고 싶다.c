#include <stdio.h>
#include <string.h>
int main()
{
    int daycount=0;
    int plus=0;
    int minus=0;
    int high=0;
    scanf("%d",&plus);
    scanf("%d",&minus);
    scanf("%d",&high);
    daycount = (high-minus-1)/(plus-minus)+1;

    printf("%d",daycount);
    


    return 0;
}