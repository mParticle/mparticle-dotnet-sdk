


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mParticle.Api;
using mParticle.Model;
using mParticle.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mParticle.Test
{
    /// <summary>
    ///  Class for testing DeviceInformation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DeviceInformationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DeviceInformation
        //private DeviceInformation instance;

        public DeviceInformationTests()
        {
            // TODO uncomment below to create an instance of DeviceInformation
            //instance = new DeviceInformation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeviceInformation
        /// </summary>
        [Fact]
        public void DeviceInformationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DeviceInformation
            //Assert.IsInstanceOfType<DeviceInformation> (instance, "variable 'instance' is a DeviceInformation");
        }


        /// <summary>
        /// Test the property 'Brand'
        /// </summary>
        [Fact]
        public void BrandTest()
        {
            // TODO unit test for the property 'Brand'
        }
        /// <summary>
        /// Test the property 'Product'
        /// </summary>
        [Fact]
        public void ProductTest()
        {
            // TODO unit test for the property 'Product'
        }
        /// <summary>
        /// Test the property 'Device'
        /// </summary>
        [Fact]
        public void DeviceTest()
        {
            // TODO unit test for the property 'Device'
        }
        /// <summary>
        /// Test the property 'AndroidUuid'
        /// </summary>
        [Fact]
        public void AndroidUuidTest()
        {
            // TODO unit test for the property 'AndroidUuid'
        }
        /// <summary>
        /// Test the property 'DeviceManufacturer'
        /// </summary>
        [Fact]
        public void DeviceManufacturerTest()
        {
            // TODO unit test for the property 'DeviceManufacturer'
        }
        /// <summary>
        /// Test the property 'Platform'
        /// </summary>
        [Fact]
        public void PlatformTest()
        {
            // TODO unit test for the property 'Platform'
        }
        /// <summary>
        /// Test the property 'OsVersion'
        /// </summary>
        [Fact]
        public void OsVersionTest()
        {
            // TODO unit test for the property 'OsVersion'
        }
        /// <summary>
        /// Test the property 'DeviceModel'
        /// </summary>
        [Fact]
        public void DeviceModelTest()
        {
            // TODO unit test for the property 'DeviceModel'
        }
        /// <summary>
        /// Test the property 'ScreenHeight'
        /// </summary>
        [Fact]
        public void ScreenHeightTest()
        {
            // TODO unit test for the property 'ScreenHeight'
        }
        /// <summary>
        /// Test the property 'ScreenWidth'
        /// </summary>
        [Fact]
        public void ScreenWidthTest()
        {
            // TODO unit test for the property 'ScreenWidth'
        }
        /// <summary>
        /// Test the property 'ScreenDpi'
        /// </summary>
        [Fact]
        public void ScreenDpiTest()
        {
            // TODO unit test for the property 'ScreenDpi'
        }
        /// <summary>
        /// Test the property 'DeviceCountry'
        /// </summary>
        [Fact]
        public void DeviceCountryTest()
        {
            // TODO unit test for the property 'DeviceCountry'
        }
        /// <summary>
        /// Test the property 'LocaleLanguage'
        /// </summary>
        [Fact]
        public void LocaleLanguageTest()
        {
            // TODO unit test for the property 'LocaleLanguage'
        }
        /// <summary>
        /// Test the property 'LocaleCountry'
        /// </summary>
        [Fact]
        public void LocaleCountryTest()
        {
            // TODO unit test for the property 'LocaleCountry'
        }
        /// <summary>
        /// Test the property 'NetworkCountry'
        /// </summary>
        [Fact]
        public void NetworkCountryTest()
        {
            // TODO unit test for the property 'NetworkCountry'
        }
        /// <summary>
        /// Test the property 'NetworkCarrier'
        /// </summary>
        [Fact]
        public void NetworkCarrierTest()
        {
            // TODO unit test for the property 'NetworkCarrier'
        }
        /// <summary>
        /// Test the property 'NetworkCode'
        /// </summary>
        [Fact]
        public void NetworkCodeTest()
        {
            // TODO unit test for the property 'NetworkCode'
        }
        /// <summary>
        /// Test the property 'NetworkMobileCountryCode'
        /// </summary>
        [Fact]
        public void NetworkMobileCountryCodeTest()
        {
            // TODO unit test for the property 'NetworkMobileCountryCode'
        }
        /// <summary>
        /// Test the property 'TimezoneOffset'
        /// </summary>
        [Fact]
        public void TimezoneOffsetTest()
        {
            // TODO unit test for the property 'TimezoneOffset'
        }
        /// <summary>
        /// Test the property 'BuildIdentifier'
        /// </summary>
        [Fact]
        public void BuildIdentifierTest()
        {
            // TODO unit test for the property 'BuildIdentifier'
        }
        /// <summary>
        /// Test the property 'HttpHeaderUserAgent'
        /// </summary>
        [Fact]
        public void HttpHeaderUserAgentTest()
        {
            // TODO unit test for the property 'HttpHeaderUserAgent'
        }
        /// <summary>
        /// Test the property 'IosAdvertisingId'
        /// </summary>
        [Fact]
        public void IosAdvertisingIdTest()
        {
            // TODO unit test for the property 'IosAdvertisingId'
        }
        /// <summary>
        /// Test the property 'PushToken'
        /// </summary>
        [Fact]
        public void PushTokenTest()
        {
            // TODO unit test for the property 'PushToken'
        }
        /// <summary>
        /// Test the property 'CpuArchitecture'
        /// </summary>
        [Fact]
        public void CpuArchitectureTest()
        {
            // TODO unit test for the property 'CpuArchitecture'
        }
        /// <summary>
        /// Test the property 'IsTablet'
        /// </summary>
        [Fact]
        public void IsTabletTest()
        {
            // TODO unit test for the property 'IsTablet'
        }
        /// <summary>
        /// Test the property 'PushNotificationSoundEnabled'
        /// </summary>
        [Fact]
        public void PushNotificationSoundEnabledTest()
        {
            // TODO unit test for the property 'PushNotificationSoundEnabled'
        }
        /// <summary>
        /// Test the property 'PushNotificationVibrateEnabled'
        /// </summary>
        [Fact]
        public void PushNotificationVibrateEnabledTest()
        {
            // TODO unit test for the property 'PushNotificationVibrateEnabled'
        }
        /// <summary>
        /// Test the property 'RadioAccessTechnology'
        /// </summary>
        [Fact]
        public void RadioAccessTechnologyTest()
        {
            // TODO unit test for the property 'RadioAccessTechnology'
        }
        /// <summary>
        /// Test the property 'SupportsTelephony'
        /// </summary>
        [Fact]
        public void SupportsTelephonyTest()
        {
            // TODO unit test for the property 'SupportsTelephony'
        }
        /// <summary>
        /// Test the property 'HasNfc'
        /// </summary>
        [Fact]
        public void HasNfcTest()
        {
            // TODO unit test for the property 'HasNfc'
        }
        /// <summary>
        /// Test the property 'BluetoothEnabled'
        /// </summary>
        [Fact]
        public void BluetoothEnabledTest()
        {
            // TODO unit test for the property 'BluetoothEnabled'
        }
        /// <summary>
        /// Test the property 'BluetoothVersion'
        /// </summary>
        [Fact]
        public void BluetoothVersionTest()
        {
            // TODO unit test for the property 'BluetoothVersion'
        }
        /// <summary>
        /// Test the property 'IosIdfv'
        /// </summary>
        [Fact]
        public void IosIdfvTest()
        {
            // TODO unit test for the property 'IosIdfv'
        }
        /// <summary>
        /// Test the property 'AndroidAdvertisingId'
        /// </summary>
        [Fact]
        public void AndroidAdvertisingIdTest()
        {
            // TODO unit test for the property 'AndroidAdvertisingId'
        }
        /// <summary>
        /// Test the property 'BuildVersionRelease'
        /// </summary>
        [Fact]
        public void BuildVersionReleaseTest()
        {
            // TODO unit test for the property 'BuildVersionRelease'
        }
        /// <summary>
        /// Test the property 'LimitAdTracking'
        /// </summary>
        [Fact]
        public void LimitAdTrackingTest()
        {
            // TODO unit test for the property 'LimitAdTracking'
        }
        /// <summary>
        /// Test the property 'AmpId'
        /// </summary>
        [Fact]
        public void AmpIdTest()
        {
            // TODO unit test for the property 'AmpId'
        }
        /// <summary>
        /// Test the property 'IsDst'
        /// </summary>
        [Fact]
        public void IsDstTest()
        {
            // TODO unit test for the property 'IsDst'
        }
        /// <summary>
        /// Test the property 'RokuAdvertisingId'
        /// </summary>
        [Fact]
        public void RokuAdvertisingIdTest()
        {
            // TODO unit test for the property 'RokuAdvertisingId'
        }
        /// <summary>
        /// Test the property 'RokuPublisherId'
        /// </summary>
        [Fact]
        public void RokuPublisherIdTest()
        {
            // TODO unit test for the property 'RokuPublisherId'
        }
        /// <summary>
        /// Test the property 'MicrosoftAdvertisingId'
        /// </summary>
        [Fact]
        public void MicrosoftAdvertisingIdTest()
        {
            // TODO unit test for the property 'MicrosoftAdvertisingId'
        }
        /// <summary>
        /// Test the property 'MicrosoftPublisherId'
        /// </summary>
        [Fact]
        public void MicrosoftPublisherIdTest()
        {
            // TODO unit test for the property 'MicrosoftPublisherId'
        }
        /// <summary>
        /// Test the property 'FireAdvertisingId'
        /// </summary>
        [Fact]
        public void FireAdvertisingIdTest()
        {
            // TODO unit test for the property 'FireAdvertisingId'
        }

    }

}
