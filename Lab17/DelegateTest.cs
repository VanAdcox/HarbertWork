namespace Lab17
{
    public static class DelegateTest
    {

        //public delegate int DoSomething(int num);

        public static void ProcessArray(int[] arr, Func<int, int> doSomething)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = doSomething(arr[i]);
            }
        }
    }
}
