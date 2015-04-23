using System.Collections;

namespace Com.Caching
{
    /// <summary>
    /// Sorts the cache items in data for scavenging
    /// </summary>>
    public class PriorityDateComparer : IComparer
    {
        private Hashtable unsortedItems;

        /// <summary>
        /// Initialize a new instance of the <see cref="PriorityDateComparer"/> class with a list of unsorted cache items.
        /// </summary>
        /// <param name="unsortedItems">
        /// A set of unsorted cache items.
        /// </param>
        public PriorityDateComparer(Hashtable unsortedItems)
        {
            this.unsortedItems = unsortedItems;
        }

        /// <summary>
        /// Compares two <see cref="CacheItem"/> objects and returns a value indicating whether one is less than, equal to or greater than the other in priority by date.
        /// </summary>
        /// <param name="x">
        /// First <see cref="CacheItem"/> to compare.
        /// </param>
        /// <param name="y">
        /// Second <see cref="CacheItem"/> to compare.
        /// </param>
        /// <returns>
        /// <list type="table">
        /// <listheader>
        /// <term>Value</term>
        /// <description>Condition</description>
        /// </listheader>
        /// <item>
        /// <term>Less than zero</term>
        /// <description><paramref name="x"/> is less than <paramref name="y"/></description>
        /// </item>
        /// <item>
        /// <term>Zero</term>
        /// <description><paramref name="x"/> equals <paramref name="y"/></description>
        /// </item>
        /// <item>
        /// <term>Greater than zero</term>
        /// <description><paramref name="x"/> is greater than <paramref name="y"/></description>
        /// </item>
        /// </list>
        /// </returns>
        public int Compare(object x, object y)
        {
            CacheItem leftCacheItem = (CacheItem)unsortedItems[(string)x];
            CacheItem rightCacheItem = (CacheItem)unsortedItems[(string)y];

            lock (rightCacheItem)
            {
                lock (leftCacheItem)
                {
                    if (rightCacheItem == null && leftCacheItem == null)
                    {
                        return 0;
                    }
                    if (leftCacheItem == null)
                    {
                        return -1;
                    }
                    if (rightCacheItem == null)
                    {
                        return 1;
                    }

                    return leftCacheItem.ScavengingPriority == rightCacheItem.ScavengingPriority
                               ? leftCacheItem.LastAccessedTime.CompareTo(rightCacheItem.LastAccessedTime)
                               : leftCacheItem.ScavengingPriority - rightCacheItem.ScavengingPriority;
                }
            }
        }
    }
}