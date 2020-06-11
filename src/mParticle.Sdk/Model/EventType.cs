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
    /// Defines EventType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EventType
    {
        /// <summary>
        /// Enum Sessionstart for value: session_start
        /// </summary>
        [EnumMember(Value = "session_start")]
        Sessionstart = 1,

        /// <summary>
        /// Enum Sessionend for value: session_end
        /// </summary>
        [EnumMember(Value = "session_end")]
        Sessionend = 2,

        /// <summary>
        /// Enum Screenview for value: screen_view
        /// </summary>
        [EnumMember(Value = "screen_view")]
        Screenview = 3,

        /// <summary>
        /// Enum Customevent for value: custom_event
        /// </summary>
        [EnumMember(Value = "custom_event")]
        Customevent = 4,

        /// <summary>
        /// Enum Crashreport for value: crash_report
        /// </summary>
        [EnumMember(Value = "crash_report")]
        Crashreport = 5,

        /// <summary>
        /// Enum Optout for value: opt_out
        /// </summary>
        [EnumMember(Value = "opt_out")]
        Optout = 6,

        /// <summary>
        /// Enum Firstrun for value: first_run
        /// </summary>
        [EnumMember(Value = "first_run")]
        Firstrun = 7,

        /// <summary>
        /// Enum Preattribution for value: pre_attribution
        /// </summary>
        [EnumMember(Value = "pre_attribution")]
        Preattribution = 8,

        /// <summary>
        /// Enum Pushregistration for value: push_registration
        /// </summary>
        [EnumMember(Value = "push_registration")]
        Pushregistration = 9,

        /// <summary>
        /// Enum Applicationstatetransition for value: application_state_transition
        /// </summary>
        [EnumMember(Value = "application_state_transition")]
        Applicationstatetransition = 10,

        /// <summary>
        /// Enum Pushmessage for value: push_message
        /// </summary>
        [EnumMember(Value = "push_message")]
        Pushmessage = 11,

        /// <summary>
        /// Enum Networkperformance for value: network_performance
        /// </summary>
        [EnumMember(Value = "network_performance")]
        Networkperformance = 12,

        /// <summary>
        /// Enum Breadcrumb for value: breadcrumb
        /// </summary>
        [EnumMember(Value = "breadcrumb")]
        Breadcrumb = 13,

        /// <summary>
        /// Enum Profile for value: profile
        /// </summary>
        [EnumMember(Value = "profile")]
        Profile = 14,

        /// <summary>
        /// Enum Pushreaction for value: push_reaction
        /// </summary>
        [EnumMember(Value = "push_reaction")]
        Pushreaction = 15,

        /// <summary>
        /// Enum Commerceevent for value: commerce_event
        /// </summary>
        [EnumMember(Value = "commerce_event")]
        Commerceevent = 16,

        /// <summary>
        /// Enum Userattributechange for value: user_attribute_change
        /// </summary>
        [EnumMember(Value = "user_attribute_change")]
        Userattributechange = 17,

        /// <summary>
        /// Enum Useridentitychange for value: user_identity_change
        /// </summary>
        [EnumMember(Value = "user_identity_change")]
        Useridentitychange = 18,

        /// <summary>
        /// Enum Uninstall for value: uninstall
        /// </summary>
        [EnumMember(Value = "uninstall")]
        Uninstall = 19

    }

}
