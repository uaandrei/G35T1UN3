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
Go
DBCC CHECKIDENT('PozitiiFacturiIesire', RESEED, 0)
Go
DBCC CHECKIDENT('Stoc', RESEED, 0)
Go
DBCC CHECKIDENT('PozitiiFacturiIntrare', RESEED, 0)
Go
DBCC CHECKIDENT('Produse', RESEED, 0)
Go
DBCC CHECKIDENT('FacturiIesire', RESEED, 0)
Go
DBCC CHECKIDENT('FacturiIntrare', RESEED, 0)
Go
DBCC CHECKIDENT('Firme', RESEED, 0)
Go
DBCC CHECKIDENT('Delegati', RESEED, 0)
Go
DBCC CHECKIDENT('Banci', RESEED, 0)
Go
DBCC CHECKIDENT('Plati_Facturi', RESEED, 0)
Go
DBCC CHECKIDENT('Plati', RESEED, 0)
Go
