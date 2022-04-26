// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the StorageAccount data model. </summary>
    public partial class StorageAccountData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of StorageAccountData. </summary>
        /// <param name="location"> The location. </param>
        public StorageAccountData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<StoragePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of StorageAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Gets the SKU. </param>
        /// <param name="kind"> Gets the Kind. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="extendedLocation"> The extendedLocation of the resource. </param>
        /// <param name="provisioningState"> Gets the status of the storage account at the time the operation was called. </param>
        /// <param name="primaryEndpoints"> Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint. </param>
        /// <param name="primaryLocation"> Gets the location of the primary data center for the storage account. </param>
        /// <param name="statusOfPrimary"> Gets the status indicating whether the primary location of the storage account is available or unavailable. </param>
        /// <param name="lastGeoFailoverOn"> Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS. </param>
        /// <param name="secondaryLocation"> Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS. </param>
        /// <param name="statusOfSecondary"> Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS. </param>
        /// <param name="creationOn"> Gets the creation date and time of the storage account in UTC. </param>
        /// <param name="customDomain"> Gets the custom domain the user assigned to this storage account. </param>
        /// <param name="sasPolicy"> SasPolicy assigned to the storage account. </param>
        /// <param name="keyPolicy"> KeyPolicy assigned to the storage account. </param>
        /// <param name="keyCreationTime"> Storage account keys creation time. </param>
        /// <param name="secondaryEndpoints"> Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS. </param>
        /// <param name="encryption"> Encryption settings to be used for server-side encryption for the storage account. </param>
        /// <param name="accessTier"> Required for storage accounts where kind = BlobStorage. The access tier used for billing. </param>
        /// <param name="azureFilesIdentityBasedAuthentication"> Provides the identity based authentication settings for Azure Files. </param>
        /// <param name="enableHttpsTrafficOnly"> Allows https traffic only to storage service if sets to true. </param>
        /// <param name="networkRuleSet"> Network rule set. </param>
        /// <param name="isSftpEnabled"> Enables Secure File Transfer Protocol, if set to true. </param>
        /// <param name="isLocalUserEnabled"> Enables local users feature, if set to true. </param>
        /// <param name="isHnsEnabled"> Account HierarchicalNamespace enabled if sets to true. </param>
        /// <param name="geoReplicationStats"> Geo Replication Stats. </param>
        /// <param name="failoverInProgress"> If the failover is in progress, the value will be true, otherwise, it will be null. </param>
        /// <param name="largeFileSharesState"> Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection associated with the specified storage account. </param>
        /// <param name="routingPreference"> Maintains information about the network routing choice opted by the user for data transfer. </param>
        /// <param name="blobRestoreStatus"> Blob restore status. </param>
        /// <param name="allowBlobPublicAccess"> Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property. </param>
        /// <param name="minimumTlsVersion"> Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property. </param>
        /// <param name="allowSharedKeyAccess"> Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true. </param>
        /// <param name="enableNfsV3"> NFS 3.0 protocol support enabled if set to true. </param>
        /// <param name="allowCrossTenantReplication"> Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property. </param>
        /// <param name="defaultToOAuthAuthentication"> A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property. </param>
        /// <param name="publicNetworkAccess"> Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="immutableStorageWithVersioning"> The property is immutable and can only be set to true at the account creation time. When set to true, it enables object level immutability for all the containers in the account by default. </param>
        /// <param name="allowedCopyScope"> Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. </param>
        internal StorageAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, StorageSku sku, StorageKind? kind, ManagedServiceIdentity identity, ExtendedLocation extendedLocation, ProvisioningState? provisioningState, Endpoints primaryEndpoints, string primaryLocation, AccountStatus? statusOfPrimary, DateTimeOffset? lastGeoFailoverOn, string secondaryLocation, AccountStatus? statusOfSecondary, DateTimeOffset? creationOn, CustomDomain customDomain, SasPolicy sasPolicy, KeyPolicy keyPolicy, KeyCreationTime keyCreationTime, Endpoints secondaryEndpoints, Encryption encryption, AccessTier? accessTier, AzureFilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication, bool? enableHttpsTrafficOnly, NetworkRuleSet networkRuleSet, bool? isSftpEnabled, bool? isLocalUserEnabled, bool? isHnsEnabled, GeoReplicationStats geoReplicationStats, bool? failoverInProgress, LargeFileSharesState? largeFileSharesState, IReadOnlyList<StoragePrivateEndpointConnectionData> privateEndpointConnections, RoutingPreference routingPreference, BlobRestoreStatus blobRestoreStatus, bool? allowBlobPublicAccess, MinimumTlsVersion? minimumTlsVersion, bool? allowSharedKeyAccess, bool? enableNfsV3, bool? allowCrossTenantReplication, bool? defaultToOAuthAuthentication, PublicNetworkAccess? publicNetworkAccess, ImmutableStorageAccount immutableStorageWithVersioning, AllowedCopyScope? allowedCopyScope) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Kind = kind;
            Identity = identity;
            ExtendedLocation = extendedLocation;
            ProvisioningState = provisioningState;
            PrimaryEndpoints = primaryEndpoints;
            PrimaryLocation = primaryLocation;
            StatusOfPrimary = statusOfPrimary;
            LastGeoFailoverOn = lastGeoFailoverOn;
            SecondaryLocation = secondaryLocation;
            StatusOfSecondary = statusOfSecondary;
            CreationOn = creationOn;
            CustomDomain = customDomain;
            SasPolicy = sasPolicy;
            KeyPolicy = keyPolicy;
            KeyCreationTime = keyCreationTime;
            SecondaryEndpoints = secondaryEndpoints;
            Encryption = encryption;
            AccessTier = accessTier;
            AzureFilesIdentityBasedAuthentication = azureFilesIdentityBasedAuthentication;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            NetworkRuleSet = networkRuleSet;
            IsSftpEnabled = isSftpEnabled;
            IsLocalUserEnabled = isLocalUserEnabled;
            IsHnsEnabled = isHnsEnabled;
            GeoReplicationStats = geoReplicationStats;
            FailoverInProgress = failoverInProgress;
            LargeFileSharesState = largeFileSharesState;
            PrivateEndpointConnections = privateEndpointConnections;
            RoutingPreference = routingPreference;
            BlobRestoreStatus = blobRestoreStatus;
            AllowBlobPublicAccess = allowBlobPublicAccess;
            MinimumTlsVersion = minimumTlsVersion;
            AllowSharedKeyAccess = allowSharedKeyAccess;
            EnableNfsV3 = enableNfsV3;
            AllowCrossTenantReplication = allowCrossTenantReplication;
            DefaultToOAuthAuthentication = defaultToOAuthAuthentication;
            PublicNetworkAccess = publicNetworkAccess;
            ImmutableStorageWithVersioning = immutableStorageWithVersioning;
            AllowedCopyScope = allowedCopyScope;
        }

        /// <summary> Gets the SKU. </summary>
        public StorageSku Sku { get; }
        /// <summary> Gets the Kind. </summary>
        public StorageKind? Kind { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The extendedLocation of the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Gets the status of the storage account at the time the operation was called. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint. </summary>
        public Endpoints PrimaryEndpoints { get; }
        /// <summary> Gets the location of the primary data center for the storage account. </summary>
        public string PrimaryLocation { get; }
        /// <summary> Gets the status indicating whether the primary location of the storage account is available or unavailable. </summary>
        public AccountStatus? StatusOfPrimary { get; }
        /// <summary> Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS. </summary>
        public DateTimeOffset? LastGeoFailoverOn { get; }
        /// <summary> Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS. </summary>
        public string SecondaryLocation { get; }
        /// <summary> Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS. </summary>
        public AccountStatus? StatusOfSecondary { get; }
        /// <summary> Gets the creation date and time of the storage account in UTC. </summary>
        public DateTimeOffset? CreationOn { get; }
        /// <summary> Gets the custom domain the user assigned to this storage account. </summary>
        public CustomDomain CustomDomain { get; }
        /// <summary> SasPolicy assigned to the storage account. </summary>
        public SasPolicy SasPolicy { get; }
        /// <summary> KeyPolicy assigned to the storage account. </summary>
        internal KeyPolicy KeyPolicy { get; }
        /// <summary> The key expiration period in days. </summary>
        public int KeyExpirationPeriodInDays
        {
            get => KeyPolicy.KeyExpirationPeriodInDays;
            set => KeyPolicy.KeyExpirationPeriodInDays = value;
        }

        /// <summary> Storage account keys creation time. </summary>
        public KeyCreationTime KeyCreationTime { get; }
        /// <summary> Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS. </summary>
        public Endpoints SecondaryEndpoints { get; }
        /// <summary> Encryption settings to be used for server-side encryption for the storage account. </summary>
        public Encryption Encryption { get; }
        /// <summary> Required for storage accounts where kind = BlobStorage. The access tier used for billing. </summary>
        public AccessTier? AccessTier { get; }
        /// <summary> Provides the identity based authentication settings for Azure Files. </summary>
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }
        /// <summary> Allows https traffic only to storage service if sets to true. </summary>
        public bool? EnableHttpsTrafficOnly { get; set; }
        /// <summary> Network rule set. </summary>
        public NetworkRuleSet NetworkRuleSet { get; }
        /// <summary> Enables Secure File Transfer Protocol, if set to true. </summary>
        public bool? IsSftpEnabled { get; set; }
        /// <summary> Enables local users feature, if set to true. </summary>
        public bool? IsLocalUserEnabled { get; set; }
        /// <summary> Account HierarchicalNamespace enabled if sets to true. </summary>
        public bool? IsHnsEnabled { get; set; }
        /// <summary> Geo Replication Stats. </summary>
        public GeoReplicationStats GeoReplicationStats { get; }
        /// <summary> If the failover is in progress, the value will be true, otherwise, it will be null. </summary>
        public bool? FailoverInProgress { get; }
        /// <summary> Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled. </summary>
        public LargeFileSharesState? LargeFileSharesState { get; set; }
        /// <summary> List of private endpoint connection associated with the specified storage account. </summary>
        public IReadOnlyList<StoragePrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Maintains information about the network routing choice opted by the user for data transfer. </summary>
        public RoutingPreference RoutingPreference { get; set; }
        /// <summary> Blob restore status. </summary>
        public BlobRestoreStatus BlobRestoreStatus { get; }
        /// <summary> Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property. </summary>
        public bool? AllowBlobPublicAccess { get; set; }
        /// <summary> Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property. </summary>
        public MinimumTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true. </summary>
        public bool? AllowSharedKeyAccess { get; set; }
        /// <summary> NFS 3.0 protocol support enabled if set to true. </summary>
        public bool? EnableNfsV3 { get; set; }
        /// <summary> Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property. </summary>
        public bool? AllowCrossTenantReplication { get; set; }
        /// <summary> A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property. </summary>
        public bool? DefaultToOAuthAuthentication { get; set; }
        /// <summary> Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The property is immutable and can only be set to true at the account creation time. When set to true, it enables object level immutability for all the containers in the account by default. </summary>
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }
        /// <summary> Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. </summary>
        public AllowedCopyScope? AllowedCopyScope { get; set; }
    }
}
