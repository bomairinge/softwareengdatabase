CREATE TABLE [dbo].[Patient] (
    [Patient_ID] INT          NOT NULL,
    [First_Name] VARCHAR (50) NOT NULL,
    [Last_Name]  VARCHAR (50) NOT NULL,
    [Pulse]      DECIMAL (18) NOT NULL,
    [Breathing]  DECIMAL (18) NOT NULL,
    [Blood]      DECIMAL (18) NOT NULL,
    [Temp]       DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Patient_ID] ASC)
);

