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

    /// <summary>
    /// A role acts as a grouping of permissions. Roles are associated with
    /// users to provide application authorization.
    /// </summary>
    public partial class RoleDto
    {
        /// <summary>
        /// Initializes a new instance of the RoleDto class.
        /// </summary>
        public RoleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDto class.
        /// </summary>
        /// <param name="name">A custom name for the role.</param>
        /// <param name="displayName">An alternative name used for UI
        /// display.</param>
        /// <param name="groups">Allows grouping multiple roles
        /// together.</param>
        /// <param name="isStatic">States whether this role is defined by the
        /// application and cannot be deleted or it is user defined and can be
        /// deleted.</param>
        /// <param name="isEditable">States whether the permissions for this
        /// role can be modified or not.</param>
        /// <param name="permissions">The collection of application permissions
        /// associated with the role.</param>
        public RoleDto(string name = default(string), string displayName = default(string), string groups = default(string), bool? isStatic = default(bool?), bool? isEditable = default(bool?), IList<PermissionDto> permissions = default(IList<PermissionDto>), int? id = default(int?))
        {
            Name = name;
            DisplayName = displayName;
            Groups = groups;
            IsStatic = isStatic;
            IsEditable = isEditable;
            Permissions = permissions;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a custom name for the role.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an alternative name used for UI display.
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets allows grouping multiple roles together.
        /// </summary>
        [JsonProperty(PropertyName = "Groups")]
        public string Groups { get; set; }

        /// <summary>
        /// Gets or sets states whether this role is defined by the application
        /// and cannot be deleted or it is user defined and can be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "IsStatic")]
        public bool? IsStatic { get; set; }

        /// <summary>
        /// Gets or sets states whether the permissions for this role can be
        /// modified or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsEditable")]
        public bool? IsEditable { get; set; }

        /// <summary>
        /// Gets or sets the collection of application permissions associated
        /// with the role.
        /// </summary>
        [JsonProperty(PropertyName = "Permissions")]
        public IList<PermissionDto> Permissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

    }
}
