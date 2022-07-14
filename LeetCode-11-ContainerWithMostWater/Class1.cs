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

            throw new NotImplementedException();
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