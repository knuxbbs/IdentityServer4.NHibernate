﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ApiSecretMap : ClassMapping<ApiSecret>
    {
        public ApiSecretMap()
        {
            Id(p => p.Id);

            Property(p => p.Description, map => map.Length(1000));
            Property(p => p.Value, map => map.Length(2000));
            Property(p => p.Type, map => map.Length(250));
        }
    }
}
