#include <stdio.h>
#include <stdlib.h>

int main()
{
    // This is a program that demonstrates math operators, and the different types of division

    // 2 sets of equivalent variables, with 1 set
    // floating-point and the other integer

    float a = 90.0;
    float b = 5.0;
    float floatAnswer;

    int x = 19;
    int y = 5;
    int intAnswer;

    // Using 2 float variables creates an answer of 3.8
    floatAnswer = a / b;
    printf("%f divided by %f equals %f.\n", a \, b, floatAnswer);

    floatAnswer = x / y;   // Take 2 creates an answer of 3.0
    printf("%d divided by %d equals %f.\n", x, y, floatAnswer);

    // This will also be 3, as it truncates and doesn't round up
    intAnswer = a / b;
    printf("%f divided by %f equals %d.\n", a, b, intAnswer);

    intAnswer = x % y; // This calculates the remainder (4)
    printf("%d modulus (i.e. remainder of) %d equals %d", x, y, intAnswer);

    return 0;
}
