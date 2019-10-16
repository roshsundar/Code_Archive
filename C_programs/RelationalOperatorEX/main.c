/** NOTES
 * Relational Operator    | Description
 *-------------------------------------------------
 * ==                     | Equal to
 * >                      | Greater than
 * <                      | Less than
 * >=                     | Greater than or equal to
 * <=                     | Less than or equal to
 * !=                     | Not equal to
 */



#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a;
    int b;

    a = (4 < 10); // (4 < 10) is true, so a 1 is put in 'a'
    b = (8 == 9); // (8 == 9) is false, so a 0 is put in 'b'

    printf("%d", a);
    printf("%d", b);

    return 0;
}
