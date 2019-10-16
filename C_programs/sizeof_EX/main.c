
/**NOTES
 * sizeof() can be used to find the number of memory locations it takes to store values of any data type and it works
 * on variables as well as data types.
 *
 * EX:
 *  i = sizeof(int); // Puts the size of integers into i
 *  f = sizeof(float); // Puts the size of floats into f
 **/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    char *name = "gordon";
    int i = 7;

    printf("The size of 'i' is %d.\n", sizeof(i));
    printf("the size of 'name' is %d.\n", sizeof(name));

    return 0;
}
