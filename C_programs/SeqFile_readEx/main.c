/** The program takes the data from TestDoc.txt file and prints it */

#include <stdio.h>
#include <stdlib.h>

FILE *fptr;

int main()
{
    char fileline[100]; /** Will hold each line of input */

    fptr = fopen("C:\\Users\\parvathy\\Desktop\\C programs\\SeqFile_writeEx\\TestDoc.txt", "r");

    if (fptr != 0)
    {
        while (!feof(fptr))
        {
            fgets(fileline, 100, fptr);
            if (!feof(fptr))
            {
                puts(fileline);
            }
        }
    }
    else
    {
        printf("\nError opening file.\n");
    }
    fclose(fptr); /** Always close the file */

    return 0;
}
