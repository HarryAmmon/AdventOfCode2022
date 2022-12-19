using System.Linq;

namespace Solutions.CollectionExtensions
{
    public static class ArrayExtensions
    {
        /// <summary> 
        /// Takes <c>count</c> number of items in array and puts them in <c>first<c/>
        /// and the remainder as <c>second</c>
        /// </summary> 
        public static void Split<T>(this T[] array, int count, out T[] first, out T[] second)
        {
            first = array.Take(count).ToArray();
            second = array.Skip(count).ToArray();
        }

        public static void SplitMidpoint<T>(this T[] array, out T[] first, out T[] second)
        {
            var midPoint = (array.Length + 1) / 2;
            array.Split<T>(midPoint, out first, out second);
        }
    }
}