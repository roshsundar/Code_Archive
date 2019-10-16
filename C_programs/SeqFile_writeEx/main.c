/** The program writes user input to a text file */

#include <stdio.h>
#include <stdlib.h>

FILE *fptr;

int main()
{

    printf("This will now print hi to the file");

    /** Remember when typing your filename path to double up the backslashes or C will think that you're putting in a
        conversion character
     */
    fptr = fopen("C:\\Users\\parvathy\\Desktop\\C programs\\SeqFile_writeEx\\TestDoc.txt", "w");

    /** Test to ensure that the file opened */
    if (fptr == 0)
    {
        printf("Error -- file could not be opened.\n");
        exit(1);
    }

    fprintf(fptr, "hi");
    fclose(fptr);

    return 0;
}
