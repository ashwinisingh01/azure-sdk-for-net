// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A Class representing a WordPressInstanceResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WordPressInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWordPressInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="PhpWorkloadResource" /> using the GetWordPressInstanceResource method.
    /// </summary>
    public partial class WordPressInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WordPressInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string phpWorkloadName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _wordPressInstanceResourceWordPressInstancesClientDiagnostics;
        private readonly WordpressInstancesRestOperations _wordPressInstanceResourceWordPressInstancesRestClient;
        private readonly WordPressInstanceResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="WordPressInstanceResource"/> class for mocking. </summary>
        protected WordPressInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WordPressInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WordPressInstanceResource(ArmClient client, WordPressInstanceResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WordPressInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WordPressInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _wordPressInstanceResourceWordPressInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string wordPressInstanceResourceWordPressInstancesApiVersion);
            _wordPressInstanceResourceWordPressInstancesRestClient = new WordpressInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, wordPressInstanceResourceWordPressInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Workloads/phpWorkloads/wordpressInstances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WordPressInstanceResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WordPressInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _wordPressInstanceResourceWordPressInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WordPressInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WordPressInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _wordPressInstanceResourceWordPressInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WordPressInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.Delete");
            scope.Start();
            try
            {
                var response = await _wordPressInstanceResourceWordPressInstancesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.Delete");
            scope.Start();
            try
            {
                var response = _wordPressInstanceResourceWordPressInstancesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                var operation = new WorkloadsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or updated WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create or update request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WordPressInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, WordPressInstanceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _wordPressInstanceResourceWordPressInstancesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<WordPressInstanceResource>(new WordPressInstanceResourceOperationSource(Client), _wordPressInstanceResourceWordPressInstancesClientDiagnostics, Pipeline, _wordPressInstanceResourceWordPressInstancesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or updated WordPress instance resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/phpWorkloads/{phpWorkloadName}/wordpressInstances/default
        /// Operation Id: WordpressInstances_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create or update request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WordPressInstanceResource> CreateOrUpdate(WaitUntil waitUntil, WordPressInstanceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _wordPressInstanceResourceWordPressInstancesClientDiagnostics.CreateScope("WordPressInstanceResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _wordPressInstanceResourceWordPressInstancesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new WorkloadsArmOperation<WordPressInstanceResource>(new WordPressInstanceResourceOperationSource(Client), _wordPressInstanceResourceWordPressInstancesClientDiagnostics, Pipeline, _wordPressInstanceResourceWordPressInstancesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
