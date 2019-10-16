
/** This program asks a user for their hometown and the 2-letter abbreviation of their home state. It then uses
    string concentration to build a new string with both town and state and prints it using puts.
 */

/** stdio.h is needed for puts() and gets() */
/** string.h is needed for strcat() */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char city[15];
    char state[3];  /** 2 chars for the state abbrev. and one for the null zero */
    char fullLocation[18] = "";

    puts("What town do you live in? ");
    gets(city);

    puts("What state do you live in? (2-letter abbreviation)");
    gets(state);

    /** Concatenates the strings */

    strcat(fullLocation, city);
    strcat(fullLocation, ", ");  /** Adds a comma and space between the city and the state abbrev */
    strcat(fullLocation, state);

    puts("\nYou live in ");
    puts(fullLocation);

    return 0;
}
