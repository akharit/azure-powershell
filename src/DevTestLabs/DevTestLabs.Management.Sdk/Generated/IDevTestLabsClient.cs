// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The DevTest Labs Client.
    /// </summary>
    public partial interface IDevTestLabsClient :  System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get;}


        /// <summary>
        /// The API version to use for this operation.
        /// </summary>
        string ApiVersion { get;}


        /// <summary>
        /// The name of the resource group.
        /// </summary>
        string ResourceGroupName { get; set;}


        /// <summary>
        /// The subscription ID.
        /// </summary>
        string SubscriptionId { get; set;}


        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set;}


        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set;}


        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// /// set to true a unique x-ms-client-request-id value is generated and
        /// /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set;}


        /// <summary>
        /// Gets the IProviderOperations
        /// </summary>
        IProviderOperations ProviderOperations { get; }

        /// <summary>
        /// Gets the ILabsOperations
        /// </summary>
        ILabsOperations Labs { get; }

        /// <summary>
        /// Gets the IOperations
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IGlobalSchedulesOperations
        /// </summary>
        IGlobalSchedulesOperations GlobalSchedules { get; }

        /// <summary>
        /// Gets the IArtifactSourcesOperations
        /// </summary>
        IArtifactSourcesOperations ArtifactSources { get; }

        /// <summary>
        /// Gets the IArmTemplatesOperations
        /// </summary>
        IArmTemplatesOperations ArmTemplates { get; }

        /// <summary>
        /// Gets the IArtifactsOperations
        /// </summary>
        IArtifactsOperations Artifacts { get; }

        /// <summary>
        /// Gets the ICostsOperations
        /// </summary>
        ICostsOperations Costs { get; }

        /// <summary>
        /// Gets the ICustomImagesOperations
        /// </summary>
        ICustomImagesOperations CustomImages { get; }

        /// <summary>
        /// Gets the IFormulasOperations
        /// </summary>
        IFormulasOperations Formulas { get; }

        /// <summary>
        /// Gets the IGalleryImagesOperations
        /// </summary>
        IGalleryImagesOperations GalleryImages { get; }

        /// <summary>
        /// Gets the INotificationChannelsOperations
        /// </summary>
        INotificationChannelsOperations NotificationChannels { get; }

        /// <summary>
        /// Gets the IPolicySetsOperations
        /// </summary>
        IPolicySetsOperations PolicySets { get; }

        /// <summary>
        /// Gets the IPoliciesOperations
        /// </summary>
        IPoliciesOperations Policies { get; }

        /// <summary>
        /// Gets the ISchedulesOperations
        /// </summary>
        ISchedulesOperations Schedules { get; }

        /// <summary>
        /// Gets the IServiceRunnersOperations
        /// </summary>
        IServiceRunnersOperations ServiceRunners { get; }

        /// <summary>
        /// Gets the IUsersOperations
        /// </summary>
        IUsersOperations Users { get; }

        /// <summary>
        /// Gets the IDisksOperations
        /// </summary>
        IDisksOperations Disks { get; }

        /// <summary>
        /// Gets the IEnvironmentsOperations
        /// </summary>
        IEnvironmentsOperations Environments { get; }

        /// <summary>
        /// Gets the ISecretsOperations
        /// </summary>
        ISecretsOperations Secrets { get; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations
        /// </summary>
        IVirtualMachinesOperations VirtualMachines { get; }

        /// <summary>
        /// Gets the IVirtualMachineSchedulesOperations
        /// </summary>
        IVirtualMachineSchedulesOperations VirtualMachineSchedules { get; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations
        /// </summary>
        IVirtualNetworksOperations VirtualNetworks { get; }

    }
}