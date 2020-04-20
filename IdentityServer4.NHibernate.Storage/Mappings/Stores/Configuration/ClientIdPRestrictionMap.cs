﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientIdPRestrictionMap : ClassMapping<ClientIdPRestriction>
    {
        public ClientIdPRestrictionMap()
        {
            Id(p => p.Id);

            Property(p => p.Provider, map =>
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
