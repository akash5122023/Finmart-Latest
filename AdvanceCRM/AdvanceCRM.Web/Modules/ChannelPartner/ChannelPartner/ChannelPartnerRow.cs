using AdvanceCRM.Masters;
using AdvanceCRM.Operations;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.ChannelPartner
{
    [ConnectionKey("Default"), Module("ChannelPartner"), TableName("[dbo].[ChannelPartner]")]
    [DisplayName("Channel Partner"), InstanceName("Channel Partner")]
    [ReadPermission("ChannelPartner:Read")]
    [InsertPermission("ChannelPartner:Insert")]
    [UpdatePermission("ChannelPartner:Update")]
    [DeletePermission("ChannelPartner:Delete")]
    [LookupScript("ChannelPartner.ChannelPartner", Permission = "?")]
    public sealed class ChannelPartnerRow : Row<ChannelPartnerRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Bank Name"), ForeignKey("[dbo].[BankName]", "Id"), LeftJoin("jBankName"), TextualField("BankNameBankNames")]
        public Int32? BankNameId
        {
            get => fields.BankNameId[this];
            set => fields.BankNameId[this] = value;
        }

        [DisplayName("Bank Sales Manager Name"), Size(255), QuickSearch, NameProperty]
        public String BankSalesManagerName
        {
            get => fields.BankSalesManagerName[this];
            set => fields.BankSalesManagerName[this] = value;
        }

        [DisplayName("Loan Product"), ForeignKey("[dbo].[TypesofProducts]", "Id"), LeftJoin("jTypesofProducts"), TextualField("ProductTypeName"), QuickFilter]
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Loan Amount"), Size(19), Scale(5)]
        public Decimal? LoanAmount
        {
            get => fields.LoanAmount[this];
            set => fields.LoanAmount[this] = value;
        }

        [DisplayName("Login Date")]
        public DateTime? LoginDate
        {
            get => fields.LoginDate[this];
            set => fields.LoginDate[this] = value;
        }

        [DisplayName("Mis Disbursement Status"), Column("MISDisbursementStatusId"), ForeignKey("[dbo].[MISDisbursementStatus]", "Id"), LeftJoin("jMisDisbursementStatus"), TextualField("MisDisbursementStatusMisDisbursementStatusType")]
        [LookupEditor(typeof(MisDisbursementProcessRow))]
        public Int32? MisDisbursementStatusId
        {
            get => fields.MisDisbursementStatusId[this];
            set => fields.MisDisbursementStatusId[this] = value;
        }

        [DisplayName("Disbursement Date")]
        public DateTime? DisbursementDate
        {
            get => fields.DisbursementDate[this];
            set => fields.DisbursementDate[this] = value;
        }

        [DisplayName("Disbursed Amount"), Size(19), Scale(5)]
        public Decimal? DisbursedAmount
        {
            get => fields.DisbursedAmount[this];
            set => fields.DisbursedAmount[this] = value;
        }

        [DisplayName("Owner"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jOwner"), TextualField("OwnerUsername"), ReadOnly(true)]
        public Int32? OwnerId
        {
            get => fields.OwnerId[this];
            set => fields.OwnerId[this] = value;
        }

        [DisplayName("Bank Names"), Expression("jBankName.[BankNames]")]
        public String BankNameBankNames
        {
            get => fields.BankNameBankNames[this];
            set => fields.BankNameBankNames[this] = value;
        }

        [DisplayName("Product Type Name"), Expression("jTypesofProducts.[ProductTypeName]")]
        public String ProductProductTypeName
        {
            get => fields.ProductProductTypeName[this];
            set => fields.ProductProductTypeName[this] = value;
        }

        [DisplayName("Disbursement Status"), Expression("jMisDisbursementStatus.[MISDisbursementStatusType]")]
        public String MisDisbursementStatusMisDisbursementStatusType
        {
            get => fields.MisDisbursementStatusMisDisbursementStatusType[this];
            set => fields.MisDisbursementStatusMisDisbursementStatusType[this] = value;
        }

        [DisplayName("Owner Username"), Expression("jOwner.[Username]")]
        public String OwnerUsername
        {
            get => fields.OwnerUsername[this];
            set => fields.OwnerUsername[this] = value;
        }

        [DisplayName("Owner Display Name"), Expression("jOwner.[DisplayName]")]
        public String OwnerDisplayName
        {
            get => fields.OwnerDisplayName[this];
            set => fields.OwnerDisplayName[this] = value;
        }

        [DisplayName("Owner Email"), Expression("jOwner.[Email]")]
        public String OwnerEmail
        {
            get => fields.OwnerEmail[this];
            set => fields.OwnerEmail[this] = value;
        }

        [DisplayName("Owner Upper Level"), Expression("jOwner.[UpperLevel]")]
        public Int32? OwnerUpperLevel
        {
            get => fields.OwnerUpperLevel[this];
            set => fields.OwnerUpperLevel[this] = value;
        }

        [DisplayName("Owner Upper Level2"), Expression("jOwner.[UpperLevel2]")]
        public Int32? OwnerUpperLevel2
        {
            get => fields.OwnerUpperLevel2[this];
            set => fields.OwnerUpperLevel2[this] = value;
        }

        [DisplayName("Owner Upper Level3"), Expression("jOwner.[UpperLevel3]")]
        public Int32? OwnerUpperLevel3
        {
            get => fields.OwnerUpperLevel3[this];
            set => fields.OwnerUpperLevel3[this] = value;
        }

        [DisplayName("Owner Upper Level4"), Expression("jOwner.[UpperLevel4]")]
        public Int32? OwnerUpperLevel4
        {
            get => fields.OwnerUpperLevel4[this];
            set => fields.OwnerUpperLevel4[this] = value;
        }

        [DisplayName("Owner Upper Level5"), Expression("jOwner.[UpperLevel5]")]
        public Int32? OwnerUpperLevel5
        {
            get => fields.OwnerUpperLevel5[this];
            set => fields.OwnerUpperLevel5[this] = value;
        }

        [DisplayName("Owner Host"), Expression("jOwner.[Host]")]
        public String OwnerHost
        {
            get => fields.OwnerHost[this];
            set => fields.OwnerHost[this] = value;
        }

        [DisplayName("Owner Port"), Expression("jOwner.[Port]")]
        public Int32? OwnerPort
        {
            get => fields.OwnerPort[this];
            set => fields.OwnerPort[this] = value;
        }

        [DisplayName("Owner Ssl"), Expression("jOwner.[SSL]")]
        public Boolean? OwnerSsl
        {
            get => fields.OwnerSsl[this];
            set => fields.OwnerSsl[this] = value;
        }

        [DisplayName("Owner Email Id"), Expression("jOwner.[EmailId]")]
        public String OwnerEmailId
        {
            get => fields.OwnerEmailId[this];
            set => fields.OwnerEmailId[this] = value;
        }

        [DisplayName("Owner Email Password"), Expression("jOwner.[EmailPassword]")]
        public String OwnerEmailPassword
        {
            get => fields.OwnerEmailPassword[this];
            set => fields.OwnerEmailPassword[this] = value;
        }

        [DisplayName("Owner Phone"), Expression("jOwner.[Phone]")]
        public String OwnerPhone
        {
            get => fields.OwnerPhone[this];
            set => fields.OwnerPhone[this] = value;
        }

        [DisplayName("Owner Mcsmtp Server"), Expression("jOwner.[MCSMTPServer]")]
        public String OwnerMcsmtpServer
        {
            get => fields.OwnerMcsmtpServer[this];
            set => fields.OwnerMcsmtpServer[this] = value;
        }

        [DisplayName("Owner Mcsmtp Port"), Expression("jOwner.[MCSMTPPort]")]
        public Int32? OwnerMcsmtpPort
        {
            get => fields.OwnerMcsmtpPort[this];
            set => fields.OwnerMcsmtpPort[this] = value;
        }

        [DisplayName("Owner Mcimap Server"), Expression("jOwner.[MCIMAPServer]")]
        public String OwnerMcimapServer
        {
            get => fields.OwnerMcimapServer[this];
            set => fields.OwnerMcimapServer[this] = value;
        }

        [DisplayName("Owner Mcimap Port"), Expression("jOwner.[MCIMAPPort]")]
        public Int32? OwnerMcimapPort
        {
            get => fields.OwnerMcimapPort[this];
            set => fields.OwnerMcimapPort[this] = value;
        }

        [DisplayName("Owner Mc Username"), Expression("jOwner.[MCUsername]")]
        public String OwnerMcUsername
        {
            get => fields.OwnerMcUsername[this];
            set => fields.OwnerMcUsername[this] = value;
        }

        [DisplayName("Owner Mc Password"), Expression("jOwner.[MCPassword]")]
        public String OwnerMcPassword
        {
            get => fields.OwnerMcPassword[this];
            set => fields.OwnerMcPassword[this] = value;
        }

        [DisplayName("Owner Start Time"), Expression("jOwner.[StartTime]")]
        public String OwnerStartTime
        {
            get => fields.OwnerStartTime[this];
            set => fields.OwnerStartTime[this] = value;
        }

        [DisplayName("Owner End Time"), Expression("jOwner.[EndTime]")]
        public String OwnerEndTime
        {
            get => fields.OwnerEndTime[this];
            set => fields.OwnerEndTime[this] = value;
        }

        [DisplayName("Owner Uid"), Expression("jOwner.[UID]")]
        public String OwnerUid
        {
            get => fields.OwnerUid[this];
            set => fields.OwnerUid[this] = value;
        }

        [DisplayName("Owner Non Operational"), Expression("jOwner.[NonOperational]")]
        public Boolean? OwnerNonOperational
        {
            get => fields.OwnerNonOperational[this];
            set => fields.OwnerNonOperational[this] = value;
        }

        [DisplayName("Owner Branch Id"), Expression("jOwner.[BranchId]")]
        public Int32? OwnerBranchId
        {
            get => fields.OwnerBranchId[this];
            set => fields.OwnerBranchId[this] = value;
        }

        [DisplayName("Owner Company Id"), Expression("jOwner.[CompanyId]")]
        public Int32? OwnerCompanyId
        {
            get => fields.OwnerCompanyId[this];
            set => fields.OwnerCompanyId[this] = value;
        }

        [DisplayName("Owner Enquiry"), Expression("jOwner.[Enquiry]")]
        public Boolean? OwnerEnquiry
        {
            get => fields.OwnerEnquiry[this];
            set => fields.OwnerEnquiry[this] = value;
        }

        [DisplayName("Owner Quotation"), Expression("jOwner.[Quotation]")]
        public Boolean? OwnerQuotation
        {
            get => fields.OwnerQuotation[this];
            set => fields.OwnerQuotation[this] = value;
        }

        [DisplayName("Owner Tasks"), Expression("jOwner.[Tasks]")]
        public Boolean? OwnerTasks
        {
            get => fields.OwnerTasks[this];
            set => fields.OwnerTasks[this] = value;
        }

        [DisplayName("Owner Contacts"), Expression("jOwner.[Contacts]")]
        public Boolean? OwnerContacts
        {
            get => fields.OwnerContacts[this];
            set => fields.OwnerContacts[this] = value;
        }

        [DisplayName("Owner Purchase"), Expression("jOwner.[Purchase]")]
        public Boolean? OwnerPurchase
        {
            get => fields.OwnerPurchase[this];
            set => fields.OwnerPurchase[this] = value;
        }

        [DisplayName("Owner Sales"), Expression("jOwner.[Sales]")]
        public Boolean? OwnerSales
        {
            get => fields.OwnerSales[this];
            set => fields.OwnerSales[this] = value;
        }

        [DisplayName("Owner Cms"), Expression("jOwner.[CMS]")]
        public Boolean? OwnerCms
        {
            get => fields.OwnerCms[this];
            set => fields.OwnerCms[this] = value;
        }

        [DisplayName("Owner Location"), Expression("jOwner.[Location]")]
        public String OwnerLocation
        {
            get => fields.OwnerLocation[this];
            set => fields.OwnerLocation[this] = value;
        }

        [DisplayName("Owner Coordinates"), Expression("jOwner.[Coordinates]")]
        public String OwnerCoordinates
        {
            get => fields.OwnerCoordinates[this];
            set => fields.OwnerCoordinates[this] = value;
        }

        [DisplayName("Owner Teams Id"), Expression("jOwner.[TeamsId]")]
        public Int32? OwnerTeamsId
        {
            get => fields.OwnerTeamsId[this];
            set => fields.OwnerTeamsId[this] = value;
        }

        [DisplayName("Owner Tenant Id"), Expression("jOwner.[TenantId]")]
        public Int32? OwnerTenantId
        {
            get => fields.OwnerTenantId[this];
            set => fields.OwnerTenantId[this] = value;
        }

        [DisplayName("Owner Url"), Expression("jOwner.[Url]")]
        public String OwnerUrl
        {
            get => fields.OwnerUrl[this];
            set => fields.OwnerUrl[this] = value;
        }

        [DisplayName("Owner Plan"), Expression("jOwner.[Plan]")]
        public String OwnerPlan
        {
            get => fields.OwnerPlan[this];
            set => fields.OwnerPlan[this] = value;
        }

        public ChannelPartnerRow()
            : base()
        {
        }

        public ChannelPartnerRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field BankNameId;
            public StringField BankSalesManagerName;
            public Int32Field ProductId;
            public DecimalField LoanAmount;
            public DateTimeField LoginDate;
            public Int32Field MisDisbursementStatusId;
            public DateTimeField DisbursementDate;
            public DecimalField DisbursedAmount;
            public Int32Field OwnerId;

            public StringField BankNameBankNames;

            public StringField ProductProductTypeName;

            public StringField MisDisbursementStatusMisDisbursementStatusType;

            public StringField OwnerUsername;
            public StringField OwnerDisplayName;
            public StringField OwnerEmail;
            public Int32Field OwnerUpperLevel;
            public Int32Field OwnerUpperLevel2;
            public Int32Field OwnerUpperLevel3;
            public Int32Field OwnerUpperLevel4;
            public Int32Field OwnerUpperLevel5;
            public StringField OwnerHost;
            public Int32Field OwnerPort;
            public BooleanField OwnerSsl;
            public StringField OwnerEmailId;
            public StringField OwnerEmailPassword;
            public StringField OwnerPhone;
            public StringField OwnerMcsmtpServer;
            public Int32Field OwnerMcsmtpPort;
            public StringField OwnerMcimapServer;
            public Int32Field OwnerMcimapPort;
            public StringField OwnerMcUsername;
            public StringField OwnerMcPassword;
            public StringField OwnerStartTime;
            public StringField OwnerEndTime;
            public StringField OwnerUid;
            public BooleanField OwnerNonOperational;
            public Int32Field OwnerBranchId;
            public Int32Field OwnerCompanyId;
            public BooleanField OwnerEnquiry;
            public BooleanField OwnerQuotation;
            public BooleanField OwnerTasks;
            public BooleanField OwnerContacts;
            public BooleanField OwnerPurchase;
            public BooleanField OwnerSales;
            public BooleanField OwnerCms;
            public StringField OwnerLocation;
            public StringField OwnerCoordinates;
            public Int32Field OwnerTeamsId;
            public Int32Field OwnerTenantId;
            public StringField OwnerUrl;
            public StringField OwnerPlan;
        }
    }
}
