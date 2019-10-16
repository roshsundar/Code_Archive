#include <stdio.h>
#include <stdlib.h>

int main()
{
    char *topping;
    int slices, month, day, year;
    float cost;

    // the first scanf will look for a floating-point variable, the cost of a pizza
    // if the user doesn't enter a $ before the cost, it could cause problems

    printf("How much does pizza cost int your area?");
    printf("enter as $XX.XX)\n");
    scanf("$%f", &cost);

    // the pizza topping is a string, so your scanf doesn't need an &

    printf("What is your favorite pizza topping?\n");
    scanf("%s", topping);

    printf("How many slices o %s pizza can you eat in one sitting?\n", topping);
    scanf("%d", &slices);

    printf("What is today's date (enter it in XX/XX/XX format).\n");
    scanf("%d/%d/%d", &month, &day, &year);

    printf("\n\nWhy not treat yourself to dinner on %d/%d/%d", month, day, year);
    printf("\nand have %d slices of %s pizza!\n", slices, topping);
    printf("It will only cost you $%.2f!\n\n\n", cost);

    return(0);
}
