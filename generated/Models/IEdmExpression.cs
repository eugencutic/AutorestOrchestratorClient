// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmExpression
    {
        /// <summary>
        /// Initializes a new instance of the IEdmExpression class.
        /// </summary>
        public IEdmExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmExpression class.
        /// </summary>
        /// <param name="expressionKind">Possible values include: 'None',
        /// 'BinaryConstant', 'BooleanConstant', 'DateTimeOffsetConstant',
        /// 'DecimalConstant', 'FloatingConstant', 'GuidConstant',
        /// 'IntegerConstant', 'StringConstant', 'DurationConstant', 'Null',
        /// 'Record', 'Collection', 'Path', 'If', 'Cast', 'IsType',
        /// 'FunctionApplication', 'LabeledExpressionReference', 'Labeled',
        /// 'PropertyPath', 'NavigationPropertyPath', 'DateConstant',
        /// 'TimeOfDayConstant', 'EnumMember', 'AnnotationPath'</param>
        public IEdmExpression(IEdmExpressionExpressionKind? expressionKind = default(IEdmExpressionExpressionKind?))
        {
            ExpressionKind = expressionKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'None', 'BinaryConstant',
        /// 'BooleanConstant', 'DateTimeOffsetConstant', 'DecimalConstant',
        /// 'FloatingConstant', 'GuidConstant', 'IntegerConstant',
        /// 'StringConstant', 'DurationConstant', 'Null', 'Record',
        /// 'Collection', 'Path', 'If', 'Cast', 'IsType',
        /// 'FunctionApplication', 'LabeledExpressionReference', 'Labeled',
        /// 'PropertyPath', 'NavigationPropertyPath', 'DateConstant',
        /// 'TimeOfDayConstant', 'EnumMember', 'AnnotationPath'
        /// </summary>
        [JsonProperty(PropertyName = "ExpressionKind")]
        public IEdmExpressionExpressionKind? ExpressionKind { get; private set; }

    }
}
