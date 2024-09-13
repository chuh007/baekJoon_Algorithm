#include <stdio.h>
#include <string.h>
int main()
{
    
    int a;
    int howP;
    char str[21];
    scanf("%d",&a);
    for (int i=0;i<a;i++){
        scanf("%d",&howP);
        scanf("%s",str);
        for (int j=0;j<strlen(str);j++){
            for (int k=0;k<howP;k++){
                printf("%c",str[j]);
            }
        }
        printf("\n");
    }

    return 0;
}