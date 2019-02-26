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
    /// RetrieveAbsoluteAndSiteCollectionUrlResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveAbsoluteAndSiteCollectionUrlResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAbsoluteAndSiteCollectionUrlResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAbsoluteAndSiteCollectionUrlResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveAbsoluteAndSiteCollectionUrlResponse
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveAbsoluteAndSiteCollectionUrlResponse(string absoluteUrl = default(string), string siteCollectionUrl = default(string))
        {
            AbsoluteUrl = absoluteUrl;
            SiteCollectionUrl = siteCollectionUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AbsoluteUrl")]
        public string AbsoluteUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SiteCollectionUrl")]
        public string SiteCollectionUrl { get; set; }

    }
}
