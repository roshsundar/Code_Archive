/** The program is a simple demonstration of the difference between global variables and local variables */


#include <stdio.h>
#include <stdlib.h>

int global1 = 10; /** This variable is global because it is not in any function */

int main()
{
    int local1 = 5; /** This variable is local because it is part of a function, main() */

    printf("Global 1: %d\n", global1); /** Prints the first global variable */
    printf("Local  1: %d\n\n", local1); /** Prints the first local variable */

    printAgain(); /** Call the function */

    return 0;
}


int global2 = 18; /** This variable is also global, it is not part of any function */

int printAgain()
{
    int local2 = 9; /** This is also local because its part of the function printAgain() */

    /** You could not print local1 here because it is local to main() */
    printf("Global 1: %d\n", global1);
    printf("Global 2: %d\n", global2);
    printf("Local  2: %d\n", local2);

    return;
}
