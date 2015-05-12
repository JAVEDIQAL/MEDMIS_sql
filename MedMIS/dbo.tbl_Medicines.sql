CREATE TABLE [dbo].[tbl_Medicines] (
    [Id]           INT        IDENTITY (1, 1) NOT NULL,
    [Invoice_No]   INT        NULL,
    [Invoice_Date] DATE       NULL,
    [Med_Name]     VARCHAR(50) NULL,
    [Comp_Name]    VARCHAR(50) NULL,
    [Manf_Date]    DATE       NULL,
    [Exp_Date]     DATE       NULL,
    [Qty]          INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

