﻿CREATE TABLE [dbo].[CPU_60MIN] (
    [InstanceID]         INT           NOT NULL,
    [EventTime]          DATETIME2 (3) NOT NULL,
    [SumSQLProcessCPU]   INT           NOT NULL,
    [SumSystemIdleCPU]   INT           NOT NULL,
    [SampleCount]        SMALLINT      NOT NULL,
    [MaxSQLProcessCPU]   TINYINT       NOT NULL,
    [MaxOtherProcessCPU] TINYINT       NOT NULL,
    [MaxTotalCPU]        TINYINT       NOT NULL,
    [SumOtherCPU]        AS            ([SampleCount]*(100)-([SumSQLProcessCPU]+[SumSystemIdleCPU])),
    [SumTotalCPU]        AS            ([SampleCount]*(100)-[SumSystemIdleCPU]),
    CONSTRAINT [PK_CPU_60MIN] PRIMARY KEY CLUSTERED ([InstanceID] ASC, [EventTime] ASC) WITH (DATA_COMPRESSION = PAGE)
);


GO
CREATE COLUMNSTORE INDEX [CI_CPU_60MIN]
    ON [dbo].[CPU_60MIN]([InstanceID], [EventTime], [SumSQLProcessCPU], [SumSystemIdleCPU], [SampleCount], [MaxSQLProcessCPU], [MaxOtherProcessCPU], [MaxTotalCPU]);
