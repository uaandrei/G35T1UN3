CREATE TABLE Firme (
  ID                  int IDENTITY NOT NULL, 
  Nume                varchar(50) NOT NULL UNIQUE, 
  CUI                 varchar(50) NOT NULL UNIQUE, 
  Numar_inmatriculare varchar(50) NOT NULL UNIQUE, 
  IBAN                varchar(50) NOT NULL UNIQUE, 
  Localitate          varchar(50) NOT NULL, 
  Judet               varchar(50) NOT NULL, 
  Adresa              varchar(255) NOT NULL, 
  Telefon             varchar(50) NOT NULL, 
  Persoana_contact    varchar(50) NOT NULL, 
  Data_infiintarii    datetime NULL, 
  ID_Banca            int NOT NULL, 
  ID_Delegat            int NOT NULL
  PRIMARY KEY (ID));
CREATE TABLE Banci (
  ID                       int IDENTITY NOT NULL, 
  Nume                     varchar(50) NOT NULL UNIQUE, 
  Adresa                   varchar(255) NOT NULL, 
  Cod_identificare_fiscala varchar(50) NOT NULL UNIQUE, 
  Nr_orc                   varchar(50) NOT NULL UNIQUE, 
  PRIMARY KEY (ID));
CREATE TABLE Plati (
  ID           int IDENTITY NOT NULL, 
  Serie        varchar(50) NOT NULL UNIQUE, 
  Nr           int NOT NULL, 
  Data         datetime NOT NULL, 
  Tip_plata    varchar(50) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Stoc (
  ID                 int IDENTITY NOT NULL, 
  ID_produs          int NOT NULL, 
  Cantitate          decimal(19, 2) NOT NULL, 
  Id_factura_intrare int NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Produse (
  ID   int IDENTITY NOT NULL, 
  Nume varchar(50) NOT NULL UNIQUE, 
  Pret decimal(19, 2) NOT NULL, 
  Rata_TVA  decimal(19, 2) NOT NULL, 
  UM   varchar(10) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Facturi (
  ID         int IDENTITY NOT NULL, 
  Serie      varchar(50) NOT NULL UNIQUE, 
  Numar      varchar(50) NOT NULL UNIQUE, 
  Data       datetime NULL, 
  Tip        varchar(10) NOT NULL, 
  ID_firma   int NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Delegati (
  ID    int IDENTITY NOT NULL, 
  CNP   varchar(50) NOT NULL UNIQUE, 
  Serie varchar(50) NOT NULL UNIQUE, 
  Nume  varchar(50) NOT NULL, 
  PRIMARY KEY (ID));
CREATE TABLE Facturi_Plati (
  ID_factura int NOT NULL, 
  ID_plata    int NOT NULL, 
  Suma        decimal(19, 2) NOT NULL, 
  PRIMARY KEY (ID_factura, ID_plata));
CREATE TABLE Facturi_Produse_Stoc (
  ID_factura int NOT NULL, 
  ID_produs  int NOT NULL, 
  ID_stoc    int NOT NULL, 
  Pret       decimal(19, 2) NOT NULL, 
  Cantitate  decimal(19, 2) NOT NULL, 
  PRIMARY KEY (ID_factura, ID_produs));
ALTER TABLE Facturi_Plati ADD CONSTRAINT FKFacturi_Pl438907 FOREIGN KEY (ID_factura) REFERENCES Facturi (ID);
ALTER TABLE Facturi_Plati ADD CONSTRAINT FKFacturi_Pl732278 FOREIGN KEY (ID_plata) REFERENCES Plati (ID);
ALTER TABLE Stoc ADD CONSTRAINT FKStoc713763 FOREIGN KEY (ID_produs) REFERENCES Produse (ID);
ALTER TABLE Stoc ADD CONSTRAINT FKStoc428432 FOREIGN KEY (Id_factura_intrare) REFERENCES Facturi (ID);
ALTER TABLE Facturi_Produse_Stoc ADD CONSTRAINT FKFacturi_Pr180739 FOREIGN KEY (ID_factura) REFERENCES Facturi (ID);
ALTER TABLE Facturi_Produse_Stoc ADD CONSTRAINT FKFacturi_Pr202928 FOREIGN KEY (ID_produs) REFERENCES Produse (ID);
ALTER TABLE Facturi_Produse_Stoc ADD CONSTRAINT FKFacturi_Pl010101 FOREIGN KEY (ID_stoc) REFERENCES Stoc (ID);
ALTER TABLE Firme ADD CONSTRAINT FKFirme406472 FOREIGN KEY (ID_Banca) REFERENCES Banci (ID);
ALTER TABLE Firme ADD CONSTRAINT FKFirme18057 FOREIGN KEY (ID_Delegat) REFERENCES Delegati (ID);
ALTER TABLE Facturi ADD CONSTRAINT FKFacturi721543 FOREIGN KEY (ID_firma) REFERENCES Firme (ID);
CREATE UNIQUE INDEX Firme_ID 
  ON Firme (ID);
CREATE UNIQUE INDEX Banci_ID 
  ON Banci (ID);
CREATE UNIQUE INDEX Plati_ID 
  ON Plati (ID);
CREATE UNIQUE INDEX Stoc_ID 
  ON Stoc (ID);
CREATE UNIQUE INDEX Produse_ID 
  ON Produse (ID);
CREATE UNIQUE INDEX Facturi_ID 
  ON Facturi (ID);
CREATE UNIQUE INDEX Delegati_ID 
  ON Delegati (ID);
