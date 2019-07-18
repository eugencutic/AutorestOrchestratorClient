// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SkipQueryOption
    {
        /// <summary>
        /// Initializes a new instance of the SkipQueryOption class.
        /// </summary>
        public SkipQueryOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkipQueryOption class.
        /// </summary>
        public SkipQueryOption(ODataQueryContext context = default(ODataQueryContext), string rawValue = default(string), int? value = default(int?), object validator = default(object))
        {
            Context = context;
            RawValue = rawValue;
            Value = value;
            Validator = validator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RawValue")]
        public string RawValue { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public int? Value { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

    }
}
