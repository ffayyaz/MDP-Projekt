DROP TABLE TZ_MATERIALLISTE
go


DROP TABLE TR_MATERIAL
go


DROP TABLE TZ_ARBEITLISTE
go


DROP TABLE T_REPARATUR
go


DROP TABLE T_FAHRZEUG
go


DROP TABLE TZ_FAHRZEUGTYP
go


DROP TABLE TR_FAHRZEUGMARKE
go


DROP TABLE TR_FAHRZEUGART
go


DROP TABLE T_NUTZER
go


DROP TABLE TR_ARBEIT
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
	FZG_FZT_ID  int  NULL 
)
go


ALTER TABLE T_FAHRZEUG
	ADD CONSTRAINT  XPKT_FAHRZEUG PRIMARY KEY   NONCLUSTERED (FZG_ID  ASC)
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


CREATE TABLE T_REPARATUR
(
	REP_ID  int  IDENTITY (1,1) ,
	REP_DISPONR  nvarchar(50)  NULL ,
	REP_EINGANG  datetime  NULL ,
	REP_AUSGANG  datetime  NULL ,
	REP_RECHNUNGSNR  int  NULL ,
	REP_FAHRZEUGKM  int  NULL ,
	REP_FZG_ID  int  NULL 
)
go


ALTER TABLE T_REPARATUR
	ADD CONSTRAINT  XPKT_REPARATUR PRIMARY KEY   NONCLUSTERED (REP_ID  ASC)
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


CREATE TABLE TR_FAHRZEUGMARKE
(
	FZM_ID  int  IDENTITY (1,1) ,
	FZM_BEZEICHNUNG  nvarchar(50)  NOT NULL 
)
go


ALTER TABLE TR_FAHRZEUGMARKE
	ADD CONSTRAINT  XPKTR_FAHRZEUGMARKE PRIMARY KEY   NONCLUSTERED (FZM_ID  ASC)
go


CREATE TABLE TR_MATERIAL
(
	MAT_ID  int  IDENTITY (1,1) ,
	MAT_BEZEICHNUNG  nvarchar(50)  NULL ,
	MAT_PREIS  decimal(12, 2)  NULL ,
	MAT_MARGE  decimal(12,2)  NULL 
)
go


ALTER TABLE TR_MATERIAL
	ADD CONSTRAINT  XPKTR_MATERIAL PRIMARY KEY   NONCLUSTERED (MAT_ID  ASC)
go


CREATE TABLE TZ_ARBEITLISTE
(
	ABL_ID  int  IDENTITY (1,1) ,
	ABL_MENGE  decimal(12,2)  NULL ,
	ABL_ARB_ID  int  NULL ,
	ABL_REP_ID  int  NULL 
)
go


ALTER TABLE TZ_ARBEITLISTE
	ADD CONSTRAINT  XPKTZ_ARBEITLISTE PRIMARY KEY   NONCLUSTERED (ABL_ID  ASC)
go


CREATE TABLE TZ_FAHRZEUGTYP
(
	FZT_ID  int  IDENTITY (1,1) ,
	FZT_BEZEICHNUNG  nvarchar(50)  NULL ,
	FZT_FZM_ID  int  NULL 
)
go


ALTER TABLE TZ_FAHRZEUGTYP
	ADD CONSTRAINT  XPKTZ_FAHRZEUGTYP PRIMARY KEY   NONCLUSTERED (FZT_ID  ASC)
go


CREATE TABLE TZ_MATERIALLISTE
(
	MTL_ID  int  IDENTITY (1,1) ,
	MTL_MENGE  decimal(12,2)  NULL ,
	MTL_MAT_ID  int  NULL ,
	MTL_REP_ID  int  NULL 
)
go


ALTER TABLE TZ_MATERIALLISTE
	ADD CONSTRAINT  XPKTZ_MATERIALLISTE PRIMARY KEY   NONCLUSTERED (MTL_ID  ASC)
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
	ADD CONSTRAINT  FK_FZT_FZG FOREIGN KEY (FZG_FZT_ID) REFERENCES TZ_FAHRZEUGTYP(FZT_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE T_REPARATUR
	ADD CONSTRAINT  FK_FZG_REP FOREIGN KEY (REP_FZG_ID) REFERENCES T_FAHRZEUG(FZG_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE TZ_ARBEITLISTE
	ADD CONSTRAINT  FK_ARB_ABL FOREIGN KEY (ABL_ARB_ID) REFERENCES TR_ARBEIT(ARB_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE TZ_ARBEITLISTE
	ADD CONSTRAINT  FK_REP_ABL FOREIGN KEY (ABL_REP_ID) REFERENCES T_REPARATUR(REP_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE TZ_FAHRZEUGTYP
	ADD CONSTRAINT  FK_FZM_FZT FOREIGN KEY (FZT_FZM_ID) REFERENCES TR_FAHRZEUGMARKE(FZM_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE TZ_MATERIALLISTE
	ADD CONSTRAINT  FK_MAT_MTL FOREIGN KEY (MTL_MAT_ID) REFERENCES TR_MATERIAL(MAT_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE TZ_MATERIALLISTE
	ADD CONSTRAINT  FK_REP_MTL FOREIGN KEY (MTL_REP_ID) REFERENCES T_REPARATUR(REP_ID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


-- Beispiele für Fahrzeugarten
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Roller', 'ROL')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Mofa', 'MOF')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Velo', 'VEL')
Insert into TR_FAHRZEUGART (FZA_BEZEICHNUNG, FZA_KEY) VALUES ('Anhänger', 'ANH')

-- Beispiele für Fahrzeugtypen
Insert into TR_FAHRZEUGMARKE (FZM_BEZEICHNUNG) VALUES ('Piaggio')
Insert into TR_FAHRZEUGMARKE (FZM_BEZEICHNUNG) VALUES ('Vespa')

Insert into T_NUTZER (NUT_NAME, NUT_ORT, NUT_PLZ) VALUES ('Poststelle', 'Cham', 6330)
Insert into T_NUTZER (NUT_NAME, NUT_ORT, NUT_PLZ) VALUES ('Poststelle', 'Zug', 6300)

-- Beispiele für Fahrzeugmarken
Insert into TZ_FAHRZEUGTYP (FZT_BEZEICHNUNG, FZT_FZM_ID) VALUES ('Liberty', (SELECT FZM_ID from TR_FAHRZEUGMARKE where FZM_BEZEICHNUNG = 'Piaggio'))
Insert into TZ_FAHRZEUGTYP (FZT_BEZEICHNUNG, FZT_FZM_ID) VALUES ('Sport Edition', (SELECT FZM_ID from TR_FAHRZEUGMARKE where FZM_BEZEICHNUNG = 'Piaggio'))
Insert into TZ_FAHRZEUGTYP (FZT_BEZEICHNUNG, FZT_FZM_ID) VALUES ('FX 900', (SELECT FZM_ID from TR_FAHRZEUGMARKE where FZM_BEZEICHNUNG = 'Vespa'))

-- Beispiele für Fahrzeuge
Insert into T_FAHRZEUG 
	(FZG_SCHILDNR, FZG_FZA_ID, FZG_FZT_ID, FZG_NUT_ID) 
VALUES
	('ZG 123134', (SELECT FZA_ID from TR_FAHRZEUGART where FZA_KEY = 'ROL'), 
	(SELECT top 1 FZT_ID from TZ_FAHRZEUGTYP where FZT_BEZEICHNUNG = 'Liberty'),
	(SELECT top 1 NUT_ID from T_NUTZER where NUT_ORT = 'Cham'))
	
Insert into T_FAHRZEUG 
	(FZG_SCHILDNR, FZG_FZA_ID, FZG_FZT_ID, FZG_NUT_ID) 
VALUES
	('ZG 4324124', (SELECT FZA_ID from TR_FAHRZEUGART where FZA_KEY = 'MOF'), 
	(SELECT top 1 FZT_ID from TZ_FAHRZEUGTYP where FZT_BEZEICHNUNG = 'FX 900'),
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
