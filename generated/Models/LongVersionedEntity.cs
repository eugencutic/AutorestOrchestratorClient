// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LongVersionedEntity
    {
        /// <summary>
        /// Initializes a new instance of the LongVersionedEntity class.
        /// </summary>
        public LongVersionedEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LongVersionedEntity class.
        /// </summary>
        public LongVersionedEntity(byte[] rowVersion = default(byte[]), long? id = default(long?))
        {
            RowVersion = rowVersion;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RowVersion")]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
