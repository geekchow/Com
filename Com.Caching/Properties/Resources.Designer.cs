﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.Caching.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Com.Caching.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Internal ProducerConsumerQueue thread failed. 的本地化字符串。
        /// </summary>
        internal static string BackgroundSchedulerProducerConsumerQueueFailure {
            get {
                return ResourceManager.GetString("BackgroundSchedulerProducerConsumerQueueFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enterprise Library Caching Application Block 的本地化字符串。
        /// </summary>
        internal static string BlockName {
            get {
                return ResourceManager.GetString("BlockName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total # of Cache Access Attempts is the number of reads from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheAccessAttemptsCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheAccessAttemptsCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Accessed Expired Items Ratio Base is the total number of items expired from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheAccessedExpiredItemsRatioBaseCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheAccessedExpiredItemsRatioBaseCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Accessed Expired Items Ratio is the ratio between expired items accessed by the user and total items expired from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheAccessedExpiredItemsRatioCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheAccessedExpiredItemsRatioCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Accessed Scavenged Items Ratio Base is the total number of items scavenged from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheAccessedScavengedItemsRatioBaseCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheAccessedScavengedItemsRatioBaseCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Accessed Scavenged Items Ratio is the ratio between scavenged items accessed by the user and total items scavenged from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheAccessedScavengedItemsRatioCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheAccessedScavengedItemsRatioCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Expiries/sec is the rate at which items were expired from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheExpiriesPerSecCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheExpiriesPerSecCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Hit Ratio is the ratio between hits and reads from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheHitRatioCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheHitRatioCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Hits/sec is the rate at which requests for existing items were received by the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheHitsPerSecCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheHitsPerSecCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Misses/sec is the rate at which requests for non existing items were received by the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheMissesPerSecCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheMissesPerSecCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Add called without setting BackgroundScheduler. 的本地化字符串。
        /// </summary>
        internal static string CacheNotInitializedException {
            get {
                return ResourceManager.GetString("CacheNotInitializedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cache Scavenged Items/sec is the rate at which items were scavenged from the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheScavengedItemsPerSecCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheScavengedItemsPerSecCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Cache Entries is the total number of entries in the cache. 的本地化字符串。
        /// </summary>
        internal static string CacheTotalEntriesCounterHelpResource {
            get {
                return ResourceManager.GetString("CacheTotalEntriesCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Updated Entries/sec is the rate at which items were updated in the cache. An update can be either an &quot;add&quot; or a &quot;remove&quot;. 的本地化字符串。
        /// </summary>
        internal static string CacheUpdatedEntriesPerSecHelpResource {
            get {
                return ResourceManager.GetString("CacheUpdatedEntriesPerSecHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parameter name cannot be null or an empty string. 的本地化字符串。
        /// </summary>
        internal static string EmptyParameterName {
            get {
                return ResourceManager.GetString("EmptyParameterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The error occurred executing the removal callback for key &quot;{1}&quot; in the the &quot;{0}&quot; instance. 的本地化字符串。
        /// </summary>
        internal static string ErrorCacheCallbackFailedMessage {
            get {
                return ResourceManager.GetString("ErrorCacheCallbackFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The error occurred retrieving the configuration for instance &quot;{0}&quot;. 的本地化字符串。
        /// </summary>
        internal static string ErrorCacheConfigurationFailedMessage {
            get {
                return ResourceManager.GetString("ErrorCacheConfigurationFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The error occurred using the &quot;{0}&quot; instance. 的本地化字符串。
        /// </summary>
        internal static string ErrorCacheOperationFailedMessage {
            get {
                return ResourceManager.GetString("ErrorCacheOperationFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Backing Stores with non-default constructors should override GetRegistrations(). 的本地化字符串。
        /// </summary>
        internal static string ExceptionBackingStoresWithNonDefaultConstructorsShouldOverrideGetRegistrations {
            get {
                return ResourceManager.GetString("ExceptionBackingStoresWithNonDefaultConstructorsShouldOverrideGetRegistrations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The format length is invalid. 的本地化字符串。
        /// </summary>
        internal static string ExceptionInvalidExtendedFormatArguments {
            get {
                return ResourceManager.GetString("ExceptionInvalidExtendedFormatArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The file does not exist. 的本地化字符串。
        /// </summary>
        internal static string ExceptionInvalidFileName {
            get {
                return ResourceManager.GetString("ExceptionInvalidFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Must be implemented by subclasses. 的本地化字符串。
        /// </summary>
        internal static string ExceptionMethodMustBeImplementedBySubclasses {
            get {
                return ResourceManager.GetString("ExceptionMethodMustBeImplementedBySubclasses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The file name cannot be null. 的本地化字符串。
        /// </summary>
        internal static string ExceptionNullFileName {
            get {
                return ResourceManager.GetString("ExceptionNullFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Time format cannot be null. 的本地化字符串。
        /// </summary>
        internal static string ExceptionNullTimeFormat {
            get {
                return ResourceManager.GetString("ExceptionNullTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Parameter must implement type &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ExceptionParameterMustImplement {
            get {
                return ResourceManager.GetString("ExceptionParameterMustImplement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Absolute time cannot be less than current time. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeAbsoluteTime {
            get {
                return ResourceManager.GetString("ExceptionRangeAbsoluteTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Day of Week in Extended Format out of range. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeDay {
            get {
                return ResourceManager.GetString("ExceptionRangeDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hour in Extended Format out of range. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeHour {
            get {
                return ResourceManager.GetString("ExceptionRangeHour", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Minutes in Extended Format out of range. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeMinute {
            get {
                return ResourceManager.GetString("ExceptionRangeMinute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Month of Year in Extended Format out of range. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeMonth {
            get {
                return ResourceManager.GetString("ExceptionRangeMonth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sliding time should be greater than or equal to 1s. 的本地化字符串。
        /// </summary>
        internal static string ExceptionRangeSlidingExpiration {
            get {
                return ResourceManager.GetString("ExceptionRangeSlidingExpiration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The storage are name for the Isolated Storage Backing Store can not be null or an empty string. 的本地化字符串。
        /// </summary>
        internal static string ExceptionStorageAreaNullOrEmpty {
            get {
                return ResourceManager.GetString("ExceptionStorageAreaNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Custom Backing Store &apos;{0}&apos; with Type &apos;{1}&apos; must derive from IBackingStore. 的本地化字符串。
        /// </summary>
        internal static string ExceptionTypeForCustomBackingStoreMustDeriveFrom {
            get {
                return ResourceManager.GetString("ExceptionTypeForCustomBackingStoreMustDeriveFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Custom Cache Manager &apos;{0}&apos; with Type &apos;{1}&apos; must derive from ICacheManager. 的本地化字符串。
        /// </summary>
        internal static string ExceptionTypeForCustomCacheManagerMustDeriveFrom {
            get {
                return ResourceManager.GetString("ExceptionTypeForCustomCacheManagerMustDeriveFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failure while removing item from cache in background. 的本地化字符串。
        /// </summary>
        internal static string FailureToRemoveCacheItemInBackground {
            get {
                return ResourceManager.GetString("FailureToRemoveCacheItemInBackground", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failure while starting application-specified refresh action. 的本地化字符串。
        /// </summary>
        internal static string FailureToSpawnUserSpecifiedRefreshAction {
            get {
                return ResourceManager.GetString("FailureToSpawnUserSpecifiedRefreshAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expiration poll frequency time must be at least 1 millisecond. 的本地化字符串。
        /// </summary>
        internal static string InvalidExpirationPollFrequencyInMilliSeconds {
            get {
                return ResourceManager.GetString("InvalidExpirationPollFrequencyInMilliSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot stop polling before it is started. 的本地化字符串。
        /// </summary>
        internal static string InvalidPollingStopOperation {
            get {
                return ResourceManager.GetString("InvalidPollingStopOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Cache Expiries is the total number of items expired from the cache. 的本地化字符串。
        /// </summary>
        internal static string TotalCacheExpiriesCounterHelpResource {
            get {
                return ResourceManager.GetString("TotalCacheExpiriesCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Cache Hits is the total number of requests for existing items received by the cache. 的本地化字符串。
        /// </summary>
        internal static string TotalCacheHitsCounterHelpResource {
            get {
                return ResourceManager.GetString("TotalCacheHitsCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Cache Misses is the total number for non existing items received by the cache. 的本地化字符串。
        /// </summary>
        internal static string TotalCacheMissesCounterHelpResource {
            get {
                return ResourceManager.GetString("TotalCacheMissesCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Cache Scavenged Items is the total number of items scavenged from the cache. 的本地化字符串。
        /// </summary>
        internal static string TotalCacheScavengedItemsCounterHelpResource {
            get {
                return ResourceManager.GetString("TotalCacheScavengedItemsCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Total Updated Entries is the total number of items updated in the cache. An update can be either an &quot;add&quot; or a &quot;remove&quot;. 的本地化字符串。
        /// </summary>
        internal static string TotalCacheUpdatedEntriesHelpResource {
            get {
                return ResourceManager.GetString("TotalCacheUpdatedEntriesHelpResource", resourceCulture);
            }
        }
    }
}