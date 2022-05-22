namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            ArrayAbstract array2 = new ArrayBubbleSort();
            stopWatch.Start();
            array2.azar.SortArray(array2.a);
            stopWatch.Stop();
            Console.Write("\nTempo Bubble:     " + stopWatch.Elapsed);
            stopWatch.Reset();

            ArrayAbstract array1 = new ArrayInsertionSort();
            stopWatch.Start();
            array1.azar.SortArray(array1.a);
            stopWatch.Stop();
            Console.Write("\nTempo Insertion:     " + stopWatch.Elapsed);
            stopWatch.Reset();

            ArrayAbstract array3 = new ArrayQuickSort();
            stopWatch.Start();
            array3.azar.SortArray(array3.a);
            stopWatch.Stop();
            Console.Write("\nTempo Quick:     " + stopWatch.Elapsed);
            stopWatch.Reset();

            ArrayAbstract array4 = new ArrayQuickSort();
            stopWatch.Start();
            array4.azar.SortArray(array4.a);
            stopWatch.Stop();
            Console.Write("\nTempo Shell:     " + stopWatch.Elapsed);

        }
    }
}