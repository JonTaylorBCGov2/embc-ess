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
    /// ratingmodel
    /// </summary>
    public partial class MicrosoftDynamicsCRMratingmodel
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMratingmodel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMratingmodel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMratingmodel
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMratingmodel(string _transactioncurrencyidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? minratingvalue = default(int?), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), long? versionnumber = default(long?), int? statecode = default(int?), string _owningteamValue = default(string), object exchangerate = default(object), string ratingmodelid = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string name = default(string), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), int? maxratingvalue = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> ratingModelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> ratingmodelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> ratingmodelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> ratingmodelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ratingmodelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ratingmodelProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ratingmodelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ratingmodelPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMratingvalue> ratingmodelRatingvalueRatingModel = default(IList<MicrosoftDynamicsCRMratingvalue>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            Minratingvalue = minratingvalue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Versionnumber = versionnumber;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Exchangerate = exchangerate;
            Ratingmodelid = ratingmodelid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Name = name;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Maxratingvalue = maxratingvalue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            RatingModelSyncErrors = ratingModelSyncErrors;
            RatingmodelDuplicateMatchingRecord = ratingmodelDuplicateMatchingRecord;
            RatingmodelDuplicateBaseRecord = ratingmodelDuplicateBaseRecord;
            RatingmodelAsyncOperations = ratingmodelAsyncOperations;
            RatingmodelMailboxTrackingFolders = ratingmodelMailboxTrackingFolders;
            RatingmodelProcessSession = ratingmodelProcessSession;
            RatingmodelBulkDeleteFailures = ratingmodelBulkDeleteFailures;
            RatingmodelPrincipalObjectAttributeAccesses = ratingmodelPrincipalObjectAttributeAccesses;
            RatingmodelRatingvalueRatingModel = ratingmodelRatingvalueRatingModel;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minratingvalue")]
        public int? Minratingvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodelid")]
        public string Ratingmodelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxratingvalue")]
        public int? Maxratingvalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RatingModel_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> RatingModelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> RatingmodelDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> RatingmodelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> RatingmodelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> RatingmodelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> RatingmodelProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> RatingmodelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> RatingmodelPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ratingmodel_ratingvalue_RatingModel")]
        [NotMapped] public IList<MicrosoftDynamicsCRMratingvalue> RatingmodelRatingvalueRatingModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
