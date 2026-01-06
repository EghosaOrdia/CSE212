public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // ******* STEPS ******* //
        // 1. Create an fixed array of size 'length' to hold the multiples
        // 2. Loop from 0 up to length
        // 3. In each iteration, calculate number * (current index + 1) and store it in the array at the current index.
        // 4. After the loop, return the array containing all multiples.
        var multiples = new double[length];

        for (int i = 0; i < length; ++i)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //  ******* STEPS *******

        //  1. Create a variable (n) to store the length of the input list.

        //  2. Normalize the rotation amount by computing:
        //     amount = amount % n
        //     (this prevents unnecessary extra rotations)

        //  3. Create a fixed array (result) with length n.
        //     This will temporarily store the rotated values so nothing is overwritten.

        //  4. Iterate through the input list using index (idx).

        //  5. For each element:
        //     - Compute a new index using:
        //       newIndex = (idx + amount) % n
        //       This shifts the element to the right and wraps around if it goes past the end.

        //  6. Place the value from the original list into its rotated position:
        //     result[newIndex] = data[idx]

        //  7. After the loop, copy all values from result back into the original list (data)
        //     so that the rotation is applied to the input list.

        int n = data.Count;
        amount %= n;
        var result = new int[n];

        for (int idx = 0; idx < n; ++idx)
        {
            int newIndex = (idx + amount) % n;
            result[newIndex] = data[idx];
        }

        for (int idx = 0; idx < n; ++idx)
        {
            data[idx] = result[idx];
        }
    }
}
