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
    /// AttributeQueryExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMAttributeQueryExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeQueryExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMAttributeQueryExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMAttributeQueryExpression(MicrosoftDynamicsCRMMetadataFilterExpression criteria = default(MicrosoftDynamicsCRMMetadataFilterExpression), MicrosoftDynamicsCRMMetadataPropertiesExpression properties = default(MicrosoftDynamicsCRMMetadataPropertiesExpression))
        {
            Criteria = criteria;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Criteria")]
        public MicrosoftDynamicsCRMMetadataFilterExpression Criteria { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public MicrosoftDynamicsCRMMetadataPropertiesExpression Properties { get; set; }

    }
}
