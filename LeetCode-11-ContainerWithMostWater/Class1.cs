namespace LeetCode_11_ContainerWithMostWater
{
    public class ConstraintViolationException : Exception
    {
    }

    public class Class1
    {
        public int MaxArea(int[] height)
        {
            // Validate core constraints first
            CheckConstraints(height);

            int maxArea = 0;

            // Go through each pair of "vertical lines" in the array and calculate the area between them.
            // Choose the greatest from among them all.
            for (int i = 0; i < height.Length - 1; i++)
            {
                // For the second pass through the array, start from the end of the array and work back.
                // This gives us the opportunity to run the algorithm faster (performance improvement).
                for (int j = height.Length - 1; j > i; j--)
                {
                    if (height[j] >= height[i])
                    {
                        // If the height of the 2nd line is higher than the 1st line, then we've found the max
                        // area possible for any line paired with the first line, so no need to process this 
                        // iteration of the loop any further.
                        int area = height[i] * (j - i);

                        if (area > maxArea)
                        {
                            maxArea = area;
                        }

                        break;
                    }
                    else
                    {
                        // If the height of the 2nd line is lower than the 1st line, we need to keep checking
                        // the area of all other line pairs.
                        int area = height[j] * (j - i);

                        if (area > maxArea)
                        {
                            maxArea = area;
                        }
                    }
                }
            }

            return maxArea;
        }

        private void CheckConstraints(int[] height)
        {
            // Constraints:
            //
            //    n == height.length
            //    2 <= n <= 10**5
            //    0 <= height[i] <= 10**4

            if ((height.Length < 2) || (height.Length > 100000))
            {
                throw new ConstraintViolationException();
            }

            if ((height.Min() < 0) || (height.Max() > 10000))
            {
                throw new ConstraintViolationException();
            }
        }

    }
}