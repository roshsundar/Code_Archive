
/** NOTES
 * Format:
 *          for (startExpression; testExpression; countExpression)
 *          { clock of one or more C statements; }
 *
 * Ex:
 *          for (count = 1; count <= 5; count++)
 *          {
 *              printf("counter is at %d.\n", count);
 */



/**
    This program will ask users how many movies they've seen this year, and then loop through asking the name of
    each movie and a rating from 1 to 10. It will remember their favorite movie and their least favorite movie.
**/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ctr, numMovies, rating, favRating, leastRating;
    char movieName[40], favorite[40], least[40];

    /**
        initialize the favRating to 0 so any movie with any rating of 1 or higher will replace it and the
        leastRating to 10 so any movie rated 9 or over will replace it
    **/

    favRating = 0;
    leastRating = 10;

    /**
        Find out how many movies the user has seen and can rate the loop will continue until they enter a number more
        than 0
    **/

    do {
        printf("How many movies have you seen this year? ");
        scanf(" %d", &numMovies);

        /**
            If the user enters 0 or a negative number, the program will remind them to enter a positive number and
            prompt them again
        **/

        if (numMovies < 1)
        {
            printf("No movies! How can you rank them?\nTry again!\n\n");
        }
    } while (numMovies < 1);


    for (ctr = 1; ctr <= numMovies; ctr++)
    {
        /** Get the name of the movie and the user's rating **/

        printf("\nWhat was the name of the movie? (1-word titles only!)");
        scanf(" %s", movieName);

        printf("On a scale form 1 to 10, what would you rate it? ");
        scanf(" %d", &rating);

        /** Check whether it's their best-rated movie so far **/

        if (rating > favRating)
        {
            strcpy(favorite, movieName);
            favRating = rating;
        }

        /** Check whether it's their worst-rated movie so far **/

        if (rating < leastRating)
        {
            strcpy(least, movieName);
            leastRating = rating;
        }
    }

    printf("\nYour favorite movie was %s.\n", favorite);
    printf("\nYour least favorite movie was %s.\n", least);

    return 0;
}
