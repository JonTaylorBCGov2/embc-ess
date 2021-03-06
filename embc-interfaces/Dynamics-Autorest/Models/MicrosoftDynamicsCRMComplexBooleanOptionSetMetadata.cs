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
    /// ComplexBooleanOptionSetMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata class.
        /// </summary>
        /// <param name="optionSetType">Possible values include: 'Picklist',
        /// 'State', 'Status', 'Boolean'</param>
        public MicrosoftDynamicsCRMComplexBooleanOptionSetMetadata(MicrosoftDynamicsCRMOptionMetadata trueOption = default(MicrosoftDynamicsCRMOptionMetadata), MicrosoftDynamicsCRMOptionMetadata falseOption = default(MicrosoftDynamicsCRMOptionMetadata), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), bool? isCustomOptionSet = default(bool?), bool? isGlobal = default(bool?), bool? isManaged = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string name = default(string), string externalTypeName = default(string), string optionSetType = default(string), string introducedVersion = default(string), string metadataId = default(string), bool? hasChanged = default(bool?))
        {
            TrueOption = trueOption;
            FalseOption = falseOption;
            Description = description;
            DisplayName = displayName;
            IsCustomOptionSet = isCustomOptionSet;
            IsGlobal = isGlobal;
            IsManaged = isManaged;
            IsCustomizable = isCustomizable;
            Name = name;
            ExternalTypeName = externalTypeName;
            OptionSetType = optionSetType;
            IntroducedVersion = introducedVersion;
            MetadataId = metadataId;
            HasChanged = hasChanged;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TrueOption")]
        public MicrosoftDynamicsCRMOptionMetadata TrueOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FalseOption")]
        public MicrosoftDynamicsCRMOptionMetadata FalseOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public MicrosoftDynamicsCRMLabel Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public MicrosoftDynamicsCRMLabel DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomOptionSet")]
        public bool? IsCustomOptionSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsGlobal")]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExternalTypeName")]
        public string ExternalTypeName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Picklist', 'State',
        /// 'Status', 'Boolean'
        /// </summary>
        [JsonProperty(PropertyName = "OptionSetType")]
        public string OptionSetType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

    }
}
