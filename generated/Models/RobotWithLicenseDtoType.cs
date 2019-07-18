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
    /// Defines values for RobotWithLicenseDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotWithLicenseDtoType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class RobotWithLicenseDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotWithLicenseDtoType? value)
        {
            return value == null ? null : ((RobotWithLicenseDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotWithLicenseDtoType value)
        {
            switch( value )
            {
                case RobotWithLicenseDtoType.NonProduction:
                    return "NonProduction";
                case RobotWithLicenseDtoType.Attended:
                    return "Attended";
                case RobotWithLicenseDtoType.Unattended:
                    return "Unattended";
                case RobotWithLicenseDtoType.Development:
                    return "Development";
            }
            return null;
        }

        internal static RobotWithLicenseDtoType? ParseRobotWithLicenseDtoType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return RobotWithLicenseDtoType.NonProduction;
                case "Attended":
                    return RobotWithLicenseDtoType.Attended;
                case "Unattended":
                    return RobotWithLicenseDtoType.Unattended;
                case "Development":
                    return RobotWithLicenseDtoType.Development;
            }
            return null;
        }
    }
}
