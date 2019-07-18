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
    /// Defines values for SimpleRobotDtoCredentialType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SimpleRobotDtoCredentialType
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "SmartCard")]
        SmartCard
    }
    internal static class SimpleRobotDtoCredentialTypeEnumExtension
    {
        internal static string ToSerializedValue(this SimpleRobotDtoCredentialType? value)
        {
            return value == null ? null : ((SimpleRobotDtoCredentialType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SimpleRobotDtoCredentialType value)
        {
            switch( value )
            {
                case SimpleRobotDtoCredentialType.Default:
                    return "Default";
                case SimpleRobotDtoCredentialType.SmartCard:
                    return "SmartCard";
            }
            return null;
        }

        internal static SimpleRobotDtoCredentialType? ParseSimpleRobotDtoCredentialType(this string value)
        {
            switch( value )
            {
                case "Default":
                    return SimpleRobotDtoCredentialType.Default;
                case "SmartCard":
                    return SimpleRobotDtoCredentialType.SmartCard;
            }
            return null;
        }
    }
}
