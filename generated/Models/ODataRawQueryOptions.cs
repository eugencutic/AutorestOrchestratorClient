// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataRawQueryOptions
    {
        /// <summary>
        /// Initializes a new instance of the ODataRawQueryOptions class.
        /// </summary>
        public ODataRawQueryOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataRawQueryOptions class.
        /// </summary>
        public ODataRawQueryOptions(string filter = default(string), string apply = default(string), string orderBy = default(string), string top = default(string), string skip = default(string), string select = default(string), string expand = default(string), string count = default(string), string format = default(string), string skipToken = default(string), string deltaToken = default(string))
        {
            Filter = filter;
            Apply = apply;
            OrderBy = orderBy;
            Top = top;
            Skip = skip;
            Select = select;
            Expand = expand;
            Count = count;
            Format = format;
            SkipToken = skipToken;
            DeltaToken = deltaToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Filter")]
        public string Filter { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Apply")]
        public string Apply { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderBy")]
        public string OrderBy { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Top")]
        public string Top { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Skip")]
        public string Skip { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Select")]
        public string Select { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Expand")]
        public string Expand { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public string Count { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Format")]
        public string Format { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SkipToken")]
        public string SkipToken { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeltaToken")]
        public string DeltaToken { get; private set; }

    }
}
