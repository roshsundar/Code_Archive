
/** this program demonstrates passing multiple variables to a function */


/** NOTES
 * Normally, pass non-array variables by value(means that receiving function can use them but not effect their values
 * in the calling function)
 *
 * Arrays are passed by address (means that if receiving function changes them, array variables are changed in calling
 * function)
 *
 * Can pass non-array variables by address by preceding with &, and receive with *
 *
 * Don't pass an array variable by value, C has no way to do that
 */


#include <stdio.h>
#include <stdlib.h>

/** The following statement will be explained in a later example */
changeSome(int i, float *newX, int myArray[5]);

int main()
{
    int i = 10;
    int ctr;
    float x = 20.5;

    int myArray[] = {10, 20, 30, 40, 50};

    puts("Here are main()'s variables before the function:");
    printf("i is %d\n", i);
    printf("x is %.1f\n", x);
    for (ctr = 0; ctr < 5; ctr++)
    {
        printf("myArray[%d] us %d\n", ctr, myArray[ctr]);
    }

    /** Now call the changeSome function, passing the value of i and the address of x (hence, the &) */
    changeSome(i, &x, myArray);

    puts("Here are main()'s variables after the function:");
    printf("i is %d\n", i);
    printf("x is %.1f\n", x);
    for (ctr = 0; ctr < 5; ctr++)
    {
        printf("myArray[%d] us %d\n", ctr, myArray[ctr]);
    }

    return 0;
}


/**************************************************************************************/

changeSome(int i, float *newX, int myArray[5])
{
    /** All variables are changes, but only the float and array remain changed when the program returns to main() */

    /** Changed when the program returns to main() */
    int j;

    i = 47;
    *newX = 97.6; /** Same location as x in main */

    for (j = 0; j < 5; j++)
    {
        myArray[j] = 100 + 100*j;
    }

    return;
}
