using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Six.Sorting
{
    public class MergeSortAlgorithm
    {
        public static int[] Sort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middleIndex = array.Length / 2;
            int[] left = new int[middleIndex];
            int[] right = new int[array.Length - middleIndex];

            Array.Copy(array, left, middleIndex);
            Array.Copy(array, middleIndex, right, 0, right.Length);

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            List<int> leftList = left.ToList<int>();
            List<int> rightList = right.ToList<int>();
            List<int> resultList = new List<int>();

            while (leftList.Count != 0 || rightList.Count != 0)
            {
                if(leftList.Count != 0 && rightList.Count != 0)
                {
                    if (leftList[0] < rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    } else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }
                else if(leftList.Count != 0){
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                } 
                else if(rightList.Count != 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            return resultList.ToArray();
        }
    }
}
