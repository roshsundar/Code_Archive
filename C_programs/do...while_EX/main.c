
/** NOTES
 * Note: the do...while behaves almost exactly like a while loop
 * Format:
 *          do
 *          { block of one or more C statements; }
 *          while (condition)
 *
 * Note: only use a do...while in place of a while only if the body of the loop must execute at least one time. The
 *       condition is located at the bottom of the do...while loop, so C can't test the condition until the loop
 *       finishes the first time
 */

 /**
    This program  will multiply 2 numbers and display the result for as long as the user wants. Answering 'N' will
    break the loop
 **/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    float num1, num2, result;
    char choice;

    do{
        printf("Enter your first number to multiply: ");
        scanf(" %f", &num1);

        printf("Enter your second number to multiply: ");
        scanf(" %f", &num2);

        result = num1 * num2;
        printf("%f times %f equals %f\n\n", num1, num2, result);

        printf("Do you want another pair of numbers to multiply (Y/N): ");
        scanf(" %c", &choice);


        /** if the user enters a lowercase n or y, this if statement will convert it to a capital letter **/
        if (choice = 'n')
        {
            choice = 'N';
        }
    }while (choice != 'N');

    return 0;
}
