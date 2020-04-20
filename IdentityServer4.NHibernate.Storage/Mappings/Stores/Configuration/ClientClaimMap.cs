﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{ 
    internal class ClientClaimMap : ClassMapping<ClientClaim>
    {
        public ClientClaimMap()
        {
            Id(p => p.Id);

            Property(p => p.Type, map => 
            {
                map.Length(250);
                map.NotNullable(true);
            });

            Property(p => p.Value, map => 
            {
                map.Length(250);
                map.NotNullable(true);
            });
        }
    }
}
