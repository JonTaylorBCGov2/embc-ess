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
    /// ComplexEnumAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexEnumAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexEnumAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexEnumAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexEnumAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexEnumAttributeMetadata(int? defaultFormValue = default(int?), MicrosoftDynamicsCRMComplexOptionSetMetadata optionSet = default(MicrosoftDynamicsCRMComplexOptionSetMetadata))
        {
            DefaultFormValue = defaultFormValue;
            OptionSet = optionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultFormValue")]
        public int? DefaultFormValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OptionSet")]
        public MicrosoftDynamicsCRMComplexOptionSetMetadata OptionSet { get; set; }

    }
}
