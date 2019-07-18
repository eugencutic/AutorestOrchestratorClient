// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmNavigationPropertyBinding
    {
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationPropertyBinding
        /// class.
        /// </summary>
        public IEdmNavigationPropertyBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmNavigationPropertyBinding
        /// class.
        /// </summary>
        public IEdmNavigationPropertyBinding(IEdmNavigationProperty navigationProperty = default(IEdmNavigationProperty), IEdmNavigationSource target = default(IEdmNavigationSource), IEdmPathExpression path = default(IEdmPathExpression))
        {
            NavigationProperty = navigationProperty;
            Target = target;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NavigationProperty")]
        public IEdmNavigationProperty NavigationProperty { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Target")]
        public IEdmNavigationSource Target { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Path")]
        public IEdmPathExpression Path { get; private set; }

    }
}
