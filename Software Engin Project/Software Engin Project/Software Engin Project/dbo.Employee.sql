CREATE TABLE [dbo].[Employee] (
    [Employee_ID]   INT        NOT NULL,
    [Login_ID]      INT        NOT NULL,
    [First_Name]    VARCHAR(50) NOT NULL,
    [Last Name]     VARCHAR(50) NOT NULL,
    [Admin]         BIT        NOT NULL,
    [Email_address] VARCHAR(50) NOT NULL,
    [Phone_Number]  CHAR(11)        NOT NULL,
    [Username]      VARCHAR(50) NOT NULL,
    [Password]      VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Employee_ID] ASC),
    CONSTRAINT [Employee to Login Data] FOREIGN KEY ([Login_ID]) REFERENCES [dbo].[Login_data] ([Login_ID])
);

