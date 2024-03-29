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
    /// Defines values for WebhookSessionDtoLicenseErrorCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSessionDtoLicenseErrorCode
    {
        [EnumMember(Value = "NoLicense")]
        NoLicense,
        [EnumMember(Value = "LicenseExpired")]
        LicenseExpired,
        [EnumMember(Value = "LicenseUnregistered")]
        LicenseUnregistered,
        [EnumMember(Value = "NoAvailableLicenses")]
        NoAvailableLicenses,
        [EnumMember(Value = "NotEnoughAvailableSlots")]
        NotEnoughAvailableSlots,
        [EnumMember(Value = "NotEnoughRuntimeLicenses")]
        NotEnoughRuntimeLicenses,
        [EnumMember(Value = "LicenseIsAlreadyInUse")]
        LicenseIsAlreadyInUse,
        [EnumMember(Value = "InvalidRequest")]
        InvalidRequest,
        [EnumMember(Value = "SlotsExceedLicenseLimit")]
        SlotsExceedLicenseLimit,
        [EnumMember(Value = "RuntimeDisabled")]
        RuntimeDisabled
    }
    internal static class WebhookSessionDtoLicenseErrorCodeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookSessionDtoLicenseErrorCode? value)
        {
            return value == null ? null : ((WebhookSessionDtoLicenseErrorCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookSessionDtoLicenseErrorCode value)
        {
            switch( value )
            {
                case WebhookSessionDtoLicenseErrorCode.NoLicense:
                    return "NoLicense";
                case WebhookSessionDtoLicenseErrorCode.LicenseExpired:
                    return "LicenseExpired";
                case WebhookSessionDtoLicenseErrorCode.LicenseUnregistered:
                    return "LicenseUnregistered";
                case WebhookSessionDtoLicenseErrorCode.NoAvailableLicenses:
                    return "NoAvailableLicenses";
                case WebhookSessionDtoLicenseErrorCode.NotEnoughAvailableSlots:
                    return "NotEnoughAvailableSlots";
                case WebhookSessionDtoLicenseErrorCode.NotEnoughRuntimeLicenses:
                    return "NotEnoughRuntimeLicenses";
                case WebhookSessionDtoLicenseErrorCode.LicenseIsAlreadyInUse:
                    return "LicenseIsAlreadyInUse";
                case WebhookSessionDtoLicenseErrorCode.InvalidRequest:
                    return "InvalidRequest";
                case WebhookSessionDtoLicenseErrorCode.SlotsExceedLicenseLimit:
                    return "SlotsExceedLicenseLimit";
                case WebhookSessionDtoLicenseErrorCode.RuntimeDisabled:
                    return "RuntimeDisabled";
            }
            return null;
        }

        internal static WebhookSessionDtoLicenseErrorCode? ParseWebhookSessionDtoLicenseErrorCode(this string value)
        {
            switch( value )
            {
                case "NoLicense":
                    return WebhookSessionDtoLicenseErrorCode.NoLicense;
                case "LicenseExpired":
                    return WebhookSessionDtoLicenseErrorCode.LicenseExpired;
                case "LicenseUnregistered":
                    return WebhookSessionDtoLicenseErrorCode.LicenseUnregistered;
                case "NoAvailableLicenses":
                    return WebhookSessionDtoLicenseErrorCode.NoAvailableLicenses;
                case "NotEnoughAvailableSlots":
                    return WebhookSessionDtoLicenseErrorCode.NotEnoughAvailableSlots;
                case "NotEnoughRuntimeLicenses":
                    return WebhookSessionDtoLicenseErrorCode.NotEnoughRuntimeLicenses;
                case "LicenseIsAlreadyInUse":
                    return WebhookSessionDtoLicenseErrorCode.LicenseIsAlreadyInUse;
                case "InvalidRequest":
                    return WebhookSessionDtoLicenseErrorCode.InvalidRequest;
                case "SlotsExceedLicenseLimit":
                    return WebhookSessionDtoLicenseErrorCode.SlotsExceedLicenseLimit;
                case "RuntimeDisabled":
                    return WebhookSessionDtoLicenseErrorCode.RuntimeDisabled;
            }
            return null;
        }
    }
}
