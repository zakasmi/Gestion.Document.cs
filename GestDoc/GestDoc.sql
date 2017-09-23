use master 
create database GestDoc on
 ( name = GestDoc,
   filename = 'D:\GestDoc.mdf',
   size = 5,
   maxsize = 10,
   filegrowth = 1
   )
use GestDoc
create table Theme (
code_theme varchar(10) Primary Key ,
nom_theme varchar(30),
[description] varchar(30)
)
create table Membre (
[login] varchar(10) Primary Key ,
nom varchar(30),
prenom varchar(30),
email varchar(30),
passe varchar(20),
)
create table Document (
code_doc varchar(10) primary key ,
description_doc varchar(30),
chemin_doc varchar(30),
date_doc datetime,
etat_doc int ,
code_theme varchar(10) references Theme(code_theme) on delete cascade on update cascade ,
[login] varchar(10) references membre([login]) on delete cascade on update cascade
)
alter table Document add constraint C_etat check (etat_doc in ('1','2'))

insert into Document Values ('Doc1','descdoc1'	,'CheminDoc1','1998-05-19 00:00:00.000',1,'Theme2','Login1'),
('Doc10','descdoc7',	'CheminDoc6'    ,'2008-05-19 00:00:00.000',	1	,'Theme8',	'Login1'),
('Doc2',	'descdoc2',	'CheminDoc2'	,'1999-05-19 00:00:00.000',	2	,'Theme2',	'Login2'),
('Doc3',	'descdoc3',	'CheminDoc3'	,'2000-05-19 00:00:00.000',	1	,'Theme1',	'Login3'),
('Doc4',	'descdoc4',	'CheminDoc4'	,'1993-05-19 00:00:00.000',	1	,'Theme1',	'Login4'),
('Doc5',	'descdoc5',	'CheminDoc5'	,'2004-05-19 00:00:00.000',	2	,'Theme3',	'Login1'),
('Doc6',	'descdoc6',	'CheminDoc6'	,'2005-05-19 00:00:00.000',	2	,'Theme4',	'Login5'),
('Doc7',	'descdoc7',	'CheminDoc6'	,'2015-05-19 00:00:00.000',	2	,'Theme5',	'Login6'),
('Doc8',	'descdoc7',	'CheminDoc6'	,'2016-05-19 00:00:00.000',	1	,'Theme6',	'Login5'),
('Doc9',	'descdoc7',	'CheminDoc6'	,'2013-05-19 00:00:00.000',	2	,'Theme7',	'Login4'),
('Test3',	'bbb	',        'kkkk',	         '2016-02-11 21:36:02.000',  1	,'Theme10'	,'Login1')

insert into Membre Values   ('Login1','nom1',	'prenom1',	'email1',	'passe1'),
							('Login2'	,'nom2',	'prenom2',	'email2',	'passe2'),
							('Login3'	,'nom3',	'prenom3',	'email3',	'passe3'),
							('Login4'	,'nom4',	'prenom4',	'email4',	'passe4'),
							('Login5'	,'nom5',	'prenom5',	'email5',	'passe5'),
							('Login6'	,'nom6',	'prenom6',	'email6',	'passe6')

insert into Theme values ('Theme1',	'nom1',	'desc1'),	
						('Theme2',	'nom2',	'desc2'),
						('Theme3',	'nom3',	'desc3'),
						('Theme4',	'nom4',	'desc4'),
						('Theme5',	'nom5',	'desc5'),
						('Theme6',	'nom6',	'desc6'),
						('Theme7',	'nom7',	'desc7'),
						('Theme8',	'nom8',	'desc8'),
						('Theme9',	'nom9',  'desc9'),
						('Theme10',	'nom10',	'desc10')
