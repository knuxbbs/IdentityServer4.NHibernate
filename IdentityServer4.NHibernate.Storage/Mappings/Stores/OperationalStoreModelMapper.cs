﻿using System;
using IdentityServer4.NHibernate.Entities;
using IdentityServer4.NHibernate.Extensions;
using IdentityServer4.NHibernate.Options;
using NHibernate.Mapping.ByCode;

namespace IdentityServer4.NHibernate.Mappings.Stores
{
    internal class OperationalStoreModelMapper : ModelMapperBase
    {
        private readonly OperationalStoreOptions _options;

        public OperationalStoreModelMapper(OperationalStoreOptions options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            BeforeMapClass += BeforeMapOperationalStoreClass;
        }

        private void BeforeMapOperationalStoreClass(IModelInspector modelInspector, Type type,
            IClassAttributesMapper classCustomizer)
        {
            var tableDef =
                GetTableDefinition(type == typeof(PersistedGrant)
                        ? nameof(_options.PersistedGrants)
                        : type.Name,
                    _options);

            if (tableDef != null)
            {
                classCustomizer.MapToTable(tableDef, _options);
            }

            classCustomizer.DynamicUpdate(true);
        }
    }
}