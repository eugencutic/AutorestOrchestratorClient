// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AuditLogDtoUserType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AuditLogDtoUserType
    {
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Robot")]
        Robot,
        [EnumMember(Value = "DirectoryUser")]
        DirectoryUser,
        [EnumMember(Value = "DirectoryGroup")]
        DirectoryGroup
    }
    internal static class AuditLogDtoUserTypeEnumExtension
    {
        internal static string ToSerializedValue(this AuditLogDtoUserType? value)
        {
            return value == null ? null : ((AuditLogDtoUserType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AuditLogDtoUserType value)
        {
            switch( value )
            {
                case AuditLogDtoUserType.User:
                    return "User";
                case AuditLogDtoUserType.Robot:
                    return "Robot";
                case AuditLogDtoUserType.DirectoryUser:
                    return "DirectoryUser";
                case AuditLogDtoUserType.DirectoryGroup:
                    return "DirectoryGroup";
            }
            return null;
        }

        internal static AuditLogDtoUserType? ParseAuditLogDtoUserType(this string value)
        {
            switch( value )
            {
                case "User":
                    return AuditLogDtoUserType.User;
                case "Robot":
                    return AuditLogDtoUserType.Robot;
                case "DirectoryUser":
                    return AuditLogDtoUserType.DirectoryUser;
                case "DirectoryGroup":
                    return AuditLogDtoUserType.DirectoryGroup;
            }
            return null;
        }
    }
}
