delete from setari 
delete from PozitiiFacturiIesire
delete from Stoc
delete from PozitiiFacturiIntrare
delete from Produse
delete from FacturiIesire
delete from FacturiIntrare
delete from Firme
delete from Delegati
delete from Banci
delete from Plati_Facturi
delete from Plati
delete from Roluri_Drepturi
delete from Utilizatori
delete from Roluri
delete from Drepturi
DBCC CHECKIDENT('PozitiiFacturiIesire', RESEED, 0)
DBCC CHECKIDENT('Stoc', RESEED, 0)
DBCC CHECKIDENT('PozitiiFacturiIntrare', RESEED, 0)
DBCC CHECKIDENT('Produse', RESEED, 0)
DBCC CHECKIDENT('FacturiIesire', RESEED, 0)
DBCC CHECKIDENT('FacturiIntrare', RESEED, 0)
DBCC CHECKIDENT('Firme', RESEED, 0)
DBCC CHECKIDENT('Delegati', RESEED, 0)
DBCC CHECKIDENT('Banci', RESEED, 0)
DBCC CHECKIDENT('Plati_Facturi', RESEED, 0)
DBCC CHECKIDENT('Plati', RESEED, 0)
DBCC CHECKIDENT('Roluri_Drepturi', RESEED, 0)
DBCC CHECKIDENT('Roluri', RESEED, 0)
DBCC CHECKIDENT('Utilizatori', RESEED, 0)
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (1,'Plati','Efectuare plati')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (2,'Firme','Adaugare si modificare firme')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (3,'Produse','Adaugare si modificare produse')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (4,'Facturi intrare','Adaugare facturi intrare')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (5,'Facturi iesire','Adaugare facturi iesire')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (6,'Stoc','Vizualizare stoc')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (7,'Rapoarte','Eliberare rapoarte')
INSERT INTO Drepturi (Id, Nume,Descriere) VALUES (8,'Administrare','Administrare aplicatie')
insert into Setari (AdminPassword, MyFirmaId) values ('d41d8cd98f00b204e9800998ecf8427e',0)