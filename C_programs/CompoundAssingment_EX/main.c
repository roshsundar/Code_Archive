/** NOTES
 *  compound operator |       example       | equivalent statement
 *--------------------|---------------------|----------------------
 *  *=                | total *= 1.25       | total = total * 1.25
 *  /=                | amount /= factor    | amount = amount / factor
 *  %=                | days %= 3           | days = days % 3
 *  +=                | count += 1          | count = count + 1
 *  -=                | quantity -= 5       | quantity = quantity - 5
 */






// This program increases a counter from 1 to 5, printing updates and then counts it back down to 1


#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ctr = 0;

    ctr += 1; // increases counter to 1
    printf("Counter is at %d.\n", ctr);

    ctr += 1; // increases counter to 2
    printf("Counter is at %d.\n", ctr);

    ctr += 1; // increases counter to 3
    printf("Counter is at %d.\n", ctr);

    ctr += 1; // increases counter to 4
    printf("Counter is at %d.\n", ctr);

    ctr += 1; // increases counter to 5
    printf("Counter is at %d.\n", ctr);

    ctr -= 1; // increases counter to 4
    printf("Counter is at %d.\n", ctr);

    ctr -= 1; // increases counter to 3
    printf("Counter is at %d.\n", ctr);

    ctr -= 1; // increases counter to 2
    printf("Counter is at %d.\n", ctr);

    ctr -= 1; // increases counter to 1
    printf("Counter is at %d.\n", ctr);

    return 0;
}
