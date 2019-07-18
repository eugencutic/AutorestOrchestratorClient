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
    /// Defines values for IEdmSchemaElementSchemaElementKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IEdmSchemaElementSchemaElementKind
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "TypeDefinition")]
        TypeDefinition,
        [EnumMember(Value = "Term")]
        Term,
        [EnumMember(Value = "Action")]
        Action,
        [EnumMember(Value = "EntityContainer")]
        EntityContainer,
        [EnumMember(Value = "Function")]
        Function
    }
    internal static class IEdmSchemaElementSchemaElementKindEnumExtension
    {
        internal static string ToSerializedValue(this IEdmSchemaElementSchemaElementKind? value)
        {
            return value == null ? null : ((IEdmSchemaElementSchemaElementKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IEdmSchemaElementSchemaElementKind value)
        {
            switch( value )
            {
                case IEdmSchemaElementSchemaElementKind.None:
                    return "None";
                case IEdmSchemaElementSchemaElementKind.TypeDefinition:
                    return "TypeDefinition";
                case IEdmSchemaElementSchemaElementKind.Term:
                    return "Term";
                case IEdmSchemaElementSchemaElementKind.Action:
                    return "Action";
                case IEdmSchemaElementSchemaElementKind.EntityContainer:
                    return "EntityContainer";
                case IEdmSchemaElementSchemaElementKind.Function:
                    return "Function";
            }
            return null;
        }

        internal static IEdmSchemaElementSchemaElementKind? ParseIEdmSchemaElementSchemaElementKind(this string value)
        {
            switch( value )
            {
                case "None":
                    return IEdmSchemaElementSchemaElementKind.None;
                case "TypeDefinition":
                    return IEdmSchemaElementSchemaElementKind.TypeDefinition;
                case "Term":
                    return IEdmSchemaElementSchemaElementKind.Term;
                case "Action":
                    return IEdmSchemaElementSchemaElementKind.Action;
                case "EntityContainer":
                    return IEdmSchemaElementSchemaElementKind.EntityContainer;
                case "Function":
                    return IEdmSchemaElementSchemaElementKind.Function;
            }
            return null;
        }
    }
}
