DROP TABLE T_FAHRZEUG
go

DROP TABLE TR_ARBEIT
go

DROP TABLE TR_MATERIAL
go


DROP TABLE TZ_FAHRZEUGMARKE
go


DROP TABLE TR_FAHRZEUGTYP
go


DROP TABLE TR_FAHRZEUGART
go


DROP TABLE T_NUTZER
go

CREATE TABLE T_FAHRZEUG
(
	FZG_ID  int  IDENTITY (1,1) ,
	FZG_SCHILDNR  nvarchar(50)  NULL ,
	FZG_RAHMENNR  nvarchar(50)  NULL ,
	FZG_STAMMNR  nvarchar(50)  NULL ,
	FZG_ERSTEINVERKEHR  datetime  NULL ,
	FZG_FAHRZEUGNR  nvarchar(50)  NULL ,
	FZG_NUT_ID  int  NULL ,
	FZG_FZA_ID  int  NULL ,
	FZG_FZM_ID  int  NULL 
)
go


ALTER TABLE T_FAHRZEUG
	ADD CONSTRAINT  XPKT_FAHRZEUG PRIMARY KEY   NONCLUSTERED (FZG_ID  ASC)
go

CREATE TABLE TR_ARBEIT
(
	ARB_ID  int  IDENTITY (1,1) ,
	ARB_BEZEICHNUNG  nvarchar(50)  NULL ,
	ARB_PREIS  decimal(12,2)  NULL 
)
go


ALTER TABLE TR_ARBEIT
	ADD CONSTRAINT  XPKTR_ARBEIT PRIMARY KEY   NONCLUSTERED (ARB_ID  ASC)
go


CREATE TABLE TR_MATERIAL
(
	MAT_ID  int  IDENTITY (1,1) ,
	MAT_BEZEICHNUNG  nvarchar(50)  NULL ,
	MAT_PREIS  decimal(12,2)  NULL ,
	MAT_MARGE  decimal(12,2)  NULL 
)
go


ALTER TABLE TR_MATERIAL
	ADD CONSTRAINT  XPKTR_MATERIAL PRIMARY KEY   NONCLUSTERED (MAT_ID  ASC)
go


CREATE TABLE T_NUTZER
(
	NUT_ID  int  IDENTITY (1,1) ,
	NUT_NAME  nvarchar(50)  NOT NULL ,
	NUT_PLZ  int  NULL ,
	NUT_ORT  nvarchar(50)  NULL 
)
go


ALTER TABLE T_NUTZER
	ADD CONSTRAINT  XPKT_NUTZER PRIMARY KEY   NONCLUSTERED (NUT_ID  ASC)
go


CREATE TABLE TR_FAHRZEUGART
(
	FZA_ID  int  IDENTITY (1,1) ,
	FZA_BEZEICHNUNG  nvarchar(50)  NOT NULL ,
	FZA_KEY  char(3)  NOT NULL 
)
go


ALTER TABLE TR_FAHRZEUGART
	ADD CONSTRAINT  XPKTR_FAHRZEUGART PRIMARY KEY   NONCLUSTERED (FZA_ID  ASC)
go


CREATE TABLE TR_FAHRZEUGTYP
(
	FZT_ID  int  IDENTITY (1,1) ,
	FZT_BEZEICHNUNG  nvarchar(50)  NOT NULL 
)
go


ALTER TABLE TR_FAHRZEUGTYP
	ADD CONSTRAINT  XPKTR_FAHRZEUGTYP PRIMARY KEY   NONCLUSTERED (FZT_ID  ASC)
go


CREATE TABLE TZ_FAHRZEUGMARKE
(
	FZM_ID  int  IDENTITY (1,1) ,
	FZM_BEZEICHNUNG  nvarchar(50)  NULL ,
	FZM_FZT_ID  int  NULL 
)
go


ALTER TABLE TZ_FAHRZEUGMARKE
	ADD CONSTRAINT  XPKTZ_FAHRZEUGMARKE PRIMARY KEY   NONCLUSTERED (FZM_ID  ASC)
go



ALTER TABLE T_FAHRZEUG
	ADD CONSTRAINT  FK_NUT_FZG FOREIGN KEY (FZG_NUT_ID) REFERENCES T_NUTZER(NUT_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE T_FAHRZEUG
	ADD CONSTRAINT  FK_FZA_FZG FOREIGN KEY (FZG_FZA_ID) REFERENCES TR_FAHRZEUGART(FZA_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE T_FAHRZEUG
	ADD CONSTRAINT  FK_FZM_FZG FOREIGN KEY (FZG_FZM_ID) REFERENCES TZ_FAHRZEUGMARKE(FZM_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE TZ_FAHRZEUGMARKE
	ADD CONSTRAINT  FK_FZT_FMT FOREIGN KEY (FZM_FZT_ID) REFERENCES TR_FAHRZEUGTYP(FZT_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

-- Beispiele für Fahrzeugarten
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Roller', 'ROL')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Mofa', 'MOF')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Velo', 'VEL')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Anhänger', 'ANH')

-- Beispiele für Fahrzeugtypen
Insert into TR_FAHRZEUGTYP (FZT_BEZEICHNUNG) VALUES ('Liberty')
Insert into TR_FAHRZEUGTYP (FZT_BEZEICHNUNG) VALUES ('Sport Edition')

Insert into T_NUTZER (NUT_NAME, NUT_ORT, NUT_PLZ) VALUES ('Poststelle', 'Cham', 6330)
Insert into T_NUTZER (NUT_NAME, NUT_ORT, NUT_PLZ) VALUES ('Poststelle', 'Zug', 6300)

-- Beispiele für Fahrzeugmarken
Insert into TZ_FAHRZEUGMARKE (FZM_BEZEICHNUNG, FZM_FZT_ID) VALUES ('Piaggio', (SELECT FZT_ID from TR_FAHRZEUGTYP where FZT_BEZEICHNUNG = 'Liberty'))
Insert into TZ_FAHRZEUGMARKE (FZM_BEZEICHNUNG, FZM_FZT_ID) VALUES ('Piaggio', (SELECT FZT_ID from TR_FAHRZEUGTYP where FZT_BEZEICHNUNG = 'Sport Edition'))
Insert into TZ_FAHRZEUGMARKE (FZM_BEZEICHNUNG, FZM_FZT_ID) VALUES ('Vespa', (SELECT FZT_ID from TR_FAHRZEUGTYP where FZT_BEZEICHNUNG = 'Sport Edition'))

-- Beispiele für Fahrzeuge
Insert into T_FAHRZEUG 
	(FZG_SCHILDNR, FZG_FZA_ID, FZG_FZM_ID, FZG_NUT_ID) 
VALUES
	('ZG 123134', (SELECT FZA_ID from TR_FAHRZEUGART where FZA_KEY = 'ROL'), 
	(SELECT top 1 FZM_ID from TZ_FAHRZEUGMARKE where FZM_BEZEICHNUNG = 'Piaggio'),
	(SELECT top 1 NUT_ID from T_NUTZER where NUT_ORT = 'Cham'))
	
Insert into T_FAHRZEUG 
	(FZG_SCHILDNR, FZG_FZA_ID, FZG_FZM_ID, FZG_NUT_ID) 
VALUES
	('ZG 4324124', (SELECT FZA_ID from TR_FAHRZEUGART where FZA_KEY = 'MOF'), 
	(SELECT top 1 FZM_ID from TZ_FAHRZEUGMARKE where FZM_BEZEICHNUNG = 'Vespa'),
	(SELECT top 1 NUT_ID from T_NUTZER where NUT_ORT = 'Zug'))

-- Beispiele für Arbeit
Insert into TR_ARBEIT
	(ARB_BEZEICHNUNG, ARB_PREIS)
VALUES
	('Pneu Wechsel', 25.50)

Insert into TR_ARBEIT
	(ARB_BEZEICHNUNG, ARB_PREIS)
VALUES
	('Service', 42.90)
	
-- Beispiele für Material
Insert into TR_MATERIAL
	(MAT_BEZEICHNUNG, MAT_PREIS, MAT_MARGE)
VALUES 
	('Pneu', 12.90, 3.50)

Insert into TR_MATERIAL
	(MAT_BEZEICHNUNG, MAT_PREIS, MAT_MARGE)
VALUES 
	('Licht', 32.90, 15.00)

