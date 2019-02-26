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
    /// bookableresourcegroup
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresourcegroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcegroup class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcegroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcegroup class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcegroup(string bookableresourcegroupid = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), int? statecode = default(int?), string _owneridValue = default(string), string _owningteamValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? todate = default(System.DateTimeOffset?), string name = default(string), object exchangerate = default(object), int? timezoneruleversionnumber = default(int?), long? versionnumber = default(long?), string _owninguserValue = default(string), string _createdbyValue = default(string), string _childresourceValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), string _parentresourceValue = default(string), System.DateTimeOffset? fromdate = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceGroupSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcegroupDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcegroupDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourcegroupAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourcegroupMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourcegroupProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourcegroupBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcegroupPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> bookableresourcegroupAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMbookableresource childResource = default(MicrosoftDynamicsCRMbookableresource), MicrosoftDynamicsCRMbookableresource parentResource = default(MicrosoftDynamicsCRMbookableresource), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Bookableresourcegroupid = bookableresourcegroupid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statecode = statecode;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            Todate = todate;
            Name = name;
            Exchangerate = exchangerate;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Versionnumber = versionnumber;
            this._owninguserValue = _owninguserValue;
            this._createdbyValue = _createdbyValue;
            this._childresourceValue = _childresourceValue;
            Modifiedon = modifiedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._parentresourceValue = _parentresourceValue;
            Fromdate = fromdate;
            Createdon = createdon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableResourceGroupSyncErrors = bookableResourceGroupSyncErrors;
            BookableresourcegroupDuplicateMatchingRecord = bookableresourcegroupDuplicateMatchingRecord;
            BookableresourcegroupDuplicateBaseRecord = bookableresourcegroupDuplicateBaseRecord;
            BookableresourcegroupAsyncOperations = bookableresourcegroupAsyncOperations;
            BookableresourcegroupMailboxTrackingFolders = bookableresourcegroupMailboxTrackingFolders;
            BookableresourcegroupProcessSession = bookableresourcegroupProcessSession;
            BookableresourcegroupBulkDeleteFailures = bookableresourcegroupBulkDeleteFailures;
            BookableresourcegroupPrincipalObjectAttributeAccesses = bookableresourcegroupPrincipalObjectAttributeAccesses;
            BookableresourcegroupAnnotations = bookableresourcegroupAnnotations;
            ChildResource = childResource;
            ParentResource = parentResource;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroupid")]
        public string Bookableresourcegroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "todate")]
        public System.DateTimeOffset? Todate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_childresource_value")]
        public string _childresourceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "_parentresource_value")]
        public string _parentresourceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromdate")]
        public System.DateTimeOffset? Fromdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "BookableResourceGroup_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceGroupSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcegroupDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcegroupDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourcegroupAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourcegroupMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> BookableresourcegroupProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourcegroupBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcegroupPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcegroup_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> BookableresourcegroupAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChildResource")]
        public MicrosoftDynamicsCRMbookableresource ChildResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentResource")]
        public MicrosoftDynamicsCRMbookableresource ParentResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
