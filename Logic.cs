using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalancingScalesApp
{
    public static class Logic
    {
        public static int[] balancer(int[] scales, int[] weights)
        {
            for (int x = 0; x < weights.Length; x++)
            {
                for (int y = 0; y < weights.Length; y++)
                {
                    //block 1
                    if (scales[0] + weights[x] == scales[1] + weights[y])
                    {
                        return new int[] { weights[x], weights[y] };
                    }
                    //block 2
                    if (scales[0] + weights[y] == scales[1] + weights[x])
                    {
                        return new int[] { weights[y], weights[x] };
                    }
                    //block 3
                    if (scales[0] + weights[x] + weights[y] == scales[1])
                    {
                        return new int[] { weights[y], weights[x] };
                    }
                    //block 4
                    if (scales[1] + weights[x] + weights[y] == scales[0])
                    {
                        return new int[] { weights[y], weights[x] };
                    }
                    //block 5
                    if (scales[0] + weights[x] == scales[1])
                    {
                        return new int[] { weights[x] };
                    }
                    //block 6
                    if (scales[0] + weights[y] == scales[1])
                    {
                        return new int[] { weights[y] };
                    }
                    //block 7
                    if (scales[1] + weights[x] == scales[1])
                    {
                        return new int[] { weights[x] };
                    }
                    //block 8
                    if (scales[1] + weights[y] == scales[1])
                    {
                        return new int[] { weights[y] };
                    }
                }
            }
            return null;
        }
    }
}






