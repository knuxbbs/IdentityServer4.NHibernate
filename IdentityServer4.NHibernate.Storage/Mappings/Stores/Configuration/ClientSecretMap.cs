﻿using IdentityServer4.NHibernate.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace IdentityServer4.NHibernate.Mappings.Stores.Configuration
{
    internal class ClientSecretMap : ClassMapping<ClientSecret>
    {
        public ClientSecretMap()
        {
            Id(p => p.Id);

            Property(p => p.Description, map => map.Length(2000));

            Property(p => p.Value, map =>
            {
                map.Length(2000);
                map.NotNullable(true);
            });

            Property(p => p.Expiration);
        }
    }
}
