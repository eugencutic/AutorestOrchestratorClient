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

    public partial class ODataResponseListAuditLogDto
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListAuditLogDto
        /// class.
        /// </summary>
        public ODataResponseListAuditLogDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListAuditLogDto
        /// class.
        /// </summary>
        public ODataResponseListAuditLogDto(string odatacontext = default(string), IList<AuditLogDto> value = default(IList<AuditLogDto>))
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
        public IList<AuditLogDto> Value { get; set; }

    }
}
