namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Bubble Sort 

            int[] Num = { 1, 2, 5, 3, 4 };
            Helper.BubbleSort(Num);

            foreach (var item in Num) 
            {
                Console.Write($"{item}\t");
            
            }
            #endregion
        }
    }
}