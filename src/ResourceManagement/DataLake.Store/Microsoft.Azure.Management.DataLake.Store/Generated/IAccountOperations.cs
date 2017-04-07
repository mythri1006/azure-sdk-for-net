// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AccountOperations operations.
    /// </summary>
    public partial interface IAccountOperations
    {
        /// <summary>
        /// Creates the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to create.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataLakeStoreAccount>> CreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Store account information.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataLakeStoreAccount>> UpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccountUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataLakeStoreAccount>> GetWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attempts to enable a user managed key vault for encryption of the
        /// specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to attempt to enable the
        /// Key Vault for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> EnableKeyVaultWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource
        /// group. The response includes a link to the next page of results, if
        /// any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account(s).
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to just
        /// those requested, e.g. Categories?$select=CategoryName,Description.
        /// Optional.
        /// </param>
        /// <param name='count'>
        /// A Boolean value of true or false to request a count of the matching
        /// resources included with the resources in the response, e.g.
        /// Categories?$count=true. Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The
        /// response includes a link to the next page of results, if any.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to just
        /// those requested, e.g. Categories?$select=CategoryName,Description.
        /// Optional.
        /// </param>
        /// <param name='count'>
        /// The Boolean value of true or false to request a count of the
        /// matching resources included with the resources in the response,
        /// e.g. Categories?$count=true. Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListWithHttpMessagesAsync(ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to create.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataLakeStoreAccount>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Store account information.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DataLakeStoreAccount>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccountUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource
        /// group. The response includes a link to the next page of results, if
        /// any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The
        /// response includes a link to the next page of results, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
