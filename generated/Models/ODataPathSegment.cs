// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ODataPathSegment
    {
        /// <summary>
        /// Initializes a new instance of the ODataPathSegment class.
        /// </summary>
        public ODataPathSegment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataPathSegment class.
        /// </summary>
        public ODataPathSegment(IEdmType edmType = default(IEdmType), string identifier = default(string))
        {
            EdmType = edmType;
            Identifier = identifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EdmType")]
        public IEdmType EdmType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Identifier")]
        public string Identifier { get; set; }

    }
}
