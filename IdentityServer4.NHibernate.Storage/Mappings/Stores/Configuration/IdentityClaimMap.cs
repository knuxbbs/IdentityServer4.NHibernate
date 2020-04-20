﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class IdentityClaimMap : ClassMapping<IdentityClaim>
    {
        public IdentityClaimMap()
        {
            Id(p => p.Id);

            Property(p => p.Type, map => 
            {
                map.Length(200);
                map.NotNullable(true);
            });
        }
    }
}
