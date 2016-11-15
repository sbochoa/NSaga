﻿using System;
using SimpleInjector;

namespace NSaga.SimpleInjector
{
    public sealed class SqlRepositoryBuilder
    {
        private readonly Container container;

        public SqlRepositoryBuilder(Container container)
        {
            Guard.ArgumentIsNotNull(container, nameof(container));

            this.container = container;
        }

        public Container WithConnectionString(String connectionString)
        {
            container.Register(typeof(IConnectionFactory), () => new ConnectionFactory(connectionString));

            container.UseSagaRepository<SqlSagaRepository>();

            return container;
        }

        public Container WithConnectionStringName(String connectionStringName)
        {
            container.Register(typeof(IConnectionFactory), () => ConnectionFactory.FromConnectionStringName(connectionStringName));

            container.UseSagaRepository<SqlSagaRepository>();

            return container;
        }
    }
}