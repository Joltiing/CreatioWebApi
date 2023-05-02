using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysCulture
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public Guid? LanguageId { get; set; }

    public Guid? ImageId { get; set; }

    public int Index { get; set; }

    public int ProcessListeners { get; set; }

    public bool Default { get; set; }

    public virtual SysImage? Image { get; set; }

    public virtual SysLanguage? Language { get; set; }

    public virtual ICollection<MainParamLczOld> MainParamLczOlds { get; set; } = new List<MainParamLczOld>();

    public virtual ICollection<SysAcademyUrllcz> SysAcademyUrllczs { get; set; } = new List<SysAcademyUrllcz>();

    public virtual ICollection<SysAccountAlternativeNameLcz> SysAccountAlternativeNameLczs { get; set; } = new List<SysAccountAlternativeNameLcz>();

    public virtual ICollection<SysAccountAnnualRevenueLcz> SysAccountAnnualRevenueLczs { get; set; } = new List<SysAccountAnnualRevenueLcz>();

    public virtual ICollection<SysAccountBillingInfoLcz> SysAccountBillingInfoLczs { get; set; } = new List<SysAccountBillingInfoLcz>();

    public virtual ICollection<SysAccountCategoryLcz> SysAccountCategoryLczs { get; set; } = new List<SysAccountCategoryLcz>();

    public virtual ICollection<SysAccountEmployeesNumberLcz> SysAccountEmployeesNumberLczs { get; set; } = new List<SysAccountEmployeesNumberLcz>();

    public virtual ICollection<SysAccountFolderLcz> SysAccountFolderLczs { get; set; } = new List<SysAccountFolderLcz>();

    public virtual ICollection<SysAccountIndustryLcz> SysAccountIndustryLczs { get; set; } = new List<SysAccountIndustryLcz>();

    public virtual ICollection<SysAccountOwnershipLcz> SysAccountOwnershipLczs { get; set; } = new List<SysAccountOwnershipLcz>();

    public virtual ICollection<SysAccountTypeLcz> SysAccountTypeLczs { get; set; } = new List<SysAccountTypeLcz>();

    public virtual ICollection<SysActivityCategoryLcz> SysActivityCategoryLczs { get; set; } = new List<SysActivityCategoryLcz>();

    public virtual ICollection<SysActivityFolderLcz> SysActivityFolderLczs { get; set; } = new List<SysActivityFolderLcz>();

    public virtual ICollection<SysActivityParticipantRoleLcz> SysActivityParticipantRoleLczs { get; set; } = new List<SysActivityParticipantRoleLcz>();

    public virtual ICollection<SysActivityPriorityLcz> SysActivityPriorityLczs { get; set; } = new List<SysActivityPriorityLcz>();

    public virtual ICollection<SysActivityResultCategoryLcz> SysActivityResultCategoryLczs { get; set; } = new List<SysActivityResultCategoryLcz>();

    public virtual ICollection<SysActivityResultLcz> SysActivityResultLczs { get; set; } = new List<SysActivityResultLcz>();

    public virtual ICollection<SysActivityStatusLcz> SysActivityStatusLczs { get; set; } = new List<SysActivityStatusLcz>();

    public virtual ICollection<SysActivityTypeLcz> SysActivityTypeLczs { get; set; } = new List<SysActivityTypeLcz>();

    public virtual ICollection<SysAdditionalParamLcz> SysAdditionalParamLczs { get; set; } = new List<SysAdditionalParamLcz>();

    public virtual ICollection<SysAddressTypeLcz> SysAddressTypeLczs { get; set; } = new List<SysAddressTypeLcz>();

    public virtual ICollection<SysAdminOperationFolderLcz> SysAdminOperationFolderLczs { get; set; } = new List<SysAdminOperationFolderLcz>();

    public virtual ICollection<SysAdminOperationLcz> SysAdminOperationLczs { get; set; } = new List<SysAdminOperationLcz>();

    public virtual ICollection<SysAdminUnitFolderLcz> SysAdminUnitFolderLczs { get; set; } = new List<SysAdminUnitFolderLcz>();

    public virtual ICollection<SysAdminUnitTypeLcz> SysAdminUnitTypeLczs { get; set; } = new List<SysAdminUnitTypeLcz>();

    public virtual ICollection<SysAdminUnit> SysAdminUnits { get; set; } = new List<SysAdminUnit>();

    public virtual ICollection<SysAggregationTypeLcz> SysAggregationTypeLczs { get; set; } = new List<SysAggregationTypeLcz>();

    public virtual ICollection<SysAnniversaryTypeLcz> SysAnniversaryTypeLczs { get; set; } = new List<SysAnniversaryTypeLcz>();

    public virtual ICollection<SysAppTemplateLcz> SysAppTemplateLczs { get; set; } = new List<SysAppTemplateLcz>();

    public virtual ICollection<SysApplicationClientTypeLcz> SysApplicationClientTypeLczs { get; set; } = new List<SysApplicationClientTypeLcz>();

    public virtual ICollection<SysApplicationMainMenuLcz> SysApplicationMainMenuLczs { get; set; } = new List<SysApplicationMainMenuLcz>();

    public virtual ICollection<SysAttributeLcz> SysAttributeLczs { get; set; } = new List<SysAttributeLcz>();

    public virtual ICollection<SysBaseValueLookupLcz> SysBaseValueLookupLczs { get; set; } = new List<SysBaseValueLookupLcz>();

    public virtual ICollection<SysBrandLcz> SysBrandLczs { get; set; } = new List<SysBrandLcz>();

    public virtual ICollection<SysBuildTypeEntityLcz> SysBuildTypeEntityLczs { get; set; } = new List<SysBuildTypeEntityLcz>();

    public virtual ICollection<SysCalendarLcz> SysCalendarLczs { get; set; } = new List<SysCalendarLcz>();

    public virtual ICollection<SysCallDirectionLcz> SysCallDirectionLczs { get; set; } = new List<SysCallDirectionLcz>();

    public virtual ICollection<SysCallFolderLcz> SysCallFolderLczs { get; set; } = new List<SysCallFolderLcz>();

    public virtual ICollection<SysCallTopicLcz> SysCallTopicLczs { get; set; } = new List<SysCallTopicLcz>();

    public virtual ICollection<SysChannelProviderLcz> SysChannelProviderLczs { get; set; } = new List<SysChannelProviderLcz>();

    public virtual ICollection<SysChannelStatusLcz> SysChannelStatusLczs { get; set; } = new List<SysChannelStatusLcz>();

    public virtual ICollection<SysChartAggregationTypeLcz> SysChartAggregationTypeLczs { get; set; } = new List<SysChartAggregationTypeLcz>();

    public virtual ICollection<SysChartPropertyLcz> SysChartPropertyLczs { get; set; } = new List<SysChartPropertyLcz>();

    public virtual ICollection<SysChartSeriesKindLcz> SysChartSeriesKindLczs { get; set; } = new List<SysChartSeriesKindLcz>();

    public virtual ICollection<SysChatQueueLcz> SysChatQueueLczs { get; set; } = new List<SysChatQueueLcz>();

    public virtual ICollection<SysCityLcz> SysCityLczs { get; set; } = new List<SysCityLcz>();

    public virtual ICollection<SysClientUnitSchemaSource> SysClientUnitSchemaSources { get; set; } = new List<SysClientUnitSchemaSource>();

    public virtual ICollection<SysCommandLcz> SysCommandLczs { get; set; } = new List<SysCommandLcz>();

    public virtual ICollection<SysCommunicationLcz> SysCommunicationLczs { get; set; } = new List<SysCommunicationLcz>();

    public virtual ICollection<SysCommunicationTypeLcz> SysCommunicationTypeLczs { get; set; } = new List<SysCommunicationTypeLcz>();

    public virtual ICollection<SysCompetitorProductLcz> SysCompetitorProductLczs { get; set; } = new List<SysCompetitorProductLcz>();

    public virtual ICollection<SysCompletenessLcz> SysCompletenessLczs { get; set; } = new List<SysCompletenessLcz>();

    public virtual ICollection<SysCompletenessParameterLcz> SysCompletenessParameterLczs { get; set; } = new List<SysCompletenessParameterLcz>();

    public virtual ICollection<SysConnectionTypeLcz> SysConnectionTypeLczs { get; set; } = new List<SysConnectionTypeLcz>();

    public virtual ICollection<SysContactDecisionRoleLcz> SysContactDecisionRoleLczs { get; set; } = new List<SysContactDecisionRoleLcz>();

    public virtual ICollection<SysContactFolderLcz> SysContactFolderLczs { get; set; } = new List<SysContactFolderLcz>();

    public virtual ICollection<SysContactSalutationTypeLcz> SysContactSalutationTypeLczs { get; set; } = new List<SysContactSalutationTypeLcz>();

    public virtual ICollection<SysContactTypeLcz> SysContactTypeLczs { get; set; } = new List<SysContactTypeLcz>();

    public virtual ICollection<SysContentBlockLcz> SysContentBlockLczs { get; set; } = new List<SysContentBlockLcz>();

    public virtual ICollection<SysContentBuilderFontSetLcz> SysContentBuilderFontSetLczs { get; set; } = new List<SysContentBuilderFontSetLcz>();

    public virtual ICollection<SysContentUserBlockLcz> SysContentUserBlockLczs { get; set; } = new List<SysContentUserBlockLcz>();

    public virtual ICollection<SysContextElementLcz> SysContextElementLczs { get; set; } = new List<SysContextElementLcz>();

    public virtual ICollection<SysContextHelpLcz> SysContextHelpLczs { get; set; } = new List<SysContextHelpLcz>();

    public virtual ICollection<SysCountryLcz> SysCountryLczs { get; set; } = new List<SysCountryLcz>();

    public virtual ICollection<SysCronTriggerStateLcz> SysCronTriggerStateLczs { get; set; } = new List<SysCronTriggerStateLcz>();

    public virtual ICollection<SysCurrencyLcz> SysCurrencyLczs { get; set; } = new List<SysCurrencyLcz>();

    public virtual ICollection<SysDashboardItemTypeLcz> SysDashboardItemTypeLczs { get; set; } = new List<SysDashboardItemTypeLcz>();

    public virtual ICollection<SysDashboardLcz> SysDashboardLczs { get; set; } = new List<SysDashboardLcz>();

    public virtual ICollection<SysDateTimeFormatLcz> SysDateTimeFormatLczs { get; set; } = new List<SysDateTimeFormatLcz>();

    public virtual ICollection<SysDayOfWeekLcz> SysDayOfWeekLczs { get; set; } = new List<SysDayOfWeekLcz>();

    public virtual ICollection<SysDayTypeLcz> SysDayTypeLczs { get; set; } = new List<SysDayTypeLcz>();

    public virtual ICollection<SysDeadlineCalcSchemasLcz> SysDeadlineCalcSchemasLczs { get; set; } = new List<SysDeadlineCalcSchemasLcz>();

    public virtual ICollection<SysDeduplicateMergeRulesLcz> SysDeduplicateMergeRulesLczs { get; set; } = new List<SysDeduplicateMergeRulesLcz>();

    public virtual ICollection<SysDeduplicateOperationLcz> SysDeduplicateOperationLczs { get; set; } = new List<SysDeduplicateOperationLcz>();

    public virtual ICollection<SysDepartmentLcz> SysDepartmentLczs { get; set; } = new List<SysDepartmentLcz>();

    public virtual ICollection<SysDetailLcz> SysDetailLczs { get; set; } = new List<SysDetailLcz>();

    public virtual ICollection<SysDevExpressReportLcz> SysDevExpressReportLczs { get; set; } = new List<SysDevExpressReportLcz>();

    public virtual ICollection<SysDistributionTypeLcz> SysDistributionTypeLczs { get; set; } = new List<SysDistributionTypeLcz>();

    public virtual ICollection<SysDuplicateStatusLcz> SysDuplicateStatusLczs { get; set; } = new List<SysDuplicateStatusLcz>();

    public virtual ICollection<SysDuplicatesRuleFolderLcz> SysDuplicatesRuleFolderLczs { get; set; } = new List<SysDuplicatesRuleFolderLcz>();

    public virtual ICollection<SysDuplicatesRuleLcz> SysDuplicatesRuleLczs { get; set; } = new List<SysDuplicatesRuleLcz>();

    public virtual ICollection<SysEmailProtocolLcz> SysEmailProtocolLczs { get; set; } = new List<SysEmailProtocolLcz>();

    public virtual ICollection<SysEmailSendStatusLcz> SysEmailSendStatusLczs { get; set; } = new List<SysEmailSendStatusLcz>();

    public virtual ICollection<SysEmailTemplRecipientTypeLcz> SysEmailTemplRecipientTypeLczs { get; set; } = new List<SysEmailTemplRecipientTypeLcz>();

    public virtual ICollection<SysEmailTemplateFolderLcz> SysEmailTemplateFolderLczs { get; set; } = new List<SysEmailTemplateFolderLcz>();

    public virtual ICollection<SysEmailTemplateLcz> SysEmailTemplateLczs { get; set; } = new List<SysEmailTemplateLcz>();

    public virtual ICollection<SysEmailTemplateMacrosLcz> SysEmailTemplateMacrosLczs { get; set; } = new List<SysEmailTemplateMacrosLcz>();

    public virtual ICollection<SysEmailTemplateSendFlagLcz> SysEmailTemplateSendFlagLczs { get; set; } = new List<SysEmailTemplateSendFlagLcz>();

    public virtual ICollection<SysEmailTypeLcz> SysEmailTypeLczs { get; set; } = new List<SysEmailTypeLcz>();

    public virtual ICollection<SysEmployeeFolderLcz> SysEmployeeFolderLczs { get; set; } = new List<SysEmployeeFolderLcz>();

    public virtual ICollection<SysEmployeeJobLcz> SysEmployeeJobLczs { get; set; } = new List<SysEmployeeJobLcz>();

    public virtual ICollection<SysEmployeeLcz> SysEmployeeLczs { get; set; } = new List<SysEmployeeLcz>();

    public virtual ICollection<SysEntityChangeTypeLcz> SysEntityChangeTypeLczs { get; set; } = new List<SysEntityChangeTypeLcz>();

    public virtual ICollection<SysEntityOperationLcz> SysEntityOperationLczs { get; set; } = new List<SysEntityOperationLcz>();

    public virtual ICollection<SysEntitySchColRightLevelLcz> SysEntitySchColRightLevelLczs { get; set; } = new List<SysEntitySchColRightLevelLcz>();

    public virtual ICollection<SysEntitySchParentAsscTypeLcz> SysEntitySchParentAsscTypeLczs { get; set; } = new List<SysEntitySchParentAsscTypeLcz>();

    public virtual ICollection<SysEntitySchRecOprRightLvlLcz> SysEntitySchRecOprRightLvlLczs { get; set; } = new List<SysEntitySchRecOprRightLvlLcz>();

    public virtual ICollection<SysEntitySchRecRightOprLcz> SysEntitySchRecRightOprLczs { get; set; } = new List<SysEntitySchRecRightOprLcz>();

    public virtual ICollection<SysEntitySchRecRightSourceLcz> SysEntitySchRecRightSourceLczs { get; set; } = new List<SysEntitySchRecRightSourceLcz>();

    public virtual ICollection<SysEntitySchemaReferenceLcz> SysEntitySchemaReferenceLczs { get; set; } = new List<SysEntitySchemaReferenceLcz>();

    public virtual ICollection<SysEntityTypeLookupLcz> SysEntityTypeLookupLczs { get; set; } = new List<SysEntityTypeLookupLcz>();

    public virtual ICollection<SysEsnnotificationTypeLcz> SysEsnnotificationTypeLczs { get; set; } = new List<SysEsnnotificationTypeLcz>();

    public virtual ICollection<SysExternalAccessFolderLcz> SysExternalAccessFolderLczs { get; set; } = new List<SysExternalAccessFolderLcz>();

    public virtual ICollection<SysFeatureLcz> SysFeatureLczs { get; set; } = new List<SysFeatureLcz>();

    public virtual ICollection<SysFileContentStorageLcz> SysFileContentStorageLczs { get; set; } = new List<SysFileContentStorageLcz>();

    public virtual ICollection<SysFileExtensionLcz> SysFileExtensionLczs { get; set; } = new List<SysFileExtensionLcz>();

    public virtual ICollection<SysFileFolderLcz> SysFileFolderLczs { get; set; } = new List<SysFileFolderLcz>();

    public virtual ICollection<SysFileImportTemplateLcz> SysFileImportTemplateLczs { get; set; } = new List<SysFileImportTemplateLcz>();

    public virtual ICollection<SysFileMetadataStorageLcz> SysFileMetadataStorageLczs { get; set; } = new List<SysFileMetadataStorageLcz>();

    public virtual ICollection<SysFileSecurityModeLcz> SysFileSecurityModeLczs { get; set; } = new List<SysFileSecurityModeLcz>();

    public virtual ICollection<SysFileTypeLcz> SysFileTypeLczs { get; set; } = new List<SysFileTypeLcz>();

    public virtual ICollection<SysFolderTypeLcz> SysFolderTypeLczs { get; set; } = new List<SysFolderTypeLcz>();

    public virtual ICollection<SysGenderLcz> SysGenderLczs { get; set; } = new List<SysGenderLcz>();

    public virtual ICollection<SysGeneratedWebFormFolderLcz> SysGeneratedWebFormFolderLczs { get; set; } = new List<SysGeneratedWebFormFolderLcz>();

    public virtual ICollection<SysGlobalDuplSearchStatusLcz> SysGlobalDuplSearchStatusLczs { get; set; } = new List<SysGlobalDuplSearchStatusLcz>();

    public virtual ICollection<SysGridPageViewLcz> SysGridPageViewLczs { get; set; } = new List<SysGridPageViewLcz>();

    public virtual ICollection<SysGroupByTypeDateTimeLcz> SysGroupByTypeDateTimeLczs { get; set; } = new List<SysGroupByTypeDateTimeLcz>();

    public virtual ICollection<SysHttpauthTypeLcz> SysHttpauthTypeLczs { get; set; } = new List<SysHttpauthTypeLcz>();

    public virtual ICollection<SysInformationSourceLcz> SysInformationSourceLczs { get; set; } = new List<SysInformationSourceLcz>();

    public virtual ICollection<SysInstalledAppStatusLcz> SysInstalledAppStatusLczs { get; set; } = new List<SysInstalledAppStatusLcz>();

    public virtual ICollection<SysIntegrationDirectionLcz> SysIntegrationDirectionLczs { get; set; } = new List<SysIntegrationDirectionLcz>();

    public virtual ICollection<SysIntegrationOperationLcz> SysIntegrationOperationLczs { get; set; } = new List<SysIntegrationOperationLcz>();

    public virtual ICollection<SysIntegrationResultLcz> SysIntegrationResultLczs { get; set; } = new List<SysIntegrationResultLcz>();

    public virtual ICollection<SysIntegrationSystemLcz> SysIntegrationSystemLczs { get; set; } = new List<SysIntegrationSystemLcz>();

    public virtual ICollection<SysIntroPageLookupLcz> SysIntroPageLookupLczs { get; set; } = new List<SysIntroPageLookupLcz>();

    public virtual ICollection<SysJobChangeReasonLcz> SysJobChangeReasonLczs { get; set; } = new List<SysJobChangeReasonLcz>();

    public virtual ICollection<SysJobLcz> SysJobLczs { get; set; } = new List<SysJobLcz>();

    public virtual ICollection<SysKnowledgeBaseFolderLcz> SysKnowledgeBaseFolderLczs { get; set; } = new List<SysKnowledgeBaseFolderLcz>();

    public virtual ICollection<SysKnowledgeBaseTagLcz> SysKnowledgeBaseTagLczs { get; set; } = new List<SysKnowledgeBaseTagLcz>();

    public virtual ICollection<SysKnowledgeBaseTypeLcz> SysKnowledgeBaseTypeLczs { get; set; } = new List<SysKnowledgeBaseTypeLcz>();

    public virtual ICollection<SysLandingTypeLcz> SysLandingTypeLczs { get; set; } = new List<SysLandingTypeLcz>();

    public virtual ICollection<SysLanguageLcz> SysLanguageLczs { get; set; } = new List<SysLanguageLcz>();

    public virtual ICollection<SysLdapauthTypeLcz> SysLdapauthTypeLczs { get; set; } = new List<SysLdapauthTypeLcz>();

    public virtual ICollection<SysLeadMediumLcz> SysLeadMediumLczs { get; set; } = new List<SysLeadMediumLcz>();

    public virtual ICollection<SysLeadSourceLcz> SysLeadSourceLczs { get; set; } = new List<SysLeadSourceLcz>();

    public virtual ICollection<SysLeadTypeLcz> SysLeadTypeLczs { get; set; } = new List<SysLeadTypeLcz>();

    public virtual ICollection<SysLeadTypeStatusLcz> SysLeadTypeStatusLczs { get; set; } = new List<SysLeadTypeStatusLcz>();

    public virtual ICollection<SysLendingStateLcz> SysLendingStateLczs { get; set; } = new List<SysLendingStateLcz>();

    public virtual ICollection<SysLinkContactToAccountLcz> SysLinkContactToAccountLczs { get; set; } = new List<SysLinkContactToAccountLcz>();

    public virtual ICollection<SysLocalizableValue> SysLocalizableValues { get; set; } = new List<SysLocalizableValue>();

    public virtual ICollection<SysLoginPageCommunicationLcz> SysLoginPageCommunicationLczs { get; set; } = new List<SysLoginPageCommunicationLcz>();

    public virtual ICollection<SysLoginPageLinkLcz> SysLoginPageLinkLczs { get; set; } = new List<SysLoginPageLinkLcz>();

    public virtual ICollection<SysLookupFolderLcz> SysLookupFolderLczs { get; set; } = new List<SysLookupFolderLcz>();

    public virtual ICollection<SysLookupLcz> SysLookupLczs { get; set; } = new List<SysLookupLcz>();

    public virtual ICollection<SysMacrosLcz> SysMacrosLczs { get; set; } = new List<SysMacrosLcz>();

    public virtual ICollection<SysMailServerLcz> SysMailServerLczs { get; set; } = new List<SysMailServerLcz>();

    public virtual ICollection<SysMailServerTypeLcz> SysMailServerTypeLczs { get; set; } = new List<SysMailServerTypeLcz>();

    public virtual ICollection<SysMailSyncPeriodLcz> SysMailSyncPeriodLczs { get; set; } = new List<SysMailSyncPeriodLcz>();

    public virtual ICollection<SysMainParamLcz> SysMainParamLczs { get; set; } = new List<SysMainParamLcz>();

    public virtual ICollection<SysMapServiceLcz> SysMapServiceLczs { get; set; } = new List<SysMapServiceLcz>();

    public virtual ICollection<SysMessageListenerLcz> SysMessageListenerLczs { get; set; } = new List<SysMessageListenerLcz>();

    public virtual ICollection<SysMessageNotifierLcz> SysMessageNotifierLczs { get; set; } = new List<SysMessageNotifierLcz>();

    public virtual ICollection<SysMessagePublisherLcz> SysMessagePublisherLczs { get; set; } = new List<SysMessagePublisherLcz>();

    public virtual ICollection<SysMessageTemplateTypeLcz> SysMessageTemplateTypeLczs { get; set; } = new List<SysMessageTemplateTypeLcz>();

    public virtual ICollection<SysMkpInstAppNewsFolderLcz> SysMkpInstAppNewsFolderLczs { get; set; } = new List<SysMkpInstAppNewsFolderLcz>();

    public virtual ICollection<SysMlconfidentValueMethodLcz> SysMlconfidentValueMethodLczs { get; set; } = new List<SysMlconfidentValueMethodLcz>();

    public virtual ICollection<SysMlerrorLcz> SysMlerrorLczs { get; set; } = new List<SysMlerrorLcz>();

    public virtual ICollection<SysMlmodelColumnLcz> SysMlmodelColumnLczs { get; set; } = new List<SysMlmodelColumnLcz>();

    public virtual ICollection<SysMlmodelColumnTypeLcz> SysMlmodelColumnTypeLczs { get; set; } = new List<SysMlmodelColumnTypeLcz>();

    public virtual ICollection<SysMlmodelFolderLcz> SysMlmodelFolderLczs { get; set; } = new List<SysMlmodelFolderLcz>();

    public virtual ICollection<SysMlmodelLcz> SysMlmodelLczs { get; set; } = new List<SysMlmodelLcz>();

    public virtual ICollection<SysMlmodelStateLcz> SysMlmodelStateLczs { get; set; } = new List<SysMlmodelStateLcz>();

    public virtual ICollection<SysMlproblemTypeLcz> SysMlproblemTypeLczs { get; set; } = new List<SysMlproblemTypeLcz>();

    public virtual ICollection<SysMltaskStartMethodLcz> SysMltaskStartMethodLczs { get; set; } = new List<SysMltaskStartMethodLcz>();

    public virtual ICollection<SysMobileApplicationModeLcz> SysMobileApplicationModeLczs { get; set; } = new List<SysMobileApplicationModeLcz>();

    public virtual ICollection<SysMobileWorkplaceLcz> SysMobileWorkplaceLczs { get; set; } = new List<SysMobileWorkplaceLcz>();

    public virtual ICollection<SysModuleActionLczOld> SysModuleActionLczOlds { get; set; } = new List<SysModuleActionLczOld>();

    public virtual ICollection<SysModuleActionLcz> SysModuleActionLczs { get; set; } = new List<SysModuleActionLcz>();

    public virtual ICollection<SysModuleActionTypeLcz> SysModuleActionTypeLczs { get; set; } = new List<SysModuleActionTypeLcz>();

    public virtual ICollection<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOlds { get; set; } = new List<SysModuleAnalyticsReportLczOld>();

    public virtual ICollection<SysModuleAnalyticsReportLcz> SysModuleAnalyticsReportLczs { get; set; } = new List<SysModuleAnalyticsReportLcz>();

    public virtual ICollection<SysModuleDetailLczOld> SysModuleDetailLczOlds { get; set; } = new List<SysModuleDetailLczOld>();

    public virtual ICollection<SysModuleDetailLcz> SysModuleDetailLczs { get; set; } = new List<SysModuleDetailLcz>();

    public virtual ICollection<SysModuleEditLczOld> SysModuleEditLczOlds { get; set; } = new List<SysModuleEditLczOld>();

    public virtual ICollection<SysModuleEditLcz> SysModuleEditLczs { get; set; } = new List<SysModuleEditLcz>();

    public virtual ICollection<SysModuleFolderLczOld> SysModuleFolderLczOlds { get; set; } = new List<SysModuleFolderLczOld>();

    public virtual ICollection<SysModuleFolderLcz> SysModuleFolderLczs { get; set; } = new List<SysModuleFolderLcz>();

    public virtual ICollection<SysModuleGridViewLcz> SysModuleGridViewLczs { get; set; } = new List<SysModuleGridViewLcz>();

    public virtual ICollection<SysModuleLczOld> SysModuleLczOlds { get; set; } = new List<SysModuleLczOld>();

    public virtual ICollection<SysModuleLcz> SysModuleLczs { get; set; } = new List<SysModuleLcz>();

    public virtual ICollection<SysModuleReportLczOld> SysModuleReportLczOlds { get; set; } = new List<SysModuleReportLczOld>();

    public virtual ICollection<SysModuleReportLcz> SysModuleReportLczs { get; set; } = new List<SysModuleReportLcz>();

    public virtual ICollection<SysModuleReportPackageLcz> SysModuleReportPackageLczs { get; set; } = new List<SysModuleReportPackageLcz>();

    public virtual ICollection<SysModuleReportTypeLcz> SysModuleReportTypeLczs { get; set; } = new List<SysModuleReportTypeLcz>();

    public virtual ICollection<SysMonthLcz> SysMonthLczs { get; set; } = new List<SysMonthLcz>();

    public virtual ICollection<SysMsgLibLcz> SysMsgLibLczs { get; set; } = new List<SysMsgLibLcz>();

    public virtual ICollection<SysMsgUserStateIconLcz> SysMsgUserStateIconLczs { get; set; } = new List<SysMsgUserStateIconLcz>();

    public virtual ICollection<SysMsgUserStateLcz> SysMsgUserStateLczs { get; set; } = new List<SysMsgUserStateLcz>();

    public virtual ICollection<SysMsgUserStateReasonLcz> SysMsgUserStateReasonLczs { get; set; } = new List<SysMsgUserStateReasonLcz>();

    public virtual ICollection<SysMultiDeleteDenyReasonLcz> SysMultiDeleteDenyReasonLczs { get; set; } = new List<SysMultiDeleteDenyReasonLcz>();

    public virtual ICollection<SysNotificationProviderLcz> SysNotificationProviderLczs { get; set; } = new List<SysNotificationProviderLcz>();

    public virtual ICollection<SysOauth20AppFolderLcz> SysOauth20AppFolderLczs { get; set; } = new List<SysOauth20AppFolderLcz>();

    public virtual ICollection<SysOmniChatActionLcz> SysOmniChatActionLczs { get; set; } = new List<SysOmniChatActionLcz>();

    public virtual ICollection<SysOmniChatFolderLcz> SysOmniChatFolderLczs { get; set; } = new List<SysOmniChatFolderLcz>();

    public virtual ICollection<SysOmnichannelChatStatusLcz> SysOmnichannelChatStatusLczs { get; set; } = new List<SysOmnichannelChatStatusLcz>();

    public virtual ICollection<SysOperationResultLcz> SysOperationResultLczs { get; set; } = new List<SysOperationResultLcz>();

    public virtual ICollection<SysOperationTypeLcz> SysOperationTypeLczs { get; set; } = new List<SysOperationTypeLcz>();

    public virtual ICollection<SysOperatorRoutingRulesLcz> SysOperatorRoutingRulesLczs { get; set; } = new List<SysOperatorRoutingRulesLcz>();

    public virtual ICollection<SysOperatorStateLcz> SysOperatorStateLczs { get; set; } = new List<SysOperatorStateLcz>();

    public virtual ICollection<SysOrderDirectionLcz> SysOrderDirectionLczs { get; set; } = new List<SysOrderDirectionLcz>();

    public virtual ICollection<SysOrgStructureUnitLcz> SysOrgStructureUnitLczs { get; set; } = new List<SysOrgStructureUnitLcz>();

    public virtual ICollection<SysPackageDataLcz> SysPackageDataLczs { get; set; } = new List<SysPackageDataLcz>();

    public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksums { get; set; } = new List<SysPackageResourceChecksum>();

    public virtual ICollection<SysPeriodLcz> SysPeriodLczs { get; set; } = new List<SysPeriodLcz>();

    public virtual ICollection<SysPeriodTypeLcz> SysPeriodTypeLczs { get; set; } = new List<SysPeriodTypeLcz>();

    public virtual ICollection<SysPortalSysModuleLcz> SysPortalSysModuleLczs { get; set; } = new List<SysPortalSysModuleLcz>();

    public virtual ICollection<SysProcessDisabledLcz> SysProcessDisabledLczs { get; set; } = new List<SysProcessDisabledLcz>();

    public virtual ICollection<SysProcessLogFolderLcz> SysProcessLogFolderLczs { get; set; } = new List<SysProcessLogFolderLcz>();

    public virtual ICollection<SysProcessSchemaTypeLcz> SysProcessSchemaTypeLczs { get; set; } = new List<SysProcessSchemaTypeLcz>();

    public virtual ICollection<SysProcessStatusLcz> SysProcessStatusLczs { get; set; } = new List<SysProcessStatusLcz>();

    public virtual ICollection<SysProcessUserTaskFolderLcz> SysProcessUserTaskFolderLczs { get; set; } = new List<SysProcessUserTaskFolderLcz>();

    public virtual ICollection<SysProductFolderLcz> SysProductFolderLczs { get; set; } = new List<SysProductFolderLcz>();

    public virtual ICollection<SysProductLcz> SysProductLczs { get; set; } = new List<SysProductLcz>();

    public virtual ICollection<SysProductSourceLcz> SysProductSourceLczs { get; set; } = new List<SysProductSourceLcz>();

    public virtual ICollection<SysProductTypeLcz> SysProductTypeLczs { get; set; } = new List<SysProductTypeLcz>();

    public virtual ICollection<SysProfileDatum> SysProfileData { get; set; } = new List<SysProfileDatum>();

    public virtual ICollection<SysPropositionResultLcz> SysPropositionResultLczs { get; set; } = new List<SysPropositionResultLcz>();

    public virtual ICollection<SysQuickAddMenuItemLcz> SysQuickAddMenuItemLczs { get; set; } = new List<SysQuickAddMenuItemLcz>();

    public virtual ICollection<SysQuickAddMenuSettingsLcz> SysQuickAddMenuSettingsLczs { get; set; } = new List<SysQuickAddMenuSettingsLcz>();

    public virtual ICollection<SysReasonForLeavingLcz> SysReasonForLeavingLczs { get; set; } = new List<SysReasonForLeavingLcz>();

    public virtual ICollection<SysReferrerNameLcz> SysReferrerNameLczs { get; set; } = new List<SysReferrerNameLcz>();

    public virtual ICollection<SysReferrerTypeLcz> SysReferrerTypeLczs { get; set; } = new List<SysReferrerTypeLcz>();

    public virtual ICollection<SysRegionLcz> SysRegionLczs { get; set; } = new List<SysRegionLcz>();

    public virtual ICollection<SysRegisterMethodLcz> SysRegisterMethodLczs { get; set; } = new List<SysRegisterMethodLcz>();

    public virtual ICollection<SysRelationConnectionTypeLcz> SysRelationConnectionTypeLczs { get; set; } = new List<SysRelationConnectionTypeLcz>();

    public virtual ICollection<SysRelationTypeLcz> SysRelationTypeLczs { get; set; } = new List<SysRelationTypeLcz>();

    public virtual ICollection<SysRelationTypePositionLcz> SysRelationTypePositionLczs { get; set; } = new List<SysRelationTypePositionLcz>();

    public virtual ICollection<SysRemindIntervalLcz> SysRemindIntervalLczs { get; set; } = new List<SysRemindIntervalLcz>();

    public virtual ICollection<SysRemindingSourceLcz> SysRemindingSourceLczs { get; set; } = new List<SysRemindingSourceLcz>();

    public virtual ICollection<SysReportFolderLcz> SysReportFolderLczs { get; set; } = new List<SysReportFolderLcz>();

    public virtual ICollection<SysReportResourcesLcz> SysReportResourcesLczs { get; set; } = new List<SysReportResourcesLcz>();

    public virtual ICollection<SysRuleRelationLcz> SysRuleRelationLczs { get; set; } = new List<SysRuleRelationLcz>();

    public virtual ICollection<SysRuleRelationSectionsLcz> SysRuleRelationSectionsLczs { get; set; } = new List<SysRuleRelationSectionsLcz>();

    public virtual ICollection<SysSchemaLcz> SysSchemaLczs { get; set; } = new List<SysSchemaLcz>();

    public virtual ICollection<SysSettingsFolderLcz> SysSettingsFolderLczs { get; set; } = new List<SysSettingsFolderLcz>();

    public virtual ICollection<SysSettingsLcz> SysSettingsLczs { get; set; } = new List<SysSettingsLcz>();

    public virtual ICollection<SysShowNamesByLcz> SysShowNamesByLczs { get; set; } = new List<SysShowNamesByLcz>();

    public virtual ICollection<SysSocialAccountLcz> SysSocialAccountLczs { get; set; } = new List<SysSocialAccountLcz>();

    public virtual ICollection<SysSocialChannelFolderLcz> SysSocialChannelFolderLczs { get; set; } = new List<SysSocialChannelFolderLcz>();

    public virtual ICollection<SysSocialChannelLcz> SysSocialChannelLczs { get; set; } = new List<SysSocialChannelLcz>();

    public virtual ICollection<SysStartTimerTypeLcz> SysStartTimerTypeLczs { get; set; } = new List<SysStartTimerTypeLcz>();

    public virtual ICollection<SysStoredReportLcz> SysStoredReportLczs { get; set; } = new List<SysStoredReportLcz>();

    public virtual ICollection<SysStoredReportResourcesLcz> SysStoredReportResourcesLczs { get; set; } = new List<SysStoredReportResourcesLcz>();

    public virtual ICollection<SysStoringObjectStateLcz> SysStoringObjectStateLczs { get; set; } = new List<SysStoringObjectStateLcz>();

    public virtual ICollection<SysSubjectResultLcz> SysSubjectResultLczs { get; set; } = new List<SysSubjectResultLcz>();

    public virtual ICollection<SysSyncErrorHandlerLcz> SysSyncErrorHandlerLczs { get; set; } = new List<SysSyncErrorHandlerLcz>();

    public virtual ICollection<SysSyncErrorMessageLcz> SysSyncErrorMessageLczs { get; set; } = new List<SysSyncErrorMessageLcz>();

    public virtual ICollection<SysSyncProcessStateLcz> SysSyncProcessStateLczs { get; set; } = new List<SysSyncProcessStateLcz>();

    public virtual ICollection<SysTagTypeLcz> SysTagTypeLczs { get; set; } = new List<SysTagTypeLcz>();

    public virtual ICollection<SysTaxLcz> SysTaxLczs { get; set; } = new List<SysTaxLcz>();

    public virtual ICollection<SysTerritoryLcz> SysTerritoryLczs { get; set; } = new List<SysTerritoryLcz>();

    public virtual ICollection<SysTimeUnitLcz> SysTimeUnitLczs { get; set; } = new List<SysTimeUnitLcz>();

    public virtual ICollection<SysTimeZoneLcz> SysTimeZoneLczs { get; set; } = new List<SysTimeZoneLcz>();

    public virtual ICollection<SysTimelineTileSettingLcz> SysTimelineTileSettingLczs { get; set; } = new List<SysTimelineTileSettingLcz>();

    public virtual ICollection<SysTouchActionTypeLcz> SysTouchActionTypeLczs { get; set; } = new List<SysTouchActionTypeLcz>();

    public virtual ICollection<SysTouchDeviceLcz> SysTouchDeviceLczs { get; set; } = new List<SysTouchDeviceLcz>();

    public virtual ICollection<SysTouchEventLogLcz> SysTouchEventLogLczs { get; set; } = new List<SysTouchEventLogLcz>();

    public virtual ICollection<SysTouchEventTrackingLcz> SysTouchEventTrackingLczs { get; set; } = new List<SysTouchEventTrackingLcz>();

    public virtual ICollection<SysTouchPlatformLcz> SysTouchPlatformLczs { get; set; } = new List<SysTouchPlatformLcz>();

    public virtual ICollection<SysTranslationFolderLcz> SysTranslationFolderLczs { get; set; } = new List<SysTranslationFolderLcz>();

    public virtual ICollection<SysUielementVisibilityLcz> SysUielementVisibilityLczs { get; set; } = new List<SysUielementVisibilityLcz>();

    public virtual ICollection<SysUnitForCalculationLcz> SysUnitForCalculationLczs { get; set; } = new List<SysUnitForCalculationLcz>();

    public virtual ICollection<SysUnitLcz> SysUnitLczs { get; set; } = new List<SysUnitLcz>();

    public virtual ICollection<SysVideoHelpLcz> SysVideoHelpLczs { get; set; } = new List<SysVideoHelpLcz>();

    public virtual ICollection<SysVisaStatusLcz> SysVisaStatusLczs { get; set; } = new List<SysVisaStatusLcz>();

    public virtual ICollection<SysVwProcessLibFolderLcz> SysVwProcessLibFolderLczs { get; set; } = new List<SysVwProcessLibFolderLcz>();

    public virtual ICollection<SysVwSysDcmLibFolderLcz> SysVwSysDcmLibFolderLczs { get; set; } = new List<SysVwSysDcmLibFolderLcz>();

    public virtual ICollection<SysWebFormContactIdentifierLcz> SysWebFormContactIdentifierLczs { get; set; } = new List<SysWebFormContactIdentifierLcz>();

    public virtual ICollection<SysWebPageLcz> SysWebPageLczs { get; set; } = new List<SysWebPageLcz>();

    public virtual ICollection<SysWebServiceLcz> SysWebServiceLczs { get; set; } = new List<SysWebServiceLcz>();

    public virtual ICollection<SysWebServiceV2folderLcz> SysWebServiceV2folderLczs { get; set; } = new List<SysWebServiceV2folderLcz>();

    public virtual ICollection<SysWidgetDashboardLcz> SysWidgetDashboardLczs { get; set; } = new List<SysWidgetDashboardLcz>();

    public virtual ICollection<SysWorkplaceLcz> SysWorkplaceLczs { get; set; } = new List<SysWorkplaceLcz>();

    public virtual ICollection<SysWorkplaceTypeLcz> SysWorkplaceTypeLczs { get; set; } = new List<SysWorkplaceTypeLcz>();

    public virtual ICollection<SysWsysAccountLcz> SysWsysAccountLczs { get; set; } = new List<SysWsysAccountLcz>();

    public virtual ICollection<SysWsysAccountRoleLcz> SysWsysAccountRoleLczs { get; set; } = new List<SysWsysAccountRoleLcz>();
}
