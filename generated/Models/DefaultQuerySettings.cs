// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DefaultQuerySettings
    {
        /// <summary>
        /// Initializes a new instance of the DefaultQuerySettings class.
        /// </summary>
        public DefaultQuerySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultQuerySettings class.
        /// </summary>
        public DefaultQuerySettings(bool? enableExpand = default(bool?), bool? enableSelect = default(bool?), bool? enableCount = default(bool?), bool? enableOrderBy = default(bool?), bool? enableFilter = default(bool?), int? maxTop = default(int?))
        {
            EnableExpand = enableExpand;
            EnableSelect = enableSelect;
            EnableCount = enableCount;
            EnableOrderBy = enableOrderBy;
            EnableFilter = enableFilter;
            MaxTop = maxTop;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableExpand")]
        public bool? EnableExpand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableSelect")]
        public bool? EnableSelect { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableCount")]
        public bool? EnableCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableOrderBy")]
        public bool? EnableOrderBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EnableFilter")]
        public bool? EnableFilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxTop")]
        public int? MaxTop { get; set; }

    }
}
