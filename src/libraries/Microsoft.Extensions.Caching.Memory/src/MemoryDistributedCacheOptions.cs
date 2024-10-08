// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Caching.Memory
{
    /// <summary>
    /// Specifies options for <see cref="MemoryDistributedCacheOptions"/>.
    /// </summary>
    public class MemoryDistributedCacheOptions : MemoryCacheOptions
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MemoryDistributedCacheOptions"/>.
        /// </summary>
        public MemoryDistributedCacheOptions()
            : base()
        {
            // Default size limit of 200 MB
            SizeLimit = 200 * 1024 * 1024;
        }
    }
}
