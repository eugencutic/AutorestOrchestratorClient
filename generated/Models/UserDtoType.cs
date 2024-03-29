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
    /// Defines values for UserDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserDtoType
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
    internal static class UserDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this UserDtoType? value)
        {
            return value == null ? null : ((UserDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UserDtoType value)
        {
            switch( value )
            {
                case UserDtoType.User:
                    return "User";
                case UserDtoType.Robot:
                    return "Robot";
                case UserDtoType.DirectoryUser:
                    return "DirectoryUser";
                case UserDtoType.DirectoryGroup:
                    return "DirectoryGroup";
            }
            return null;
        }

        internal static UserDtoType? ParseUserDtoType(this string value)
        {
            switch( value )
            {
                case "User":
                    return UserDtoType.User;
                case "Robot":
                    return UserDtoType.Robot;
                case "DirectoryUser":
                    return UserDtoType.DirectoryUser;
                case "DirectoryGroup":
                    return UserDtoType.DirectoryGroup;
            }
            return null;
        }
    }
}
