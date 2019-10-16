#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

int main()
{
    int counter = 0;
    int forever = 0;

    while (forever < 1)
    {
        printf("%d\n", counter);

        Sleep(1000);

        counter++;
    }

    return 0;
}
