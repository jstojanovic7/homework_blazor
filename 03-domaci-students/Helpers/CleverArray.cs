namespace DSS.Helpers
{
    public class CleverArray
    {
    
    public static double[] ArrayFromText(String s)
    {
        String[] elements = s.Split();
        double[] nums = new double[elements.Length];
        for(int i=0; i< nums.Length; i++)
            nums[i] = double.Parse(elements[i]);
        return nums;
    }

    public static int PositionOfMinimum(double[] array)
    {
        int posMin = 0;
        for(int i=1; i<array.Length; i++)
            if(array[i] < array[posMin])
                posMin = i;
        return posMin;
    }

    public static int PositionOfMaximum(double[] array)
    {
        int posMax = 0;
        for(int i=1; i<array.Length; i++)
            if(array[i] > array[posMax])
                posMax = i;
        return posMax;
    }

    }
}