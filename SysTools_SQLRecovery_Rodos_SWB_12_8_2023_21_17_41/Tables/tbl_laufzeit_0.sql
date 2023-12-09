CREATE TABLE [dbo].[tbl_laufzeit] ([id] [bigint] NOT NULL IDENTITY(3,1) ,[fid_auftrag] [bigint],[Sap_auf] [varchar](50),[auftragsnr] [varchar](50),[fid_stoerung] [bigint],[startzeit] [datetime],[endezeit] [datetime],[dauer] [varchar](50),[dauersek] [bigint],[stoerung] [varchar](50),[ersteller] [varchar](50))

go
