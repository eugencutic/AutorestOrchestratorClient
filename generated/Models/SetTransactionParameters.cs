// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetTransactionParameters
    {
        /// <summary>
        /// Initializes a new instance of the SetTransactionParameters class.
        /// </summary>
        public SetTransactionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetTransactionParameters class.
        /// </summary>
        public SetTransactionParameters(TransactionResultDto transactionResult = default(TransactionResultDto))
        {
            TransactionResult = transactionResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactionResult")]
        public TransactionResultDto TransactionResult { get; set; }

    }
}
