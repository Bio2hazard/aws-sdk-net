﻿using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Xunit;

using Amazon;
using Amazon.S3;
using Amazon.Extensions.NETCore.Setup;
using Amazon.NETCore.SetupTests;
using Moq;

namespace DependencyInjectionTests
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void InjectS3ClientWithDefaultConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>();

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void InjectS3ClientWithOverridingConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>(new AWSOptions {Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void TryAddServiceDontOverrideWhenAlreadySetup()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();

            var mockS3 = Mock.Of<IAmazonS3>();
            services.AddSingleton(mockS3);

            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.TryAddAWSService<IAmazonS3>(new AWSOptions { Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            var s3 = controller.S3Client;
            Assert.NotNull(s3);
            Assert.True(s3.GetType() == mockS3.GetType());
        }

        public class TestController
        {
            public IAmazonS3 S3Client { get; private set; }
            public TestController(IAmazonS3 s3Client)
            {
                S3Client = s3Client;
            }
        }

        [Fact]
        public async Task AddDefaultAWSOptionsUpdatesOnFileChange()
        {
            var testFileContents = File.ReadAllText("./TestFiles/LogToConfigTest.json");

            using (var tempFileHelper = new TempFileHelper(testFileContents))
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile(tempFileHelper.Path, true, true);

                IConfiguration config = builder.Build();

                var options = config.GetAWSOptions();

                ServiceCollection services = new ServiceCollection();

                services.AddDefaultAWSOptions(options, config);

                Assert.Equal(LoggingOptions.Console, options.LogTo);
                Assert.Equal(LoggingOptions.Console, AWSConfigs.LoggingConfig.LogTo);

                var updatedFileContents =
                    testFileContents.Replace(@"""LogTo"": ""Console""", @"""LogTo"": ""Console,Log4Net""");

                tempFileHelper.Write(updatedFileContents);

                await Task.Delay(500).ConfigureAwait(false);

                Assert.Equal(LoggingOptions.Console | LoggingOptions.Log4Net, options.LogTo);
                Assert.Equal(LoggingOptions.Console | LoggingOptions.Log4Net, AWSConfigs.LoggingConfig.LogTo);
            }
        }
    }
}
