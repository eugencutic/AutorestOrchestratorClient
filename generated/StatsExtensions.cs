// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Stats.
    /// </summary>
    public static partial class StatsExtensions
    {
            /// <summary>
            /// Gets the total number of various entities registered in Orchestrator
            /// </summary>
            /// <remarks>
            /// Requires authentication.
            ///
            /// Returns the name and the total number of entities registered in
            /// Orchestrator for a set of entities.
            /// All the counted entity types can be seen in the result below.
            /// [
            /// {
            /// "title": "Processes",
            /// "count": 1
            /// },
            /// {
            /// "title": "Assets",
            /// "count": 0
            /// },
            /// {
            /// "title": "Queues",
            /// "count": 0
            /// },
            /// {
            /// "title": "Schedules",
            /// "count": 0
            /// }
            /// ]
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CountStats>> GetCountStatsAsync(this IStats operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetCountStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the total number of robots aggregated by Robot State
            /// </summary>
            /// <remarks>
            /// Required permissions: Robots.View.
            ///
            /// Returns the total number of Available, Busy, Disconnected and Unresponsive
            /// robots respectively.
            /// Example of returned result:
            /// [
            /// {
            /// "title": "Available",
            /// "count": 1
            /// },
            /// {
            /// "title": "Busy",
            /// "count": 0
            /// },
            /// {
            /// "title": "Disconnected",
            /// "count": 1
            /// },
            /// {
            /// "title": "Unresponsive",
            /// "count": 0
            /// }
            /// ]
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CountStats>> GetSessionsStatsAsync(this IStats operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSessionsStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the total number of jobs aggregated by Job State
            /// </summary>
            /// <remarks>
            /// Required permissions: Jobs.View.
            ///
            /// Returns the total number of Successful, Faulted and Canceled jobs
            /// respectively.
            /// Example of returned result:
            /// [
            /// {
            /// "title": "Successful",
            /// "count": 0
            /// },
            /// {
            /// "title": "Faulted",
            /// "count": 0
            /// },
            /// {
            /// "title": "Canceled",
            /// "count": 0
            /// }
            /// ]
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CountStats>> GetJobsStatsAsync(this IStats operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetJobsStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the licensing usage statistics
            /// </summary>
            /// <remarks>
            /// Required permissions: License.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// The Tenant's Id - can be used when authenticated as Host
            /// </param>
            /// <param name='days'>
            /// Number of reported license usage days
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LicenseStatsModel>> GetLicenseStatsAsync(this IStats operations, int tenantId, int days, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetLicenseStatsWithHttpMessagesAsync(tenantId, days, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
