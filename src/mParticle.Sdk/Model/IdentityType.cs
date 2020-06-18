using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace mParticle.Model
{
    /// <summary>
    /// Defines IdentityType
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum IdentityType
    {
        /// <summary>
        /// Enum Other for value: other
        /// </summary>
        [EnumMember(Value = "other")]
        Other = 1,

        /// <summary>
        /// Enum Customerid for value: customer_id
        /// </summary>
        [EnumMember(Value = "customer_id")]
        Customerid = 2,

        /// <summary>
        /// Enum Facebook for value: facebook
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook = 3,

        /// <summary>
        /// Enum Twitter for value: twitter
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter = 4,

        /// <summary>
        /// Enum Google for value: google
        /// </summary>
        [EnumMember(Value = "google")]
        Google = 5,

        /// <summary>
        /// Enum Microsoft for value: microsoft
        /// </summary>
        [EnumMember(Value = "microsoft")]
        Microsoft = 6,

        /// <summary>
        /// Enum Yahoo for value: yahoo
        /// </summary>
        [EnumMember(Value = "yahoo")]
        Yahoo = 7,

        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        [EnumMember(Value = "email")]
        Email = 8,

        /// <summary>
        /// Enum Alias for value: alias
        /// </summary>
        [EnumMember(Value = "alias")]
        Alias = 9,

        /// <summary>
        /// Enum Facebookcustomaudienceid for value: facebook_custom_audience_id
        /// </summary>
        [EnumMember(Value = "facebook_custom_audience_id")]
        Facebookcustomaudienceid = 10,

        /// <summary>
        /// Enum Otherid2 for value: other_id_2
        /// </summary>
        [EnumMember(Value = "other_id_2")]
        Otherid2 = 11,

        /// <summary>
        /// Enum Otherid3 for value: other_id_3
        /// </summary>
        [EnumMember(Value = "other_id_3")]
        Otherid3 = 12,

        /// <summary>
        /// Enum Otherid4 for value: other_id_4
        /// </summary>
        [EnumMember(Value = "other_id_4")]
        Otherid4 = 13,

        /// <summary>
        /// Enum Otherid5 for value: other_id_5
        /// </summary>
        [EnumMember(Value = "other_id_5")]
        Otherid5 = 14,

        /// <summary>
        /// Enum Otherid6 for value: other_id_6
        /// </summary>
        [EnumMember(Value = "other_id_6")]
        Otherid6 = 15,

        /// <summary>
        /// Enum Otherid7 for value: other_id_7
        /// </summary>
        [EnumMember(Value = "other_id_7")]
        Otherid7 = 16,

        /// <summary>
        /// Enum Otherid8 for value: other_id_8
        /// </summary>
        [EnumMember(Value = "other_id_8")]
        Otherid8 = 17,

        /// <summary>
        /// Enum Otherid9 for value: other_id_9
        /// </summary>
        [EnumMember(Value = "other_id_9")]
        Otherid9 = 18,

        /// <summary>
        /// Enum Otherid10 for value: other_id_10
        /// </summary>
        [EnumMember(Value = "other_id_10")]
        Otherid10 = 19,

        /// <summary>
        /// Enum Mobilenumber for value: mobile_number
        /// </summary>
        [EnumMember(Value = "mobile_number")]
        Mobilenumber = 20,

        /// <summary>
        /// Enum Phonenumber2 for value: phone_number_2
        /// </summary>
        [EnumMember(Value = "phone_number_2")]
        Phonenumber2 = 21,

        /// <summary>
        /// Enum Phonenumber3 for value: phone_number_3
        /// </summary>
        [EnumMember(Value = "phone_number_3")]
        Phonenumber3 = 22

    }

}
