
/** This program uses the dereferencing operator to point to a variable */

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num;
    int *pNum; /** This will point to num */
               /** NOTE: the pointer and the variable being pointed to both have to be the same type. EX: int and int */

    num = 3; /** Give a value to age */

    pNum = &num; /** This wires the variables together (links the pointer) */

    printf("The variable num is %d.\n", *pNum); /** The printf uses the pointer pNum to get num rather than directly printing num */

    return 0;
}
