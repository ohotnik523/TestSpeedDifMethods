using System.Collections;
using System.Diagnostics;

namespace dz14_02
{
    public class TestsListLoops
    {
        public static double ListFor(List<int> list, string cond)
        {
            if (cond == "add")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < 2; i++)
                    list.Add(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "binary")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.BinarySearch(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        public static double ListforWithOpt(List<int> list, string cond)
        {
            int dlina = list.Count;

            if (cond == "add")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Add(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "binary")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.BinarySearch(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        //public static double ListForeach(List<int> list, string cond)
        //{
        //    if (cond == "add")
        //    {
        //        Stopwatch watch = Stopwatch.StartNew();
        //        foreach (int i in list)
        //            list.Add(i);
        //        watch.Stop();
        //        return watch.Elapsed.TotalMilliseconds;
        //    }
        //    if (cond == "contains")
        //    {
        //        Stopwatch watch = Stopwatch.StartNew();
        //        foreach (int i in list)
        //            list.Contains(i);
        //        watch.Stop();
        //        return watch.Elapsed.TotalMilliseconds;
        //    }
        //    if (cond == "remove")
        //    {
        //        Stopwatch watch = Stopwatch.StartNew();
        //        foreach (int i in list)
        //            list.Remove(i);
        //        watch.Stop();
        //        return watch.Elapsed.TotalMilliseconds;
        //    }
        //    if (cond == "binary")
        //    {
        //        Stopwatch watch = Stopwatch.StartNew();
        //        foreach (int i in list)
        //            list.BinarySearch(i);
        //        watch.Stop();
        //        return watch.Elapsed.TotalMilliseconds;
        //    }
        //    return -1.0;
        //}

        //--------------------------------------------------------------------------------------------------------
        public static double LinkedListFor(LinkedList<int> list, string cond)
        {
            if (cond == "addFirst")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.AddFirst(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "addLast")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.AddLast(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        public static double LinkedListforWithOpt(LinkedList<int> list, string cond)
        {
            int dlina = list.Count;
            if (cond == "addFirst")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.AddFirst(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "addLast")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.AddLast(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        public static double LinkedListForeach(LinkedList<int> list, string cond)
        {
            if (cond == "addFirst")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.AddFirst(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "addLast")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.AddLast(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }

        //--------------------------------------------------------------------------------------------------------
        public static double ArrayListFor(ArrayList list, string cond)
        {
            if (cond == "add")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Add(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "binary")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < list.Count; i++)
                    list.BinarySearch(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        public static double ArrayListforWithOpt(ArrayList list, string cond)
        {
            int dlina = list.Count;

            if (cond == "add")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Add(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "binary")
            {
                Stopwatch watch = Stopwatch.StartNew();
                for (int i = 0; i < dlina; i++)
                    list.BinarySearch(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
        public static double ArrayListForeach(ArrayList list, string cond)
        {
            if (cond == "add")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.Add(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "contains")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.Contains(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "remove")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.Remove(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            if (cond == "binary")
            {
                Stopwatch watch = Stopwatch.StartNew();
                foreach (int i in list)
                    list.BinarySearch(i);
                watch.Stop();
                return watch.Elapsed.TotalMilliseconds;
            }
            return -1.0;
        }
    }
}
//ArrayList for int
//for
//for with opt
//foreach standart


