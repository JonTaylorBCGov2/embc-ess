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
    /// FilterExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMFilterExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFilterExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMFilterExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMFilterExpression class.
        /// </summary>
        /// <param name="filterOperator">Possible values include: 'And',
        /// 'Or'</param>
        public MicrosoftDynamicsCRMFilterExpression(string filterOperator = default(string), string filterHint = default(string), IList<MicrosoftDynamicsCRMConditionExpression> conditions = default(IList<MicrosoftDynamicsCRMConditionExpression>), IList<MicrosoftDynamicsCRMFilterExpression> filters = default(IList<MicrosoftDynamicsCRMFilterExpression>), bool? isQuickFindFilter = default(bool?))
        {
            FilterOperator = filterOperator;
            FilterHint = filterHint;
            Conditions = conditions;
            Filters = filters;
            IsQuickFindFilter = isQuickFindFilter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'And', 'Or'
        /// </summary>
        [JsonProperty(PropertyName = "FilterOperator")]
        public string FilterOperator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilterHint")]
        public string FilterHint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Conditions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMConditionExpression> Conditions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Filters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMFilterExpression> Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsQuickFindFilter")]
        public bool? IsQuickFindFilter { get; set; }

    }
}
