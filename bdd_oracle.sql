CREATE TABLE MembreRessourceHumaine (
	identif number NOT NULL,
	nom varchar2(155),
	prenom varchar2(155),
	email varchar2(155),
	nomUtilisateur varchar2(155) NOT NULL,
	motDePasse varchar2(155) NOT NULL,
	CONSTRAINT pk_MembreRessourceHumaine PRIMARY KEY (identif)
);

CREATE SEQUENCE MembreRessourceHum_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER MembreRessourceHum_on_insert
	BEFORE INSERT ON MembreRessourceHumaine
	FOR EACH ROW
BEGIN
	SELECT MembreRessourceHum_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Personne (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	prenom varchar2(155) NOT NULL,
	email varchar2(155),
	dateDeNaissance DATE,
	transport varchar2(4000),
	noteRessourceHumaine varchar2(4000),
	identif_MembreRessourceHumaine number,
	identif_Region number,
	CONSTRAINT pk_Personne PRIMARY KEY (identif)
);

ALTER TABLE Personne ADD CONSTRAINT fk_MembreRessourceHumaine FOREIGN KEY (identif_MembreRessourceHumaine) REFERENCES MembreRessourceHumaine (identif);
ALTER TABLE Personne ADD CONSTRAINT fk_Region FOREIGN KEY (identif_Region) REFERENCES Region (identif);

CREATE SEQUENCE Personne_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Personne_on_insert
	BEFORE INSERT ON Personne
	FOR EACH ROW
BEGIN
	SELECT Personne_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Reseau (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Reseau PRIMARY KEY (identif)
);

CREATE SEQUENCE Reseau_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Reseau_on_insert
	BEFORE INSERT ON Reseau
	FOR EACH ROW
BEGIN
	SELECT Reseau_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Competence (
	identif number NOT NULL,
	libelle varchar2(155) NOT NULL,
	CONSTRAINT pk_Competence PRIMARY KEY (identif)
);

CREATE SEQUENCE Competence_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Competence_on_insert
	BEFORE INSERT ON Competence
	FOR EACH ROW
BEGIN
	SELECT Competence_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Categorie (
	identif number NOT NULL,
	libelle varchar2(155) NOT NULL,
	CONSTRAINT pk_Categorie PRIMARY KEY (identif)
);

CREATE SEQUENCE Categorie_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Categorie_on_insert
	BEFORE INSERT ON Categorie
	FOR EACH ROW
BEGIN
	SELECT Categorie_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Entreprise (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Entreprise PRIMARY KEY (identif)
);

CREATE SEQUENCE Entreprise_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Entreprise_on_insert
	BEFORE INSERT ON Entreprise
	FOR EACH ROW
BEGIN
	SELECT Entreprise_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Formation (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Formation PRIMARY KEY (identif)
);

CREATE SEQUENCE Formation_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Formation_on_insert
	BEFORE INSERT ON Formation
	FOR EACH ROW
BEGIN
	SELECT Formation_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/



CREATE TABLE Region (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Region PRIMARY KEY (identif)
);

CREATE SEQUENCE Region_sequence
INCREMENT BY 1
START WITH 1
MAXVALUE 99999999999
NOCYCLE;

CREATE OR REPLACE TRIGGER Region_on_insert
	BEFORE INSERT ON Region
	FOR EACH ROW
BEGIN
	SELECT Region_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/








CREATE TABLE Personne_Reseau (
	identif_Personne number NOT NULL,
	identif_Reseau number NOT NULL,
	lien varchar2(155) NOT NULL,
	CONSTRAINT pk_Personne_Reseau PRIMARY KEY (identif_Personne, identif_Reseau)
);

ALTER TABLE Personne_Reseau ADD CONSTRAINT fk_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Reseau ADD CONSTRAINT fk_Reseau FOREIGN KEY (identif_Reseau) REFERENCES Reseau (identif);



CREATE TABLE Personne_Competence (
	identif_Personne number NOT NULL,
	identif_Competence number NOT NULL,
	CONSTRAINT pk_Personne_Competence PRIMARY KEY (identif_Personne, identif_Competence)
);

ALTER TABLE Personne_Competence ADD CONSTRAINT fk_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Competence ADD CONSTRAINT fk_Competence FOREIGN KEY (identif_Competence) REFERENCES Competence (identif);



CREATE TABLE Competence_Categorie (
	identif_Competence number NOT NULL,
	identif_Categorie number NOT NULL,
	CONSTRAINT pk_Competence_Categorie PRIMARY KEY (identif_Categorie, identif_Competence)
);

ALTER TABLE Competence_Categorie ADD CONSTRAINT fk_Competence FOREIGN KEY (identif_Competence) REFERENCES Competence (identif);
ALTER TABLE Competence_Categorie ADD CONSTRAINT fk_Categorie FOREIGN KEY (identif_Categorie) REFERENCES Categorie (identif);



CREATE TABLE Personne_Entreprise (
	identif_Personne number NOT NULL,
	identif_Entreprise number NOT NULL,
	dateDeb date NOT NULL,
	dateFin date NOT NULL,
	CONSTRAINT pk_Personne_Entreprise PRIMARY KEY (identif_Personne, identif_Entreprise)
);

ALTER TABLE Personne_Entreprise ADD CONSTRAINT fk_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Entreprise ADD CONSTRAINT fk_Entreprise FOREIGN KEY (identif_Entreprise) REFERENCES Entreprise (identif);



CREATE TABLE Personne_Formation (
	identif_Formation number NOT NULL,
	identif_Personne number NOT NULL,
	annee varchar2(4),
	CONSTRAINT pk_Personne_Formation PRIMARY KEY (identif_Personne, identif_Formation)
);

ALTER TABLE Personne_Formation ADD CONSTRAINT fk_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Formation ADD CONSTRAINT fk_Formation FOREIGN KEY (identif_Formation) REFERENCES Formation (identif);









/* INSERTS */
INSERT INTO MembreRessourceHumaine (identif, nom, prenom, email, nomUtilisateur, motDePasse) VALUES (1, 'MARTIN', 'Paul', 'paul.martin@gmail.com', 'pmartin', '123'),
																									(2, 'BERNARD', 'Jules', 'jules.bernard@gmail.com', 'jbernard', '123');


INSERT INTO Competence (identif, libelle) VALUES (1, 'PHP'),
											 		(2, 'Golang'),
											 		(3, 'JavaScript'),
											 		(4, 'Java'),
											 		(5, 'Réseau neuronal convolutif'),
											 		(6, 'D3.js'),
											 		(7, 'QOS'),
											 		(8, 'Téléphonie'),
											 		(9, 'Gestion de domaine'),
											 		(10, 'DNS'),
											 		(11, 'MySQL'),
											 		(12, 'UML');


INSERT INTO Categorie (identif, libelle) VALUES (1, 'Programmation Informatique'),
											 		(2, 'Intelligence artificiel'),
											 		(3, 'Réseaux Informatiques'),
											 		(4, 'Systèmes Informatiques'),
											 		(5, 'Analyse et Conception logiciel Informatique');


INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 1),
																		 		(1, 2),
																		 		(1, 3),
																		 		(1, 4),
																		 		(1, 6),
																		 		(1, 11),
																		 		(2, 5),
																		 		(2, 6),
																		 		(3, 7),
																		 		(3, 8),
																		 		(4, 9),
																		 		(4, 10),
																		 		(4, 11),
																		 		(5, 11),
																		 		(5, 12);

INSERT INTO region(nom) VALUES  ('Alsace'),
								('Aquitaine'),
								('Auvergne'),
								('Basse Normandie'),
								('Bourgogne'),
								('Bretagne'),
								('Centre'),
								('Champagne Ardenne'),
								('Corse'),
								('Franche Comte'),
								('Haute Normandie'),
								('Ile de France'),
								('Languedoc Roussillon'),
								('Limousin'),
								('Lorraine'),
								('Midi-Pyrénées'),
								('Nord Pas de Calais'),
								('PACA'),
								('Pays de la Loire'),
								('Picardie'),
								('Poitou Charente'),
								('Rhone Alpes');


INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, noteRessourceHumaine, identif_MembreRessourceHumaine, identif_Region) VALUES  (1, 'BRIN', 'Sergueï', 'email@gmail.com', '1973-08-21', 'Permis B & Voiture', '', 1, 2),
																																							(2, 'LARRY', 'Page', 'email@gmail.com', '1973-04-26', 'Permis B', '', 1, 5),
																																							(3, 'BEZOS', 'Jeff', 'email@gmail.com', '1946-01-12', '', '', 2, 2),
																																							(4, 'GATES', 'Bill', 'email@gmail.com', '1955-10-28', 'Permis B', '', 2, 2),
																																							(5, 'ZUCKERBERG', 'Mark', 'email@gmail.com', '1984-05-14', 'Permis B', '', 2, 7),
																																							(6, 'NIEL', 'Xavier', 'email@gmail.com', '1967-08-25', '', '', 2, 2);


INSERT INTO Reseau(identif, nom) VALUES (1, 'Twitter'),
										(2, 'Facebook'),
										(3, 'Linkedin'),
										(4, 'Google+'),
										(5, 'Github'),
										(6, 'Site web');


INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES  (4, 1, 'https://twitter.com/billgates'),
																			(4, 3, 'https://www.linkedin.com/in/williamhgates'),
																			(4, 6, 'https://microsoft.com'),
																			(5, 1, 'https://twitter.com/finkd'),
																			(5, 2, 'https://www.facebook.com/zuck'),
																			(5, 6, 'https://facebook.com');


INSERT INTO Entreprise (identif, nom) VALUES (1, 'Entreprise 1'),
											 (2, 'Entreprise 2');


INSERT INTO Personne_Entreprise (identif_Personne, identif_Entreprise, dateDeb, dateFin) VALUES (1, 1, '2008-11-12', '2009-01-24'),
																								(4, 1, '2010-11-12', '2012-02-12'),
																								(5, 2, '2006-11-12', '2010-06-04'),
																								(6, 2, '2000-11-20', '2012-07-30');


INSERT INTO Formation(identif, nom) VALUES  (1, 'BTS SIO : SLAM'),
								  			(2, 'BTS SIO : SISR');


INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES  (1, 1, 1990),
																					(1, 2, 1991),
								  													(2, 1, 1994),
								  													(2, 2, 1995),
								  													(3, 1, 1980),
								  													(4, 1, 1979),
								  													(4, 2, 1979),
								  													(5, 1, 2002),
								  													(6, 1, 1988),
								  													(6, 2, 1989);


INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES  (1, 1),
								  												(2, 1),
								  												(3, 1),
								  												(4, 1),
								  												(5, 1),
								  												(6, 1),
								  												(5, 5),
								  												(3, 5),
								  												(5, 6),
								  												(6, 10),
								  												(5, 7),
								  												(5, 8);