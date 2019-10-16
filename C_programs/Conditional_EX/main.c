
/** NOTES
 * Format...   relation ? trueStatement : falseStatement;
 * Meaning...  the relation is any relational test, such as " age >= 21 " or " sales <= 2500.0 ". You can also combine
 *             relational operators with logical operators. The "trueStatement" is any valid C statement, and the
 *             "falseStatement" is also any valid C statement.
 *
 *             Example...      (total <= 3860.0) ? (total *= 1.10) : (total *= 1.05);
 *             - if the first set of parentheses is true, the trueStatement executes. if the test in the first set of
 *               parentheses if false, the falseStatement executes. The conditional operator does the exact same thing
 *               using an if-else statement :
 *                                             if (total <= 38.50)
 *                                             {
 *                                                  total *= 1.10;
 *                                             }
 *                                             else
 *                                             {
 *                                                  total *= 1.05;
 *                                             }
 *             Example...      printf("I ate %d pear%s\n", numPear, (numPear > 1) ? ("s.") : ("."));
 **/


#include <stdio.h>
#include <stdlib.h>

/**
    this program asks for a number form 1 to 100 and tells whether or not their choice is equally divisible by 2
    through 9.
**/

int main()
{
    /** Define the integer to hold the user's guess and then get it from the user **/

    int numPick;

    printf("Pick an integer between 1 and 100 (The higher, the better!)\n");
    scanf(" %d", &numPick); /** remember for an int, you do need the and **/

    printf("%d %s divisible by 2.\n", numPick, (numPick %2 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 3.\n", numPick, (numPick %3 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 4.\n", numPick, (numPick %4 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 5.\n", numPick, (numPick %5 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 6.\n", numPick, (numPick %6 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 7.\n", numPick, (numPick %7 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 8.\n", numPick, (numPick %8 == 0) ? ("is") : ("is not"));
    printf("%d %s divisible by 9.\n", numPick, (numPick %9 == 0) ? ("is") : ("is not"));

    return 0;
}
