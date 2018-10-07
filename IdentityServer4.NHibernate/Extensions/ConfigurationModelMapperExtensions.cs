﻿using IdentityServer4.NHibernate.Mappings.Storage;
using IdentityServer4.NHibernate.Mappings.Storage.Configuration;
using IdentityServer4.NHibernate.Mappings.Storage.Operational;

namespace IdentityServer4.NHibernate.Extensions
{
    internal static class ConfigurationStoreModelMapperExtensions
    {
        public static ConfigurationStoreModelMapper AddClientContextMappings(this ConfigurationStoreModelMapper mapper)
        {
            mapper.AddMapping<ClientMap>();
            mapper.AddMapping<ClientGrantTypeMap>();
            mapper.AddMapping<ClientSecretMap>();
            mapper.AddMapping<ClientRedirectUriMap>();
            mapper.AddMapping<ClientPostLogoutRedirectUriMap>();
            mapper.AddMapping<ClientScopeMap>();
            mapper.AddMapping<ClientIdPRestrictionMap>();
            mapper.AddMapping<ClientClaimMap>();
            mapper.AddMapping<ClientCorsOriginMap>();
            mapper.AddMapping<ClientPropertyMap>();

            return mapper;
        }

        public static ConfigurationStoreModelMapper AddResourceContextMappings(this ConfigurationStoreModelMapper mapper)
        {
            mapper.AddMapping<IdentityResourceMap>();
            mapper.AddMapping<IdentityClaimMap>();
            mapper.AddMapping<ApiResourceMap>();
            mapper.AddMapping<ApiSecretMap>();
            mapper.AddMapping<ApiResourceClaimMap>();
            mapper.AddMapping<ApiScopeMap>();
            mapper.AddMapping<ApiScopeClaimMap>();

            return mapper;
        }

        public static OperationalStoreModelMapper AddPersistedGrantContextMappings(this OperationalStoreModelMapper mapper)
        {
            mapper.AddMapping<PersistedGrantMap>();

            return mapper;
        }
    }
}
