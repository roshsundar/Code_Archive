
// this program uses compound operators to print updates from from it increasing from 1-5, then counts back down to 1

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ctr = 0;

    ctr += 1; // increases counter to 1
    printf("Counter is at %d.\n", ctr);

    ctr += 1; // increases counter to 2
    printf("Counter is at %d.\n", ctr);

    printf("Counter is at %d.\n", ctr += 1); // increases counter to 3

    ctr += 1; // increases counter to 4
    printf("Counter is at %d.\n", ctr);

    printf("Counter is at %d.\n", ctr += 1); // increases counter to 5

    ctr -= 1; // decreases  counter to 4
    printf("Counter is at %d.\n", ctr);

    printf("Counter is at %d.\n", ctr -= 1); // decreases counter to 3

    printf("Counter is at %d.\n", ctr -= 1); // decreases counter to 2

    printf("Counter is at %d.\n", ctr -= 1); // decreases counter to 1

    return 0;
}
