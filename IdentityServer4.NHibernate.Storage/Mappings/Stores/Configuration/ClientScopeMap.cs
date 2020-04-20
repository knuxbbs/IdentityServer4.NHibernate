﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientScopeMap : ClassMapping<ClientScope>
    {
        public ClientScopeMap()
        {
            Id(p => p.Id);

            Property(p => p.Scope, map => 
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
