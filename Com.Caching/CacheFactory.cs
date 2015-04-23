using System;
using System.Configuration;
using Com.Caching.BackingStore;
using Com.Caching.Instrumentation;

namespace Com.Caching
{
    /// <summary>
    /// Static factory class used to get instances of a specified CacheManager
    /// </summary>
    public static class CacheFactory
    {
        private static readonly object lockObject = new object();
        private static ICacheManager _manager=null;

       /// <summary>
       /// Returns the default CacheManager instance. The same instance should be returned each time this method
       /// is called. The name of the instance to treat as the default CacheManager is defined in the configuration file.
       /// Guaranteed to return an intialized CacheManager if no exception thrown
       /// </summary>
       /// <param name="numberToRemoveWhenScavenging"></param>
       /// <param name="maximumElementsInCacheBeforeScavenging"></param>
       /// <param name="expirationPollFrequencyInMilliSeconds"></param>
       /// <returns></returns>
        public static ICacheManager GetCacheManager(
                             int numberToRemoveWhenScavenging = 10,
                             int maximumElementsInCacheBeforeScavenging = 50,
                             int expirationPollFrequencyInMilliSeconds = 30*60*1000
                             )
        {

            if(_manager==null)
            {
                lock (lockObject)
                {
                    if(_manager==null)
                    {
                        var cache = new Cache(new NullBackingStore(), new NopCachingIntrumentationProvider());
                        var task = new ScavengerTask(numberToRemoveWhenScavenging,
                                                     maximumElementsInCacheBeforeScavenging,
                                                     cache,
                                                     new NopCachingIntrumentationProvider());
                        var sched = new BackgroundScheduler(new ExpirationTask(cache, new NopCachingIntrumentationProvider()),
                                                            task,
                                                            new NopCachingIntrumentationProvider());
                        _manager = new CacheManager(cache, sched, new ExpirationPollTimer(expirationPollFrequencyInMilliSeconds));            
                    }
                }
            }
            return _manager;

        }


    }
}