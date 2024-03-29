// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SetUsersParameters
    {
        /// <summary>
        /// Initializes a new instance of the SetUsersParameters class.
        /// </summary>
        public SetUsersParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetUsersParameters class.
        /// </summary>
        public SetUsersParameters(IList<long?> addedUserIds, IList<long?> removedUserIds)
        {
            AddedUserIds = addedUserIds;
            RemovedUserIds = removedUserIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addedUserIds")]
        public IList<long?> AddedUserIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "removedUserIds")]
        public IList<long?> RemovedUserIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AddedUserIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddedUserIds");
            }
            if (RemovedUserIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemovedUserIds");
            }
        }
    }
}
