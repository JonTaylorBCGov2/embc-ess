// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// LookupDataResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMLookupDataResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupDataResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupDataResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupDataResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupDataResponse(IList<object> entityResponses = default(IList<object>))
        {
            EntityResponses = entityResponses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityResponses")]
        [NotMapped] public IList<object> EntityResponses { get; set; }

    }
}
