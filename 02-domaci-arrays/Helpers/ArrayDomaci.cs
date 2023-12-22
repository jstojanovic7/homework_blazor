namespace DSS.Helpers
{
    public class ArrayDomaci
    {
        public static string ElementsToString(byte[] arr)
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i] + " ";
            }
            return res;
        }

        public static string ElementsToString(string[] arr)
        {
            string res = "";
            foreach (string x in arr)
            {
                res += "'" + x + "' ";
            }
            return res;
        }

        public static string ElementsToString(int[] arr)
        {
            string res = "";
            foreach (int x in arr)
            {
                res += x + " ";
            }
            return res;
        }

        public static string ElementsToString(double[] arr)
        {
            string res = "";
            foreach (double x in arr)
            {
                res += x + " ";
            }
            return res;
        }

        public static double Avg(double[] arr)
        {
            double r = 0;
            foreach (double x in arr)
                r += x;
            return r/arr.Length;
        }

        public static int IndexOfClosestToAvg(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            double average = Avg(arr);
            int closestIndex = 0;
            double minDifference = Math.Abs(arr[0] - average);

            for (int i = 1; i < arr.Length; i++)
            {
                double difference = Math.Abs(arr[i] - average);
                if (difference < minDifference || (difference == minDifference && arr[i] < arr[closestIndex]))
                {
                    minDifference = difference;
                    closestIndex = i;
                }
            }

            return closestIndex;
        }

        public static int IndexOfFarthestFromAvg(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            double average = Avg(arr);
            int farthestIndex = 0;
            double maxDifference = Math.Abs(arr[0] - average);

            for (int i = 1; i < arr.Length; i++)
            {
                double difference = Math.Abs(arr[i] - average);
                if (difference > maxDifference || (difference == maxDifference && arr[i] < arr[farthestIndex]))
                {
                    maxDifference = difference;
                    farthestIndex = i;
                }
            }

            return farthestIndex;
        }

    }
}
