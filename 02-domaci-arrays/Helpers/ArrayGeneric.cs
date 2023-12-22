namespace DSS.Helpers
{
public static class ArrayGeneric
{
    public static double CalculateAverage<T>(T[] array) where T : IConvertible
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }

        double sum = 0;

        foreach (var item in array)
        {
            sum += Convert.ToDouble(item);
        }

        return sum / array.Length;
    }

    public static int IndexOfClosestToAverage<T>(T[] array) where T : IConvertible
    {
        double average = CalculateAverage(array);

        double minDifference = double.MaxValue;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            double difference = Math.Abs(Convert.ToDouble(array[i]) - average);

            if (difference < minDifference)
            {
                minDifference = difference;
                index = i;
            }
        }

        return index;
    }

    public static int IndexOfFarthestFromAverage<T>(T[] array) where T : IConvertible
    {
        double average = CalculateAverage(array);

        double maxDifference = double.MinValue;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            double difference = Math.Abs(Convert.ToDouble(array[i]) - average);

            if (difference > maxDifference)
            {
                maxDifference = difference;
                index = i;
            }
        }

        return index;
    }
}

}