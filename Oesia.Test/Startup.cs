﻿using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Oesia.Ioc;
using System;

namespace Oesia.Test
{
    [SetUpFixture]
    public class Startup
    {
        internal static IServiceProvider ServiceProvider { get; set; }
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            ServiceProvider = ContainerBuilder();
        }
        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {

        }
        public IServiceProvider ContainerBuilder()
        {
            IServiceCollection services = new ServiceCollection();
            services.ConfigureIOC();
            return services.BuildServiceProvider();
        }
    }
}
