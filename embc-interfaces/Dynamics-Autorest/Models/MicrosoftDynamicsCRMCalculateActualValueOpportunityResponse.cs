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
    /// CalculateActualValueOpportunityResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCalculateActualValueOpportunityResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCalculateActualValueOpportunityResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCalculateActualValueOpportunityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCalculateActualValueOpportunityResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCalculateActualValueOpportunityResponse(object value = default(object))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        [NotMapped] public object Value { get; set; }

    }
}
