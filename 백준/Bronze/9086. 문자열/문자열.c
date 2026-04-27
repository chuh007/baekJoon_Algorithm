#include <stdio.h>
#include <string.h>
int main()
{
    int i;
    char ch[1000];
    scanf("%d",&i);
    for(int j=0;j<i;j++){
        scanf("%s",ch);
        printf("%c%c\n",ch[0],ch[strlen(ch)-1]);
    }


    return 0;
}