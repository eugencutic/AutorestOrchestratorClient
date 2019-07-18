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
    /// Defines values for IEdmStructuralPropertyPropertyKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmStructuralPropertyPropertyKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Structural")]
        Structural,
        [EnumMember(Value = "Navigation")]
        Navigation
    }
    internal static class IEdmStructuralPropertyPropertyKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmStructuralPropertyPropertyKind? value)
        {
            return value == null ? null : ((IEdmStructuralPropertyPropertyKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmStructuralPropertyPropertyKind value)
        {
            switch( value )
            {
                case IEdmStructuralPropertyPropertyKind.None:
                    return "None";
                case IEdmStructuralPropertyPropertyKind.Structural:
                    return "Structural";
                case IEdmStructuralPropertyPropertyKind.Navigation:
                    return "Navigation";
            }
            return null;
        }

        internal static IEdmStructuralPropertyPropertyKind? ParseIEdmStructuralPropertyPropertyKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmStructuralPropertyPropertyKind.None;
                case "Structural":
                    return IEdmStructuralPropertyPropertyKind.Structural;
                case "Navigation":
                    return IEdmStructuralPropertyPropertyKind.Navigation;
            }
            return null;
        }
    }
}
