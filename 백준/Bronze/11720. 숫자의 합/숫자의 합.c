#include <stdio.h>
#include <string.h>
int main()
{
    int a;
    char c;
    int sum = 0;
    scanf("%d\n",&a);
    for(int i=0;i<a;i++){
        scanf("%c",&c);
        sum+=c-'0';
    }
    printf("%d",sum);

    return 0;
}