namespace Codility_CyclicRotation
{
    public static class Solution
    {
        public static int[] RotateArray(int[] A, int K)
        {            
            int[] temp = new int[A.Length];

            for (int x = 0; x < K; x++)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    temp[i + 1] = A[i];
                }
                temp[0] = A[A.Length - 1];

                Array.Copy(temp, A, temp.Length);    
            }

            return A;
        }
    }
}
