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
    /// DeviceCurrentState
    /// </summary>
    [DataContract]
    public partial class DeviceCurrentState :  IEquatable<DeviceCurrentState>, IValidatableObject
    {
        /// <summary>
        /// Defines DeviceOrientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceOrientationEnum
        {
            /// <summary>
            /// Enum Portrait for value: portrait
            /// </summary>
            [EnumMember(Value = "portrait")]
            Portrait = 1,

            /// <summary>
            /// Enum Portraitupsidedown for value: portrait_upside_down
            /// </summary>
            [EnumMember(Value = "portrait_upside_down")]
            Portraitupsidedown = 2,

            /// <summary>
            /// Enum Landscape for value: landscape
            /// </summary>
            [EnumMember(Value = "landscape")]
            Landscape = 3,

            /// <summary>
            /// Enum LandscapeLeft for value: LandscapeLeft
            /// </summary>
            [EnumMember(Value = "LandscapeLeft")]
            LandscapeLeft = 4,

            /// <summary>
            /// Enum LandscapeRight for value: LandscapeRight
            /// </summary>
            [EnumMember(Value = "LandscapeRight")]
            LandscapeRight = 5,

            /// <summary>
            /// Enum FaceUp for value: FaceUp
            /// </summary>
            [EnumMember(Value = "FaceUp")]
            FaceUp = 6,

            /// <summary>
            /// Enum FaceDown for value: FaceDown
            /// </summary>
            [EnumMember(Value = "FaceDown")]
            FaceDown = 7,

            /// <summary>
            /// Enum Square for value: Square
            /// </summary>
            [EnumMember(Value = "Square")]
            Square = 8

        }

        /// <summary>
        /// Gets or Sets DeviceOrientation
        /// </summary>
        [DataMember(Name="device_orientation", EmitDefaultValue=false)]
        public DeviceOrientationEnum? DeviceOrientation { get; set; }
        /// <summary>
        /// Defines StatusBarOrientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusBarOrientationEnum
        {
            /// <summary>
            /// Enum Portrait for value: portrait
            /// </summary>
            [EnumMember(Value = "portrait")]
            Portrait = 1,

            /// <summary>
            /// Enum Portraitupsidedown for value: portrait_upside_down
            /// </summary>
            [EnumMember(Value = "portrait_upside_down")]
            Portraitupsidedown = 2,

            /// <summary>
            /// Enum Landscape for value: landscape
            /// </summary>
            [EnumMember(Value = "landscape")]
            Landscape = 3,

            /// <summary>
            /// Enum LandscapeLeft for value: LandscapeLeft
            /// </summary>
            [EnumMember(Value = "LandscapeLeft")]
            LandscapeLeft = 4,

            /// <summary>
            /// Enum LandscapeRight for value: LandscapeRight
            /// </summary>
            [EnumMember(Value = "LandscapeRight")]
            LandscapeRight = 5,

            /// <summary>
            /// Enum FaceUp for value: FaceUp
            /// </summary>
            [EnumMember(Value = "FaceUp")]
            FaceUp = 6,

            /// <summary>
            /// Enum FaceDown for value: FaceDown
            /// </summary>
            [EnumMember(Value = "FaceDown")]
            FaceDown = 7,

            /// <summary>
            /// Enum Square for value: Square
            /// </summary>
            [EnumMember(Value = "Square")]
            Square = 8

        }

        /// <summary>
        /// Gets or Sets StatusBarOrientation
        /// </summary>
        [DataMember(Name="status_bar_orientation", EmitDefaultValue=false)]
        public StatusBarOrientationEnum? StatusBarOrientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCurrentState" /> class.
        /// </summary>
        /// <param name="timeSinceStartMs">timeSinceStartMs.</param>
        /// <param name="batteryLevel">batteryLevel.</param>
        /// <param name="dataConnectionType">dataConnectionType.</param>
        /// <param name="dataConnectionTypeDetail">dataConnectionTypeDetail.</param>
        /// <param name="gpsState">gpsState.</param>
        /// <param name="totalSystemMemoryUsageBytes">totalSystemMemoryUsageBytes.</param>
        /// <param name="diskSpaceFreeBytes">diskSpaceFreeBytes.</param>
        /// <param name="externalDiskSpaceFreeBytes">externalDiskSpaceFreeBytes.</param>
        /// <param name="cpu">cpu.</param>
        /// <param name="systemMemoryAvailableBytes">systemMemoryAvailableBytes.</param>
        /// <param name="systemMemoryLow">systemMemoryLow.</param>
        /// <param name="systemMemoryThresholdBytes">systemMemoryThresholdBytes.</param>
        /// <param name="applicationMemoryAvailableBytes">applicationMemoryAvailableBytes.</param>
        /// <param name="applicationMemoryMaxBytes">applicationMemoryMaxBytes.</param>
        /// <param name="applicationMemoryTotalBytes">applicationMemoryTotalBytes.</param>
        /// <param name="deviceOrientation">deviceOrientation.</param>
        /// <param name="statusBarOrientation">statusBarOrientation.</param>
        public DeviceCurrentState(int timeSinceStartMs = default(int), decimal batteryLevel = default(decimal), string dataConnectionType = default(string), string dataConnectionTypeDetail = default(string), bool gpsState = default(bool), int totalSystemMemoryUsageBytes = default(int), int diskSpaceFreeBytes = default(int), int externalDiskSpaceFreeBytes = default(int), string cpu = default(string), decimal systemMemoryAvailableBytes = default(decimal), bool systemMemoryLow = default(bool), decimal systemMemoryThresholdBytes = default(decimal), decimal applicationMemoryAvailableBytes = default(decimal), decimal applicationMemoryMaxBytes = default(decimal), decimal applicationMemoryTotalBytes = default(decimal), DeviceOrientationEnum? deviceOrientation = default(DeviceOrientationEnum?), StatusBarOrientationEnum? statusBarOrientation = default(StatusBarOrientationEnum?))
        {
            this.TimeSinceStartMs = timeSinceStartMs;
            this.BatteryLevel = batteryLevel;
            this.DataConnectionType = dataConnectionType;
            this.DataConnectionTypeDetail = dataConnectionTypeDetail;
            this.GpsState = gpsState;
            this.TotalSystemMemoryUsageBytes = totalSystemMemoryUsageBytes;
            this.DiskSpaceFreeBytes = diskSpaceFreeBytes;
            this.ExternalDiskSpaceFreeBytes = externalDiskSpaceFreeBytes;
            this.Cpu = cpu;
            this.SystemMemoryAvailableBytes = systemMemoryAvailableBytes;
            this.SystemMemoryLow = systemMemoryLow;
            this.SystemMemoryThresholdBytes = systemMemoryThresholdBytes;
            this.ApplicationMemoryAvailableBytes = applicationMemoryAvailableBytes;
            this.ApplicationMemoryMaxBytes = applicationMemoryMaxBytes;
            this.ApplicationMemoryTotalBytes = applicationMemoryTotalBytes;
            this.DeviceOrientation = deviceOrientation;
            this.StatusBarOrientation = statusBarOrientation;
        }
        
        /// <summary>
        /// Gets or Sets TimeSinceStartMs
        /// </summary>
        [DataMember(Name="time_since_start_ms", EmitDefaultValue=false)]
        public int TimeSinceStartMs { get; set; }

        /// <summary>
        /// Gets or Sets BatteryLevel
        /// </summary>
        [DataMember(Name="battery_level", EmitDefaultValue=false)]
        public decimal BatteryLevel { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionType
        /// </summary>
        [DataMember(Name="data_connection_type", EmitDefaultValue=false)]
        public string DataConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionTypeDetail
        /// </summary>
        [DataMember(Name="data_connection_type_detail", EmitDefaultValue=false)]
        public string DataConnectionTypeDetail { get; set; }

        /// <summary>
        /// Gets or Sets GpsState
        /// </summary>
        [DataMember(Name="gps_state", EmitDefaultValue=false)]
        public bool GpsState { get; set; }

        /// <summary>
        /// Gets or Sets TotalSystemMemoryUsageBytes
        /// </summary>
        [DataMember(Name="total_system_memory_usage_bytes", EmitDefaultValue=false)]
        public int TotalSystemMemoryUsageBytes { get; set; }

        /// <summary>
        /// Gets or Sets DiskSpaceFreeBytes
        /// </summary>
        [DataMember(Name="disk_space_free_bytes", EmitDefaultValue=false)]
        public int DiskSpaceFreeBytes { get; set; }

        /// <summary>
        /// Gets or Sets ExternalDiskSpaceFreeBytes
        /// </summary>
        [DataMember(Name="external_disk_space_free_bytes", EmitDefaultValue=false)]
        public int ExternalDiskSpaceFreeBytes { get; set; }

        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// Gets or Sets SystemMemoryAvailableBytes
        /// </summary>
        [DataMember(Name="system_memory_available_bytes", EmitDefaultValue=false)]
        public decimal SystemMemoryAvailableBytes { get; set; }

        /// <summary>
        /// Gets or Sets SystemMemoryLow
        /// </summary>
        [DataMember(Name="system_memory_low", EmitDefaultValue=false)]
        public bool SystemMemoryLow { get; set; }

        /// <summary>
        /// Gets or Sets SystemMemoryThresholdBytes
        /// </summary>
        [DataMember(Name="system_memory_threshold_bytes", EmitDefaultValue=false)]
        public decimal SystemMemoryThresholdBytes { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationMemoryAvailableBytes
        /// </summary>
        [DataMember(Name="application_memory_available_bytes", EmitDefaultValue=false)]
        public decimal ApplicationMemoryAvailableBytes { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationMemoryMaxBytes
        /// </summary>
        [DataMember(Name="application_memory_max_bytes", EmitDefaultValue=false)]
        public decimal ApplicationMemoryMaxBytes { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationMemoryTotalBytes
        /// </summary>
        [DataMember(Name="application_memory_total_bytes", EmitDefaultValue=false)]
        public decimal ApplicationMemoryTotalBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceCurrentState {\n");
            sb.Append("  TimeSinceStartMs: ").Append(TimeSinceStartMs).Append("\n");
            sb.Append("  BatteryLevel: ").Append(BatteryLevel).Append("\n");
            sb.Append("  DataConnectionType: ").Append(DataConnectionType).Append("\n");
            sb.Append("  DataConnectionTypeDetail: ").Append(DataConnectionTypeDetail).Append("\n");
            sb.Append("  GpsState: ").Append(GpsState).Append("\n");
            sb.Append("  TotalSystemMemoryUsageBytes: ").Append(TotalSystemMemoryUsageBytes).Append("\n");
            sb.Append("  DiskSpaceFreeBytes: ").Append(DiskSpaceFreeBytes).Append("\n");
            sb.Append("  ExternalDiskSpaceFreeBytes: ").Append(ExternalDiskSpaceFreeBytes).Append("\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  SystemMemoryAvailableBytes: ").Append(SystemMemoryAvailableBytes).Append("\n");
            sb.Append("  SystemMemoryLow: ").Append(SystemMemoryLow).Append("\n");
            sb.Append("  SystemMemoryThresholdBytes: ").Append(SystemMemoryThresholdBytes).Append("\n");
            sb.Append("  ApplicationMemoryAvailableBytes: ").Append(ApplicationMemoryAvailableBytes).Append("\n");
            sb.Append("  ApplicationMemoryMaxBytes: ").Append(ApplicationMemoryMaxBytes).Append("\n");
            sb.Append("  ApplicationMemoryTotalBytes: ").Append(ApplicationMemoryTotalBytes).Append("\n");
            sb.Append("  DeviceOrientation: ").Append(DeviceOrientation).Append("\n");
            sb.Append("  StatusBarOrientation: ").Append(StatusBarOrientation).Append("\n");
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
            return this.Equals(input as DeviceCurrentState);
        }

        /// <summary>
        /// Returns true if DeviceCurrentState instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCurrentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCurrentState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeSinceStartMs == input.TimeSinceStartMs ||
                    this.TimeSinceStartMs.Equals(input.TimeSinceStartMs)
                ) && 
                (
                    this.BatteryLevel == input.BatteryLevel ||
                    this.BatteryLevel.Equals(input.BatteryLevel)
                ) && 
                (
                    this.DataConnectionType == input.DataConnectionType ||
                    (this.DataConnectionType != null &&
                    this.DataConnectionType.Equals(input.DataConnectionType))
                ) && 
                (
                    this.DataConnectionTypeDetail == input.DataConnectionTypeDetail ||
                    (this.DataConnectionTypeDetail != null &&
                    this.DataConnectionTypeDetail.Equals(input.DataConnectionTypeDetail))
                ) && 
                (
                    this.GpsState == input.GpsState ||
                    this.GpsState.Equals(input.GpsState)
                ) && 
                (
                    this.TotalSystemMemoryUsageBytes == input.TotalSystemMemoryUsageBytes ||
                    this.TotalSystemMemoryUsageBytes.Equals(input.TotalSystemMemoryUsageBytes)
                ) && 
                (
                    this.DiskSpaceFreeBytes == input.DiskSpaceFreeBytes ||
                    this.DiskSpaceFreeBytes.Equals(input.DiskSpaceFreeBytes)
                ) && 
                (
                    this.ExternalDiskSpaceFreeBytes == input.ExternalDiskSpaceFreeBytes ||
                    this.ExternalDiskSpaceFreeBytes.Equals(input.ExternalDiskSpaceFreeBytes)
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.SystemMemoryAvailableBytes == input.SystemMemoryAvailableBytes ||
                    this.SystemMemoryAvailableBytes.Equals(input.SystemMemoryAvailableBytes)
                ) && 
                (
                    this.SystemMemoryLow == input.SystemMemoryLow ||
                    this.SystemMemoryLow.Equals(input.SystemMemoryLow)
                ) && 
                (
                    this.SystemMemoryThresholdBytes == input.SystemMemoryThresholdBytes ||
                    this.SystemMemoryThresholdBytes.Equals(input.SystemMemoryThresholdBytes)
                ) && 
                (
                    this.ApplicationMemoryAvailableBytes == input.ApplicationMemoryAvailableBytes ||
                    this.ApplicationMemoryAvailableBytes.Equals(input.ApplicationMemoryAvailableBytes)
                ) && 
                (
                    this.ApplicationMemoryMaxBytes == input.ApplicationMemoryMaxBytes ||
                    this.ApplicationMemoryMaxBytes.Equals(input.ApplicationMemoryMaxBytes)
                ) && 
                (
                    this.ApplicationMemoryTotalBytes == input.ApplicationMemoryTotalBytes ||
                    this.ApplicationMemoryTotalBytes.Equals(input.ApplicationMemoryTotalBytes)
                ) && 
                (
                    this.DeviceOrientation == input.DeviceOrientation ||
                    this.DeviceOrientation.Equals(input.DeviceOrientation)
                ) && 
                (
                    this.StatusBarOrientation == input.StatusBarOrientation ||
                    this.StatusBarOrientation.Equals(input.StatusBarOrientation)
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
                hashCode = hashCode * 59 + this.TimeSinceStartMs.GetHashCode();
                hashCode = hashCode * 59 + this.BatteryLevel.GetHashCode();
                if (this.DataConnectionType != null)
                    hashCode = hashCode * 59 + this.DataConnectionType.GetHashCode();
                if (this.DataConnectionTypeDetail != null)
                    hashCode = hashCode * 59 + this.DataConnectionTypeDetail.GetHashCode();
                hashCode = hashCode * 59 + this.GpsState.GetHashCode();
                hashCode = hashCode * 59 + this.TotalSystemMemoryUsageBytes.GetHashCode();
                hashCode = hashCode * 59 + this.DiskSpaceFreeBytes.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalDiskSpaceFreeBytes.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                hashCode = hashCode * 59 + this.SystemMemoryAvailableBytes.GetHashCode();
                hashCode = hashCode * 59 + this.SystemMemoryLow.GetHashCode();
                hashCode = hashCode * 59 + this.SystemMemoryThresholdBytes.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationMemoryAvailableBytes.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationMemoryMaxBytes.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationMemoryTotalBytes.GetHashCode();
                hashCode = hashCode * 59 + this.DeviceOrientation.GetHashCode();
                hashCode = hashCode * 59 + this.StatusBarOrientation.GetHashCode();
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
