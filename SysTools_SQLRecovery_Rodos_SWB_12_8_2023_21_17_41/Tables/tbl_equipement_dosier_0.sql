CREATE TABLE [dbo].[tbl_equipement_dosier] ([id] [bigint] NOT NULL IDENTITY(203,1) ,[Silo] [bigint],[Fein] [float],[Nachlauf] [float],[Tol_Plus] [float],[Tol_Minus] [float],[AH_Impuse] [int],[AH_Pause] [int],[equipement_id] [bigint],[lager_id] [bigint] NOT NULL,[Dreh_Grob] [int],[Dreh_Fein] [int],[OPC_Silo] [varchar](50) NOT NULL,[OPC_Fein] [varchar](50) NOT NULL,[OPC_Nachlauf] [varchar](50) NOT NULL,[OPC_Tol_Plus] [varchar](50) NOT NULL,[OPC_Tol_Minus] [varchar](50) NOT NULL,[OPC_AH_Impuse] [varchar](50) NOT NULL,[OPC_AH_Pause] [varchar](50) NOT NULL,[OPC_Dreh_Grob] [varchar](50) NOT NULL,[OPC_Dreh_Fein] [varchar](50) NOT NULL,[OPC_SPS] [varchar](50) NOT NULL)

go