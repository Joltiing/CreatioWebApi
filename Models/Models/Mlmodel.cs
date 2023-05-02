using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Mlmodel
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int TrainFrequency { get; set; }

    public DateTime? TrainedOn { get; set; }

    public DateTime? TriedToTrainOn { get; set; }

    public string MetaData { get; set; } = null!;

    public string MetaDataLcz { get; set; } = null!;

    public string TrainingSetQuery { get; set; } = null!;

    public Guid? RootSchemaUid { get; set; }

    public Guid? StateId { get; set; }

    public decimal InstanceMetric { get; set; }

    public decimal MetricThreshold { get; set; }

    public bool PredictionEnabled { get; set; }

    public Guid? TrainSessionId { get; set; }

    public Guid? MlproblemTypeId { get; set; }

    public string ModelInstanceUid { get; set; } = null!;

    public string LastError { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? BatchPredictedOn { get; set; }

    public string BatchPredictionQuery { get; set; } = null!;

    public Guid? TargetColumnUid { get; set; }

    public Guid? BatchPredictionStartMethodId { get; set; }

    public int TrainingMinimumRecordsCount { get; set; }

    public byte[]? TrainingFilterData { get; set; }

    public Guid? PredictedResultColumnUid { get; set; }

    public byte[]? TrainingOutputFilterData { get; set; }

    public byte[]? BatchPredictionFilterData { get; set; }

    public int TrainingMaxRecordsCount { get; set; }

    public Guid? MlconfidentValueMethodId { get; set; }

    public decimal ConfidentValueLowEdge { get; set; }

    public string CfuserColumnPath { get; set; } = null!;

    public string CfitemColumnPath { get; set; } = null!;

    public string CfinteractionValueColumnPath { get; set; } = null!;

    public Guid? ListPredictResultSchemaUid { get; set; }

    public string ListPredictResultSubjectColumn { get; set; } = null!;

    public string ListPredictResultObjectColumn { get; set; } = null!;

    public string ListPredictResultValueColumn { get; set; } = null!;

    public string ListPredictResultModelColumn { get; set; } = null!;

    public string ListPredictResultDateColumn { get; set; } = null!;

    public string FactorsCounts { get; set; } = null!;

    public string RegularizationValues { get; set; } = null!;

    public Guid? PredictionSchemaUid { get; set; }

    public decimal LowerScoreThreshold { get; set; }

    public Guid? LastTrainingErrorId { get; set; }

    public virtual MltaskStartMethod? BatchPredictionStartMethod { get; set; }

    public virtual Mlerror? LastTrainingError { get; set; }

    public virtual ICollection<MlclassificationResult> MlclassificationResults { get; set; } = new List<MlclassificationResult>();

    public virtual MlconfidentValueMethod? MlconfidentValueMethod { get; set; }

    public virtual ICollection<MlmodelColumn> MlmodelColumns { get; set; } = new List<MlmodelColumn>();

    public virtual ICollection<MlmodelFile> MlmodelFiles { get; set; } = new List<MlmodelFile>();

    public virtual ICollection<MlmodelInFolder> MlmodelInFolders { get; set; } = new List<MlmodelInFolder>();

    public virtual ICollection<MlmodelInTag> MlmodelInTags { get; set; } = new List<MlmodelInTag>();

    public virtual ICollection<Mlprediction> Mlpredictions { get; set; } = new List<Mlprediction>();

    public virtual MlproblemType? MlproblemType { get; set; }

    public virtual ICollection<MltrainSession> MltrainSessions { get; set; } = new List<MltrainSession>();

    public virtual MlmodelState? State { get; set; }

    public virtual ICollection<SysMlmodelLcz> SysMlmodelLczs { get; set; } = new List<SysMlmodelLcz>();
}
