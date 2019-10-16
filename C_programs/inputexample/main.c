#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

int main()
{
    char *first_name;
    char *last_name;
    int age;
    int favorite_number;

    printf("First name please.\n");
    scanf("%s", &first_name);

    printf("Last name please.\n");
    scanf("%s", &last_name);

    printf("Age please.\n");
    scanf("%d", &age);

    printf("Favorite number please (integer only).\n");
    scanf("%d", &favorite_number);

    printf("\n Your first name is %s, and your last name is %s", &first_name, &last_name);
    printf("\n Your age is %d, and your favorite number is %d", age, favorite_number);

    Sleep(2000);

    printf("\nAm I not smart?");

    return 0;
}
