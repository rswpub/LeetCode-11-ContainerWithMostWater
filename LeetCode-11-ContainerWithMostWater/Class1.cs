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
                for (int j = i + 1; j < height.Length; j++)
                {
                    int area = (Math.Min(height[i], height[j])) * (j - i);

                    if (area > maxArea)
                    {
                        maxArea = area;
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