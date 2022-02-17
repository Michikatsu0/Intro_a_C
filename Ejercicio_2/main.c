#include <stdio.h>
#include <stdlib.h>

void funcPrint(char *pstring){
    printf("%s\n", pstring);
}

int main (){
    funcPrint("Hola mundo Cruel");
    return EXIT_SUCCESS;
}