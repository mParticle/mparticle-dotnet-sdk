using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mParticle.Sdk.Client.OpenAPIDateConverter;

namespace mParticle.Sdk.Model
{
    /// <summary>
    /// DeviceInformation
    /// </summary>
    [DataContract]
    public partial class DeviceInformation :  IEquatable<DeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Defines Platform
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 1,

            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 2,

            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 3,

            /// <summary>
            /// Enum Desktop for value: desktop
            /// </summary>
            [EnumMember(Value = "desktop")]
            Desktop = 4,

            /// <summary>
            /// Enum TvOS for value: tvOS
            /// </summary>
            [EnumMember(Value = "tvOS")]
            TvOS = 5,

            /// <summary>
            /// Enum Roku for value: roku
            /// </summary>
            [EnumMember(Value = "roku")]
            Roku = 6,

            /// <summary>
            /// Enum Outofband for value: out_of_band
            /// </summary>
            [EnumMember(Value = "out_of_band")]
            Outofband = 7,

            /// <summary>
            /// Enum Smarttv for value: smart_tv
            /// </summary>
            [EnumMember(Value = "smart_tv")]
            Smarttv = 8,

            /// <summary>
            /// Enum Xbox for value: xbox
            /// </summary>
            [EnumMember(Value = "xbox")]
            Xbox = 9

        }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInformation" /> class.
        /// </summary>
        /// <param name="brand">brand.</param>
        /// <param name="product">product.</param>
        /// <param name="device">device.</param>
        /// <param name="androidUuid">androidUuid.</param>
        /// <param name="deviceManufacturer">deviceManufacturer.</param>
        /// <param name="platform">platform.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="deviceModel">deviceModel.</param>
        /// <param name="screenHeight">screenHeight.</param>
        /// <param name="screenWidth">screenWidth.</param>
        /// <param name="screenDpi">screenDpi.</param>
        /// <param name="deviceCountry">deviceCountry.</param>
        /// <param name="localeLanguage">localeLanguage.</param>
        /// <param name="localeCountry">localeCountry.</param>
        /// <param name="networkCountry">networkCountry.</param>
        /// <param name="networkCarrier">networkCarrier.</param>
        /// <param name="networkCode">networkCode.</param>
        /// <param name="networkMobileCountryCode">networkMobileCountryCode.</param>
        /// <param name="timezoneOffset">timezoneOffset.</param>
        /// <param name="buildIdentifier">buildIdentifier.</param>
        /// <param name="httpHeaderUserAgent">httpHeaderUserAgent.</param>
        /// <param name="iosAdvertisingId">iosAdvertisingId.</param>
        /// <param name="pushToken">pushToken.</param>
        /// <param name="cpuArchitecture">cpuArchitecture.</param>
        /// <param name="isTablet">isTablet.</param>
        /// <param name="pushNotificationSoundEnabled">pushNotificationSoundEnabled.</param>
        /// <param name="pushNotificationVibrateEnabled">pushNotificationVibrateEnabled.</param>
        /// <param name="radioAccessTechnology">radioAccessTechnology.</param>
        /// <param name="supportsTelephony">supportsTelephony.</param>
        /// <param name="hasNfc">hasNfc.</param>
        /// <param name="bluetoothEnabled">bluetoothEnabled.</param>
        /// <param name="bluetoothVersion">bluetoothVersion.</param>
        /// <param name="iosIdfv">iosIdfv.</param>
        /// <param name="androidAdvertisingId">androidAdvertisingId.</param>
        /// <param name="buildVersionRelease">buildVersionRelease.</param>
        /// <param name="limitAdTracking">limitAdTracking.</param>
        /// <param name="ampId">ampId.</param>
        /// <param name="isDst">isDst.</param>
        /// <param name="rokuAdvertisingId">rokuAdvertisingId.</param>
        /// <param name="rokuPublisherId">rokuPublisherId.</param>
        /// <param name="microsoftAdvertisingId">microsoftAdvertisingId.</param>
        /// <param name="microsoftPublisherId">microsoftPublisherId.</param>
        /// <param name="fireAdvertisingId">fireAdvertisingId.</param>
        public DeviceInformation(string brand = default(string), string product = default(string), string device = default(string), string androidUuid = default(string), string deviceManufacturer = default(string), PlatformEnum? platform = default(PlatformEnum?), string osVersion = default(string), string deviceModel = default(string), int screenHeight = default(int), int screenWidth = default(int), int screenDpi = default(int), string deviceCountry = default(string), string localeLanguage = default(string), string localeCountry = default(string), string networkCountry = default(string), string networkCarrier = default(string), string networkCode = default(string), string networkMobileCountryCode = default(string), int timezoneOffset = default(int), string buildIdentifier = default(string), string httpHeaderUserAgent = default(string), string iosAdvertisingId = default(string), string pushToken = default(string), string cpuArchitecture = default(string), bool isTablet = default(bool), bool pushNotificationSoundEnabled = default(bool), bool pushNotificationVibrateEnabled = default(bool), string radioAccessTechnology = default(string), bool supportsTelephony = default(bool), bool hasNfc = default(bool), bool bluetoothEnabled = default(bool), string bluetoothVersion = default(string), string iosIdfv = default(string), string androidAdvertisingId = default(string), string buildVersionRelease = default(string), bool limitAdTracking = default(bool), string ampId = default(string), bool isDst = default(bool), string rokuAdvertisingId = default(string), string rokuPublisherId = default(string), string microsoftAdvertisingId = default(string), string microsoftPublisherId = default(string), string fireAdvertisingId = default(string))
        {
            this.Brand = brand;
            this.Product = product;
            this.Device = device;
            this.AndroidUuid = androidUuid;
            this.DeviceManufacturer = deviceManufacturer;
            this.Platform = platform;
            this.OsVersion = osVersion;
            this.DeviceModel = deviceModel;
            this.ScreenHeight = screenHeight;
            this.ScreenWidth = screenWidth;
            this.ScreenDpi = screenDpi;
            this.DeviceCountry = deviceCountry;
            this.LocaleLanguage = localeLanguage;
            this.LocaleCountry = localeCountry;
            this.NetworkCountry = networkCountry;
            this.NetworkCarrier = networkCarrier;
            this.NetworkCode = networkCode;
            this.NetworkMobileCountryCode = networkMobileCountryCode;
            this.TimezoneOffset = timezoneOffset;
            this.BuildIdentifier = buildIdentifier;
            this.HttpHeaderUserAgent = httpHeaderUserAgent;
            this.IosAdvertisingId = iosAdvertisingId;
            this.PushToken = pushToken;
            this.CpuArchitecture = cpuArchitecture;
            this.IsTablet = isTablet;
            this.PushNotificationSoundEnabled = pushNotificationSoundEnabled;
            this.PushNotificationVibrateEnabled = pushNotificationVibrateEnabled;
            this.RadioAccessTechnology = radioAccessTechnology;
            this.SupportsTelephony = supportsTelephony;
            this.HasNfc = hasNfc;
            this.BluetoothEnabled = bluetoothEnabled;
            this.BluetoothVersion = bluetoothVersion;
            this.IosIdfv = iosIdfv;
            this.AndroidAdvertisingId = androidAdvertisingId;
            this.BuildVersionRelease = buildVersionRelease;
            this.LimitAdTracking = limitAdTracking;
            this.AmpId = ampId;
            this.IsDst = isDst;
            this.RokuAdvertisingId = rokuAdvertisingId;
            this.RokuPublisherId = rokuPublisherId;
            this.MicrosoftAdvertisingId = microsoftAdvertisingId;
            this.MicrosoftPublisherId = microsoftPublisherId;
            this.FireAdvertisingId = fireAdvertisingId;
        }
        
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public string Product { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public string Device { get; set; }

        /// <summary>
        /// Gets or Sets AndroidUuid
        /// </summary>
        [DataMember(Name="android_uuid", EmitDefaultValue=false)]
        public string AndroidUuid { get; set; }

        /// <summary>
        /// Gets or Sets DeviceManufacturer
        /// </summary>
        [DataMember(Name="device_manufacturer", EmitDefaultValue=false)]
        public string DeviceManufacturer { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name="os_version", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets DeviceModel
        /// </summary>
        [DataMember(Name="device_model", EmitDefaultValue=false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or Sets ScreenHeight
        /// </summary>
        [DataMember(Name="screen_height", EmitDefaultValue=false)]
        public int ScreenHeight { get; set; }

        /// <summary>
        /// Gets or Sets ScreenWidth
        /// </summary>
        [DataMember(Name="screen_width", EmitDefaultValue=false)]
        public int ScreenWidth { get; set; }

        /// <summary>
        /// Gets or Sets ScreenDpi
        /// </summary>
        [DataMember(Name="screen_dpi", EmitDefaultValue=false)]
        public int ScreenDpi { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCountry
        /// </summary>
        [DataMember(Name="device_country", EmitDefaultValue=false)]
        public string DeviceCountry { get; set; }

        /// <summary>
        /// Gets or Sets LocaleLanguage
        /// </summary>
        [DataMember(Name="locale_language", EmitDefaultValue=false)]
        public string LocaleLanguage { get; set; }

        /// <summary>
        /// Gets or Sets LocaleCountry
        /// </summary>
        [DataMember(Name="locale_country", EmitDefaultValue=false)]
        public string LocaleCountry { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCountry
        /// </summary>
        [DataMember(Name="network_country", EmitDefaultValue=false)]
        public string NetworkCountry { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCarrier
        /// </summary>
        [DataMember(Name="network_carrier", EmitDefaultValue=false)]
        public string NetworkCarrier { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCode
        /// </summary>
        [DataMember(Name="network_code", EmitDefaultValue=false)]
        public string NetworkCode { get; set; }

        /// <summary>
        /// Gets or Sets NetworkMobileCountryCode
        /// </summary>
        [DataMember(Name="network_mobile_country_code", EmitDefaultValue=false)]
        public string NetworkMobileCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets TimezoneOffset
        /// </summary>
        [DataMember(Name="timezone_offset", EmitDefaultValue=false)]
        public int TimezoneOffset { get; set; }

        /// <summary>
        /// Gets or Sets BuildIdentifier
        /// </summary>
        [DataMember(Name="build_identifier", EmitDefaultValue=false)]
        public string BuildIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets HttpHeaderUserAgent
        /// </summary>
        [DataMember(Name="http_header_user_agent", EmitDefaultValue=false)]
        public string HttpHeaderUserAgent { get; set; }

        /// <summary>
        /// Gets or Sets IosAdvertisingId
        /// </summary>
        [DataMember(Name="ios_advertising_id", EmitDefaultValue=false)]
        public string IosAdvertisingId { get; set; }

        /// <summary>
        /// Gets or Sets PushToken
        /// </summary>
        [DataMember(Name="push_token", EmitDefaultValue=false)]
        public string PushToken { get; set; }

        /// <summary>
        /// Gets or Sets CpuArchitecture
        /// </summary>
        [DataMember(Name="cpu_architecture", EmitDefaultValue=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// Gets or Sets IsTablet
        /// </summary>
        [DataMember(Name="is_tablet", EmitDefaultValue=false)]
        public bool IsTablet { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationSoundEnabled
        /// </summary>
        [DataMember(Name="push_notification_sound_enabled", EmitDefaultValue=false)]
        public bool PushNotificationSoundEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationVibrateEnabled
        /// </summary>
        [DataMember(Name="push_notification_vibrate_enabled", EmitDefaultValue=false)]
        public bool PushNotificationVibrateEnabled { get; set; }

        /// <summary>
        /// Gets or Sets RadioAccessTechnology
        /// </summary>
        [DataMember(Name="radio_access_technology", EmitDefaultValue=false)]
        public string RadioAccessTechnology { get; set; }

        /// <summary>
        /// Gets or Sets SupportsTelephony
        /// </summary>
        [DataMember(Name="supports_telephony", EmitDefaultValue=false)]
        public bool SupportsTelephony { get; set; }

        /// <summary>
        /// Gets or Sets HasNfc
        /// </summary>
        [DataMember(Name="has_nfc", EmitDefaultValue=false)]
        public bool HasNfc { get; set; }

        /// <summary>
        /// Gets or Sets BluetoothEnabled
        /// </summary>
        [DataMember(Name="bluetooth_enabled", EmitDefaultValue=false)]
        public bool BluetoothEnabled { get; set; }

        /// <summary>
        /// Gets or Sets BluetoothVersion
        /// </summary>
        [DataMember(Name="bluetooth_version", EmitDefaultValue=false)]
        public string BluetoothVersion { get; set; }

        /// <summary>
        /// Gets or Sets IosIdfv
        /// </summary>
        [DataMember(Name="ios_idfv", EmitDefaultValue=false)]
        public string IosIdfv { get; set; }

        /// <summary>
        /// Gets or Sets AndroidAdvertisingId
        /// </summary>
        [DataMember(Name="android_advertising_id", EmitDefaultValue=false)]
        public string AndroidAdvertisingId { get; set; }

        /// <summary>
        /// Gets or Sets BuildVersionRelease
        /// </summary>
        [DataMember(Name="build_version_release", EmitDefaultValue=false)]
        public string BuildVersionRelease { get; set; }

        /// <summary>
        /// Gets or Sets LimitAdTracking
        /// </summary>
        [DataMember(Name="limit_ad_tracking", EmitDefaultValue=false)]
        public bool LimitAdTracking { get; set; }

        /// <summary>
        /// Gets or Sets AmpId
        /// </summary>
        [DataMember(Name="amp_id", EmitDefaultValue=false)]
        public string AmpId { get; set; }

        /// <summary>
        /// Gets or Sets IsDst
        /// </summary>
        [DataMember(Name="is_dst", EmitDefaultValue=false)]
        public bool IsDst { get; set; }

        /// <summary>
        /// Gets or Sets RokuAdvertisingId
        /// </summary>
        [DataMember(Name="roku_advertising_id", EmitDefaultValue=false)]
        public string RokuAdvertisingId { get; set; }

        /// <summary>
        /// Gets or Sets RokuPublisherId
        /// </summary>
        [DataMember(Name="roku_publisher_id", EmitDefaultValue=false)]
        public string RokuPublisherId { get; set; }

        /// <summary>
        /// Gets or Sets MicrosoftAdvertisingId
        /// </summary>
        [DataMember(Name="microsoft_advertising_id", EmitDefaultValue=false)]
        public string MicrosoftAdvertisingId { get; set; }

        /// <summary>
        /// Gets or Sets MicrosoftPublisherId
        /// </summary>
        [DataMember(Name="microsoft_publisher_id", EmitDefaultValue=false)]
        public string MicrosoftPublisherId { get; set; }

        /// <summary>
        /// Gets or Sets FireAdvertisingId
        /// </summary>
        [DataMember(Name="fire_advertising_id", EmitDefaultValue=false)]
        public string FireAdvertisingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceInformation {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  AndroidUuid: ").Append(AndroidUuid).Append("\n");
            sb.Append("  DeviceManufacturer: ").Append(DeviceManufacturer).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
            sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
            sb.Append("  ScreenDpi: ").Append(ScreenDpi).Append("\n");
            sb.Append("  DeviceCountry: ").Append(DeviceCountry).Append("\n");
            sb.Append("  LocaleLanguage: ").Append(LocaleLanguage).Append("\n");
            sb.Append("  LocaleCountry: ").Append(LocaleCountry).Append("\n");
            sb.Append("  NetworkCountry: ").Append(NetworkCountry).Append("\n");
            sb.Append("  NetworkCarrier: ").Append(NetworkCarrier).Append("\n");
            sb.Append("  NetworkCode: ").Append(NetworkCode).Append("\n");
            sb.Append("  NetworkMobileCountryCode: ").Append(NetworkMobileCountryCode).Append("\n");
            sb.Append("  TimezoneOffset: ").Append(TimezoneOffset).Append("\n");
            sb.Append("  BuildIdentifier: ").Append(BuildIdentifier).Append("\n");
            sb.Append("  HttpHeaderUserAgent: ").Append(HttpHeaderUserAgent).Append("\n");
            sb.Append("  IosAdvertisingId: ").Append(IosAdvertisingId).Append("\n");
            sb.Append("  PushToken: ").Append(PushToken).Append("\n");
            sb.Append("  CpuArchitecture: ").Append(CpuArchitecture).Append("\n");
            sb.Append("  IsTablet: ").Append(IsTablet).Append("\n");
            sb.Append("  PushNotificationSoundEnabled: ").Append(PushNotificationSoundEnabled).Append("\n");
            sb.Append("  PushNotificationVibrateEnabled: ").Append(PushNotificationVibrateEnabled).Append("\n");
            sb.Append("  RadioAccessTechnology: ").Append(RadioAccessTechnology).Append("\n");
            sb.Append("  SupportsTelephony: ").Append(SupportsTelephony).Append("\n");
            sb.Append("  HasNfc: ").Append(HasNfc).Append("\n");
            sb.Append("  BluetoothEnabled: ").Append(BluetoothEnabled).Append("\n");
            sb.Append("  BluetoothVersion: ").Append(BluetoothVersion).Append("\n");
            sb.Append("  IosIdfv: ").Append(IosIdfv).Append("\n");
            sb.Append("  AndroidAdvertisingId: ").Append(AndroidAdvertisingId).Append("\n");
            sb.Append("  BuildVersionRelease: ").Append(BuildVersionRelease).Append("\n");
            sb.Append("  LimitAdTracking: ").Append(LimitAdTracking).Append("\n");
            sb.Append("  AmpId: ").Append(AmpId).Append("\n");
            sb.Append("  IsDst: ").Append(IsDst).Append("\n");
            sb.Append("  RokuAdvertisingId: ").Append(RokuAdvertisingId).Append("\n");
            sb.Append("  RokuPublisherId: ").Append(RokuPublisherId).Append("\n");
            sb.Append("  MicrosoftAdvertisingId: ").Append(MicrosoftAdvertisingId).Append("\n");
            sb.Append("  MicrosoftPublisherId: ").Append(MicrosoftPublisherId).Append("\n");
            sb.Append("  FireAdvertisingId: ").Append(FireAdvertisingId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceInformation);
        }

        /// <summary>
        /// Returns true if DeviceInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.AndroidUuid == input.AndroidUuid ||
                    (this.AndroidUuid != null &&
                    this.AndroidUuid.Equals(input.AndroidUuid))
                ) && 
                (
                    this.DeviceManufacturer == input.DeviceManufacturer ||
                    (this.DeviceManufacturer != null &&
                    this.DeviceManufacturer.Equals(input.DeviceManufacturer))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    this.ScreenHeight.Equals(input.ScreenHeight)
                ) && 
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    this.ScreenWidth.Equals(input.ScreenWidth)
                ) && 
                (
                    this.ScreenDpi == input.ScreenDpi ||
                    this.ScreenDpi.Equals(input.ScreenDpi)
                ) && 
                (
                    this.DeviceCountry == input.DeviceCountry ||
                    (this.DeviceCountry != null &&
                    this.DeviceCountry.Equals(input.DeviceCountry))
                ) && 
                (
                    this.LocaleLanguage == input.LocaleLanguage ||
                    (this.LocaleLanguage != null &&
                    this.LocaleLanguage.Equals(input.LocaleLanguage))
                ) && 
                (
                    this.LocaleCountry == input.LocaleCountry ||
                    (this.LocaleCountry != null &&
                    this.LocaleCountry.Equals(input.LocaleCountry))
                ) && 
                (
                    this.NetworkCountry == input.NetworkCountry ||
                    (this.NetworkCountry != null &&
                    this.NetworkCountry.Equals(input.NetworkCountry))
                ) && 
                (
                    this.NetworkCarrier == input.NetworkCarrier ||
                    (this.NetworkCarrier != null &&
                    this.NetworkCarrier.Equals(input.NetworkCarrier))
                ) && 
                (
                    this.NetworkCode == input.NetworkCode ||
                    (this.NetworkCode != null &&
                    this.NetworkCode.Equals(input.NetworkCode))
                ) && 
                (
                    this.NetworkMobileCountryCode == input.NetworkMobileCountryCode ||
                    (this.NetworkMobileCountryCode != null &&
                    this.NetworkMobileCountryCode.Equals(input.NetworkMobileCountryCode))
                ) && 
                (
                    this.TimezoneOffset == input.TimezoneOffset ||
                    this.TimezoneOffset.Equals(input.TimezoneOffset)
                ) && 
                (
                    this.BuildIdentifier == input.BuildIdentifier ||
                    (this.BuildIdentifier != null &&
                    this.BuildIdentifier.Equals(input.BuildIdentifier))
                ) && 
                (
                    this.HttpHeaderUserAgent == input.HttpHeaderUserAgent ||
                    (this.HttpHeaderUserAgent != null &&
                    this.HttpHeaderUserAgent.Equals(input.HttpHeaderUserAgent))
                ) && 
                (
                    this.IosAdvertisingId == input.IosAdvertisingId ||
                    (this.IosAdvertisingId != null &&
                    this.IosAdvertisingId.Equals(input.IosAdvertisingId))
                ) && 
                (
                    this.PushToken == input.PushToken ||
                    (this.PushToken != null &&
                    this.PushToken.Equals(input.PushToken))
                ) && 
                (
                    this.CpuArchitecture == input.CpuArchitecture ||
                    (this.CpuArchitecture != null &&
                    this.CpuArchitecture.Equals(input.CpuArchitecture))
                ) && 
                (
                    this.IsTablet == input.IsTablet ||
                    this.IsTablet.Equals(input.IsTablet)
                ) && 
                (
                    this.PushNotificationSoundEnabled == input.PushNotificationSoundEnabled ||
                    this.PushNotificationSoundEnabled.Equals(input.PushNotificationSoundEnabled)
                ) && 
                (
                    this.PushNotificationVibrateEnabled == input.PushNotificationVibrateEnabled ||
                    this.PushNotificationVibrateEnabled.Equals(input.PushNotificationVibrateEnabled)
                ) && 
                (
                    this.RadioAccessTechnology == input.RadioAccessTechnology ||
                    (this.RadioAccessTechnology != null &&
                    this.RadioAccessTechnology.Equals(input.RadioAccessTechnology))
                ) && 
                (
                    this.SupportsTelephony == input.SupportsTelephony ||
                    this.SupportsTelephony.Equals(input.SupportsTelephony)
                ) && 
                (
                    this.HasNfc == input.HasNfc ||
                    this.HasNfc.Equals(input.HasNfc)
                ) && 
                (
                    this.BluetoothEnabled == input.BluetoothEnabled ||
                    this.BluetoothEnabled.Equals(input.BluetoothEnabled)
                ) && 
                (
                    this.BluetoothVersion == input.BluetoothVersion ||
                    (this.BluetoothVersion != null &&
                    this.BluetoothVersion.Equals(input.BluetoothVersion))
                ) && 
                (
                    this.IosIdfv == input.IosIdfv ||
                    (this.IosIdfv != null &&
                    this.IosIdfv.Equals(input.IosIdfv))
                ) && 
                (
                    this.AndroidAdvertisingId == input.AndroidAdvertisingId ||
                    (this.AndroidAdvertisingId != null &&
                    this.AndroidAdvertisingId.Equals(input.AndroidAdvertisingId))
                ) && 
                (
                    this.BuildVersionRelease == input.BuildVersionRelease ||
                    (this.BuildVersionRelease != null &&
                    this.BuildVersionRelease.Equals(input.BuildVersionRelease))
                ) && 
                (
                    this.LimitAdTracking == input.LimitAdTracking ||
                    this.LimitAdTracking.Equals(input.LimitAdTracking)
                ) && 
                (
                    this.AmpId == input.AmpId ||
                    (this.AmpId != null &&
                    this.AmpId.Equals(input.AmpId))
                ) && 
                (
                    this.IsDst == input.IsDst ||
                    this.IsDst.Equals(input.IsDst)
                ) && 
                (
                    this.RokuAdvertisingId == input.RokuAdvertisingId ||
                    (this.RokuAdvertisingId != null &&
                    this.RokuAdvertisingId.Equals(input.RokuAdvertisingId))
                ) && 
                (
                    this.RokuPublisherId == input.RokuPublisherId ||
                    (this.RokuPublisherId != null &&
                    this.RokuPublisherId.Equals(input.RokuPublisherId))
                ) && 
                (
                    this.MicrosoftAdvertisingId == input.MicrosoftAdvertisingId ||
                    (this.MicrosoftAdvertisingId != null &&
                    this.MicrosoftAdvertisingId.Equals(input.MicrosoftAdvertisingId))
                ) && 
                (
                    this.MicrosoftPublisherId == input.MicrosoftPublisherId ||
                    (this.MicrosoftPublisherId != null &&
                    this.MicrosoftPublisherId.Equals(input.MicrosoftPublisherId))
                ) && 
                (
                    this.FireAdvertisingId == input.FireAdvertisingId ||
                    (this.FireAdvertisingId != null &&
                    this.FireAdvertisingId.Equals(input.FireAdvertisingId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.AndroidUuid != null)
                    hashCode = hashCode * 59 + this.AndroidUuid.GetHashCode();
                if (this.DeviceManufacturer != null)
                    hashCode = hashCode * 59 + this.DeviceManufacturer.GetHashCode();
                hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.DeviceModel != null)
                    hashCode = hashCode * 59 + this.DeviceModel.GetHashCode();
                hashCode = hashCode * 59 + this.ScreenHeight.GetHashCode();
                hashCode = hashCode * 59 + this.ScreenWidth.GetHashCode();
                hashCode = hashCode * 59 + this.ScreenDpi.GetHashCode();
                if (this.DeviceCountry != null)
                    hashCode = hashCode * 59 + this.DeviceCountry.GetHashCode();
                if (this.LocaleLanguage != null)
                    hashCode = hashCode * 59 + this.LocaleLanguage.GetHashCode();
                if (this.LocaleCountry != null)
                    hashCode = hashCode * 59 + this.LocaleCountry.GetHashCode();
                if (this.NetworkCountry != null)
                    hashCode = hashCode * 59 + this.NetworkCountry.GetHashCode();
                if (this.NetworkCarrier != null)
                    hashCode = hashCode * 59 + this.NetworkCarrier.GetHashCode();
                if (this.NetworkCode != null)
                    hashCode = hashCode * 59 + this.NetworkCode.GetHashCode();
                if (this.NetworkMobileCountryCode != null)
                    hashCode = hashCode * 59 + this.NetworkMobileCountryCode.GetHashCode();
                hashCode = hashCode * 59 + this.TimezoneOffset.GetHashCode();
                if (this.BuildIdentifier != null)
                    hashCode = hashCode * 59 + this.BuildIdentifier.GetHashCode();
                if (this.HttpHeaderUserAgent != null)
                    hashCode = hashCode * 59 + this.HttpHeaderUserAgent.GetHashCode();
                if (this.IosAdvertisingId != null)
                    hashCode = hashCode * 59 + this.IosAdvertisingId.GetHashCode();
                if (this.PushToken != null)
                    hashCode = hashCode * 59 + this.PushToken.GetHashCode();
                if (this.CpuArchitecture != null)
                    hashCode = hashCode * 59 + this.CpuArchitecture.GetHashCode();
                hashCode = hashCode * 59 + this.IsTablet.GetHashCode();
                hashCode = hashCode * 59 + this.PushNotificationSoundEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.PushNotificationVibrateEnabled.GetHashCode();
                if (this.RadioAccessTechnology != null)
                    hashCode = hashCode * 59 + this.RadioAccessTechnology.GetHashCode();
                hashCode = hashCode * 59 + this.SupportsTelephony.GetHashCode();
                hashCode = hashCode * 59 + this.HasNfc.GetHashCode();
                hashCode = hashCode * 59 + this.BluetoothEnabled.GetHashCode();
                if (this.BluetoothVersion != null)
                    hashCode = hashCode * 59 + this.BluetoothVersion.GetHashCode();
                if (this.IosIdfv != null)
                    hashCode = hashCode * 59 + this.IosIdfv.GetHashCode();
                if (this.AndroidAdvertisingId != null)
                    hashCode = hashCode * 59 + this.AndroidAdvertisingId.GetHashCode();
                if (this.BuildVersionRelease != null)
                    hashCode = hashCode * 59 + this.BuildVersionRelease.GetHashCode();
                hashCode = hashCode * 59 + this.LimitAdTracking.GetHashCode();
                if (this.AmpId != null)
                    hashCode = hashCode * 59 + this.AmpId.GetHashCode();
                hashCode = hashCode * 59 + this.IsDst.GetHashCode();
                if (this.RokuAdvertisingId != null)
                    hashCode = hashCode * 59 + this.RokuAdvertisingId.GetHashCode();
                if (this.RokuPublisherId != null)
                    hashCode = hashCode * 59 + this.RokuPublisherId.GetHashCode();
                if (this.MicrosoftAdvertisingId != null)
                    hashCode = hashCode * 59 + this.MicrosoftAdvertisingId.GetHashCode();
                if (this.MicrosoftPublisherId != null)
                    hashCode = hashCode * 59 + this.MicrosoftPublisherId.GetHashCode();
                if (this.FireAdvertisingId != null)
                    hashCode = hashCode * 59 + this.FireAdvertisingId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
