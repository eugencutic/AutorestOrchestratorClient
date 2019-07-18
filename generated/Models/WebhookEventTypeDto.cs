// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookEventTypeDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookEventTypeDto class.
        /// </summary>
        public WebhookEventTypeDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookEventTypeDto class.
        /// </summary>
        /// <param name="name">Event type key</param>
        /// <param name="group">Group</param>
        public WebhookEventTypeDto(string name = default(string), string group = default(string))
        {
            Name = name;
            Group = group;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets event type key
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets group
        /// </summary>
        [JsonProperty(PropertyName = "Group")]
        public string Group { get; set; }

    }
}
