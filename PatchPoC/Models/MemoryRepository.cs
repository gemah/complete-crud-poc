using System.Collections.Generic;

namespace PatchPoC.Models
{
    /// <summary>
    /// Implements an in Memory Stub of a repository based in (Key, Value), similarly to a Web Storage table.
    /// </summary>
    public static class MemoryRepository
    {
        /// <summary>
        /// The repository where data will be saved to while the program is running.
        /// </summary>
        public static IDictionary<int, SampleEntity> repository = new Dictionary<int, SampleEntity>();
    }
}
