// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueueItems operations.
    /// </summary>
    public partial interface IQueueItems
    {
        /// <summary>
        /// Gets a collection of queue items.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.View.
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListQueueItemDto>> GetQueueItemsWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a queue item by Id.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.View.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<QueueItemDto>> GetByIdWithHttpMessagesAsync(long id, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the QueueItem properties with the new values provided.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.Edit and Transactions.Edit.
        ///
        /// Only
        /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemDto.Progress},
        /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemDto.Priority},
        /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemDto.DueDate},
        /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemDto.DeferDate}
        /// and
        /// {UiPath.Orchestrator.Application.Dto.Queues.QueueItemDto.SpecificContent}
        /// will be updated from given queueItemDto object.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='queueItemDto'>
        /// The entity to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> PutByIdWithHttpMessagesAsync(long id, QueueItemDataDto queueItemDto, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a queue item by Id.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Delete.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='ifMatch'>
        /// If-Match header
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long id, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns data about the processing history of the given queue item.
        /// Allows odata query options.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.View.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the odata-count header.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListQueueItemDto>> GetItemProcessingHistoryByIdWithHttpMessagesAsync(long id, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the review status of the specified queue items to an
        /// indicated state.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Edit.
        /// </remarks>
        /// <param name='itemReviewStatusParameters'>
        /// &lt;para /&gt;QueueItems - The collection of ids of queue items for
        /// which the state is set.
        /// &lt;para /&gt;Status - The new value for the review status.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<BulkOperationResponseDtoInt64>> SetItemReviewStatusWithHttpMessagesAsync(ItemReviewStatusParameters itemReviewStatusParameters = default(ItemReviewStatusParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sets the given queue items' status to Deleted.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Delete.
        /// </remarks>
        /// <param name='deleteBulkParameters'>
        /// QueueItems - The collection of ids of queue items to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<BulkOperationResponseDtoInt64>> DeleteBulkWithHttpMessagesAsync(DeleteBulkParameters deleteBulkParameters = default(DeleteBulkParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates the progress field of a queue item with the status 'In
        /// Progress'.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Edit.
        /// </remarks>
        /// <param name='id'>
        /// key: Id
        /// </param>
        /// <param name='transactionProgressParameters'>
        /// &lt;para /&gt;QueueItemId - The item's id.
        /// &lt;para /&gt;Progress - The value for the Progress field.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> SetTransactionProgressByIdWithHttpMessagesAsync(long id, TransactionProgressParameters transactionProgressParameters = default(TransactionProgressParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sets the reviewer for multiple queue items
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Edit.
        /// </remarks>
        /// <param name='setReviewerBulkParameters'>
        /// &lt;para /&gt;UserId - The ID of the user to be set as the
        /// reviewer. If not set, the reviewer is cleared.
        /// &lt;para /&gt;QueueItems - The collection of ids of queue items for
        /// which the reviewer is set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<BulkOperationResponseDtoInt64>> SetItemReviewerWithHttpMessagesAsync(SetReviewerBulkParameters setReviewerBulkParameters, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Unsets the reviewer for multiple queue items
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Edit.
        /// </remarks>
        /// <param name='unsetReviewerBulkParameters'>
        /// &lt;para /&gt;QueueItems - The collection of ids of queue items for
        /// which the reviewer is unset.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<BulkOperationResponseDtoInt64>> UnsetItemReviewerWithHttpMessagesAsync(UnsetReviewerBulkParameters unsetReviewerBulkParameters = default(UnsetReviewerBulkParameters), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a collection of users having the permission for Queue Items
        /// review. Allows odata query options.
        /// </summary>
        /// <remarks>
        /// Required permissions: Queues.View and Transactions.Edit.
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline.
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a Boolean condition.
        /// </param>
        /// <param name='select'>
        /// Selects which properties to include in the response.
        /// </param>
        /// <param name='orderby'>
        /// Sorts the results.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results.
        /// </param>
        /// <param name='count'>
        /// Includes a count of the matching results in the odata-count header.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListUserDto>> GetReviewersWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
