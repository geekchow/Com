using System;

namespace Com.Caching.Instrumentation
{
    public class NopCachingIntrumentationProvider:ICachingInstrumentationProvider
    {

        public void FireCacheUpdated(long updatedEntriesCount, long totalEntriesCount)
        {
            ;
        }

        public void FireCacheAccessed(string key, bool hit)
        {
            ;
        }

        public void FireCacheExpired(long itemsExpired)
        {
            ;
        }

        public void FireCacheScavenged(long itemsScavenged)
        {
            ;
        }

        public void FireCacheCallbackFailed(string key, Exception exception)
        {
            ;
        }

        public void FireCacheFailed(string errorMessage, Exception exception)
        {
            ;
        }
    }
}