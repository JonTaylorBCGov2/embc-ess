// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// systemuserroles
    /// </summary>
    public partial class MicrosoftDynamicsCRMsystemuserroles
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserroles class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserroles()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserroles class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserroles(long? versionnumber = default(long?), string systemuserroleid = default(string), string roleid = default(string), string systemuserid = default(string))
        {
            Versionnumber = versionnumber;
            Systemuserroleid = systemuserroleid;
            Roleid = roleid;
            Systemuserid = systemuserid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserroleid")]
        public string Systemuserroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleid")]
        public string Roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserid")]
        public string Systemuserid { get; set; }

    }
}
