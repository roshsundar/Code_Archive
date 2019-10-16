/** NOTES
 * increment operator is: ++
 * decrement operator is: --
 *
 * if you want to add 1 to a variable "count":
 * count++;  ,or, ++count;
 *
 * if you want to subtract 1 from a variable "count":
 * count--;  ,or, --count;
 *
 * Note: if the operator is on the left = prefix increment (or decrement). If on right = postfix increment (or decrement)
 * Note: if the ++ or -- is a prefix, C computes it before anything else on the line. If it's a postfix, it's computed
 *       last
 */


/**
    This program increases a counter from 1 to 5, printing updates then counts it back to 1. However, it uses the
    increment and decrement operators
**/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ctr = 0;

    printf("Counter is at %d.\n", ++ctr);
    printf("Counter is at %d.\n", ++ctr);
    printf("Counter is at %d.\n", ++ctr);
    printf("Counter is at %d.\n", ++ctr);
    printf("Counter is at %d.\n", ++ctr);

    printf("Counter is at %d.\n", --ctr);
    printf("Counter is at %d.\n", --ctr);
    printf("Counter is at %d.\n", --ctr);
    printf("Counter is at %d.\n", --ctr);

    return 0;
}
