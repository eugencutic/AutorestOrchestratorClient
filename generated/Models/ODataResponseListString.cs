// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListString
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListString class.
        /// </summary>
        public ODataResponseListString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListString class.
        /// </summary>
        public ODataResponseListString(string odatacontext = default(string), IList<string> value = default(IList<string>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }

    }
}
