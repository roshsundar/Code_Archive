/** This program demonstrates passing a variable to a function by address */

/** NOTE: when passing with an address - If the receiving function changes one of the variables in the parameter list,
          the calling function's argument changes as well
 */

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;

    printf("Please enter an integer...");
    scanf(" %d", &i);

    /** Now call the half() function, passing the address of i */
    half(&i);

    /** Shows that the function did alter i's value */
    printf("In main(), i is now %d.\n", i);

    return (0); /** Ends the program */
}

/******************************************************************************************************/

/** Putting dividers (like one above) help separate functions (make it look easier to read) */

int half(int *i) /** Receives the address of i */
{
    *i = *i / 2;
    printf("Your value halved is %d.\n", *i);
    return;
}
