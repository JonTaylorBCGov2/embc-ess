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
    /// postcomment
    /// </summary>
    public partial class MicrosoftDynamicsCRMpostcomment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostcomment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostcomment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMpostcomment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMpostcomment(string text = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), int? utcconversiontimezonecode = default(int?), string _createdbyValue = default(string), string _postidValue = default(string), string postcommentid = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMpost postid = default(MicrosoftDynamicsCRMpost))
        {
            Text = text;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdbyValue = _createdbyValue;
            this._postidValue = _postidValue;
            Postcommentid = postcommentid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdby = createdby;
            Organizationid = organizationid;
            Createdonbehalfby = createdonbehalfby;
            Postid = postid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_postid_value")]
        public string _postidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postcommentid")]
        public string Postcommentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postid")]
        public MicrosoftDynamicsCRMpost Postid { get; set; }

    }
}
