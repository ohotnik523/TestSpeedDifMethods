using System.Collections;

namespace dz14_02
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            int testQty = 1;



            //List Add

            List<int> list = new List<int>();
            double[] TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListFor(list, "add");
                GC.Collect();
            }
            Console.WriteLine("ListForWithoutOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListforWithOpt(list, "add");
                GC.Collect();
            }
            Console.WriteLine("ListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            GC.Collect();

            Console.WriteLine();

            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListForeach(list, "add");
            //    GC.Collect();
            //}
            //Console.WriteLine("ListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            //GC.Collect();

            Console.WriteLine();

            //---------
            //List Contains

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListFor(list, "contains");
                GC.Collect();
            }
            Console.WriteLine("ListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListforWithOpt(list, "contains");
                GC.Collect();
            }
            Console.WriteLine("ListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListForeach(list, "contains");
            //    GC.Collect();
            //}

            //Console.WriteLine("ListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            //GC.Collect();

            //Console.WriteLine();

            ////---------
            ////List Remove


            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListFor(list, "Remove");
            //    GC.Collect();
            //}
            //Console.WriteLine("ListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            //GC.Collect();

            //Console.WriteLine();

            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListforWithOpt(list, "remove");
            //    GC.Collect();
            //}
            //Console.WriteLine("ListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            //GC.Collect();

            //Console.WriteLine();

            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListForeach(list, "remove");
            //    GC.Collect();
            //}
            //Console.WriteLine("ListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            //GC.Collect();

            Console.WriteLine();

            //---------
            //List binarySearch
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListFor(list, "binary");
                GC.Collect();
            }
            Console.WriteLine("ListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ListforWithOpt(list, "binary");
                GC.Collect();
            }
            Console.WriteLine("ListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            GC.Collect();

            Console.WriteLine();

            //TestResult = new double[testQty];
            //for (int i = 0; i < TestResult.Length; i++)
            //{
            //    TestResult[i] = TestsListLoops.ListForeach(list, "binary");
            //    GC.Collect();
            //}
            //Console.WriteLine("ListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            //GC.Collect();

            //Console.WriteLine();
            //----------------------------------------------------------------



            LinkedList<int> list2 = new LinkedList<int>();
            //LinkedList addFirst
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListFor(list2, "addFirst");
                GC.Collect();
            }
            Console.WriteLine("LinkedListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addFirst");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListforWithOpt(list2, "addFirst");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addFirst");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListForeach(list2, "addFirst");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addFirst");
            GC.Collect();

            Console.WriteLine();

            //LinkedList addLast
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListFor(list2, "addLast");
                GC.Collect();
            }
            Console.WriteLine("LinkedListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addLast");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListforWithOpt(list2, "addLast");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addLast");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListForeach(list2, "addLast");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -addLast");
            GC.Collect();

            Console.WriteLine();

            //LinkedList Contains
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListFor(list2, "contains");
                GC.Collect();
            }
            Console.WriteLine("LinkedListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListforWithOpt(list2, "contains");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListForeach(list2, "contains");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();


            //Linked List remove
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListFor(list2, "remove");
                GC.Collect();
            }
            Console.WriteLine("LinkedListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListforWithOpt(list2, "remove");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.LinkedListForeach(list2, "remove");
                GC.Collect();
            }
            Console.WriteLine("LinkedListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            //----------------------------------------------------------------




            ArrayList list3 = new ArrayList();
            //ArrayList Add

            TestResult = new double[testQty];

            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListFor(list3, "add");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForWithoutOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListforWithOpt(list3, "add");
                GC.Collect();
            }
            Console.WriteLine(" ArrayListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListForeach(list3, "add");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -add");
            GC.Collect();

            Console.WriteLine();

            //---------
            //List Contains

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListFor(list3, "contains");
                GC.Collect();
            }
            Console.WriteLine("ArrayListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListforWithOpt(list3, "contains");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListForeach(list3, "contains");
                GC.Collect();
            }

            Console.WriteLine("ArrayListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -contains");
            GC.Collect();

            Console.WriteLine();

            //---------
            //List Remove


            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListFor(list3, "Remove");
                GC.Collect();
            }
            Console.WriteLine("ArrayListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListforWithOpt(list3, "remove");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListForeach(list3, "remove");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -remove");
            GC.Collect();

            Console.WriteLine();

            //---------
            //List binarySearch
            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListFor(list3, "binary");
                GC.Collect();
            }
            Console.WriteLine("ArrayListFor " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListforWithOpt(list3, "binary");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForWithOpt " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            GC.Collect();

            Console.WriteLine();

            TestResult = new double[testQty];
            for (int i = 0; i < TestResult.Length; i++)
            {
                TestResult[i] = TestsListLoops.ArrayListForeach(list3, "binary");
                GC.Collect();
            }
            Console.WriteLine("ArrayListForEach " + getAverage(TestResult) + "ms;\tAverage for " + testQty + " tests" + " -binarySearch");
            GC.Collect();

            Console.WriteLine();
            //----------------------------------------------------------------






        }
        static double getAverage(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
