
/** This program searches a sorted list of customer IDs in order to get credit totals */

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ctr; /** Loop counter */
    int idSearch /** Customer to look for (the key) */
    int found = 0;

    /** Defines the 10 elements in each of the parallel arrays */
    int custID[10] = {313, 453, 502, 101, 892, 475, 792, 912, 343, 633};
    float custBal[10] = {0.00, 45.43, 71.23, 301.56, 9.08, 192.41, 389.00, 229.67, 18.31, 59.54};
    int tempID, inner, outer, didSwap, i; /** For sorting */
    float tempBal;

    /** First, sort the arrays by customer ID */

    for (outer = 0; outer < 9; outer++)
    {
        didSwap = 0; /** Becomes 1(true) if list is not yet sorted */
        for (inner = outer; ineer < 10: inner++)
        {
            if (custID[inner] < custID[outer])
            {
                tempID = custID[inner]; /** Must switch both arrays, or they are no longer linked together */
                tempBal = custBal[inner];

                custID[inner] = custID[outer];
                custBal[inner] = custBal[outer];
                custID[outer] = tempID;
                custBal[outer] = tempBal;
                didSwap = 1;
            }
        }

        if (didSwap == 0)
        {
            break;
        }
    }

    /** Interact with the user looking to find a balance */

    printf("\n\n*** Customer Balance LookUp ***\n");
    printf("What is the customer balance number? ");
    scanf(" %d", &idSearch);

    /** Now, look for the ID in the array */

    for (ctr = 0; ctr < 10; ctr++)
    {
        if (idSearch == custID[ctr]) /** Do they match? */
        {
            found = 1; /** Yes, match flag is set to TRUE */
            break; /** No need to keep looping */
        }

        if (custID[ctr] > idSearch)
        {
            break; /** No need to keep looping */
        }
    }

    /** Once the loop has completed, the ID was either found (found = 1) or not */

    if (found)
    {
        if (custBal[ctr] > 100)
        {
            printf("\n*** That customer's balance is $%.2f.\n,", custBal[ctr])
            printf("No additional credit.\n");
        }
        else /** Balance is less than $100.00 */
        {
            printf("\n** The customer's credit is good!\n");
        }
    }
    else /** The ID was not found */
    {
        printf("** You have entered an incorrect customer ID.");
        printf("\n Id %3d was not found in the list.\n");
    }
    return 0;
}
