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
NOCYCLE;





CREATE TABLE Personne (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	prenom varchar2(155) NOT NULL,
	email varchar2(155),
	dateDeNaissance date,
	transport varchar2(4000),
	noteRessourceHumaine varchar2(4000),
	identif_MembreRessourceHumaine number,
	identif_Region number,
	CONSTRAINT pk_Personne PRIMARY KEY (identif)
);


CREATE SEQUENCE Personne_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Reseau (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Reseau PRIMARY KEY (identif)
);

CREATE SEQUENCE Reseau_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Competence (
	identif number NOT NULL,
	libelle varchar2(155) NOT NULL,
	CONSTRAINT pk_Competence PRIMARY KEY (identif)
);

CREATE SEQUENCE Competence_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Categorie (
	identif number NOT NULL,
	libelle varchar2(155) NOT NULL,
	CONSTRAINT pk_Categorie PRIMARY KEY (identif)
);

CREATE SEQUENCE Categorie_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Entreprise (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Entreprise PRIMARY KEY (identif)
);

CREATE SEQUENCE Entreprise_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Formation (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Formation PRIMARY KEY (identif)
);

CREATE SEQUENCE Formation_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Region (
	identif number NOT NULL,
	nom varchar2(155) NOT NULL,
	CONSTRAINT pk_Region PRIMARY KEY (identif)
);

CREATE SEQUENCE Region_sequence
INCREMENT BY 1
START WITH 1
NOCYCLE;


CREATE TABLE Personne_Reseau (
	identif_Personne number NOT NULL,
	identif_Reseau number NOT NULL,
	lien varchar2(155) NOT NULL,
	CONSTRAINT pk_Personne_Reseau PRIMARY KEY (identif_Personne, identif_Reseau)
);

CREATE TABLE Personne_Competence (
	identif_Personne number NOT NULL,
	identif_Competence number NOT NULL,
	CONSTRAINT pk_Personne_Competence PRIMARY KEY (identif_Personne, identif_Competence)
);

CREATE TABLE Competence_Categorie (
	identif_Competence number NOT NULL,
	identif_Categorie number NOT NULL,
	CONSTRAINT pk_Competence_Categorie PRIMARY KEY (identif_Categorie, identif_Competence)
);

CREATE TABLE Personne_Entreprise (
	identif_Personne number NOT NULL,
	identif_Entreprise number NOT NULL,
	dateDeb date NOT NULL,
	dateFin date NOT NULL,
	CONSTRAINT pk_Personne_Entreprise PRIMARY KEY (identif_Personne, identif_Entreprise)
);

CREATE TABLE Personne_Formation (
	identif_Formation number NOT NULL,
	identif_Personne number NOT NULL,
	annee varchar2(4),
	CONSTRAINT pk_Personne_Formation PRIMARY KEY (identif_Personne, identif_Formation)
);








/* TRIGGERS */
CREATE OR REPLACE TRIGGER MembreRessourceHum_on_insert
	BEFORE INSERT ON MembreRessourceHumaine
	FOR EACH ROW
BEGIN
	SELECT MembreRessourceHum_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Personne_on_insert
	BEFORE INSERT ON Personne
	FOR EACH ROW
BEGIN
	SELECT Personne_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Reseau_on_insert
	BEFORE INSERT ON Reseau
	FOR EACH ROW
BEGIN
	SELECT Reseau_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Competence_on_insert
	BEFORE INSERT ON Competence
	FOR EACH ROW
BEGIN
	SELECT Competence_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Categorie_on_insert
	BEFORE INSERT ON Categorie
	FOR EACH ROW
BEGIN
	SELECT Categorie_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Entreprise_on_insert
	BEFORE INSERT ON Entreprise
	FOR EACH ROW
BEGIN
	SELECT Entreprise_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Formation_on_insert
	BEFORE INSERT ON Formation
	FOR EACH ROW
BEGIN
	SELECT Formation_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/

CREATE OR REPLACE TRIGGER Region_on_insert
	BEFORE INSERT ON Region
	FOR EACH ROW
BEGIN
	SELECT Region_sequence.nextval
	INTO :new.identif
	FROM dual;
END;
/





/* CONSTRAINTS */
ALTER TABLE Personne ADD CONSTRAINT fkPersonne_MembreRessourceHuma FOREIGN KEY (identif_MembreRessourceHumaine) REFERENCES MembreRessourceHumaine (identif) ON DELETE CASCADE;
ALTER TABLE Personne ADD CONSTRAINT fkPersonne_Region FOREIGN KEY (identif_Region) REFERENCES Region (identif) ON DELETE CASCADE;

ALTER TABLE Personne_Reseau ADD CONSTRAINT fkPersonne_Reseau_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif) ON DELETE CASCADE;
ALTER TABLE Personne_Reseau ADD CONSTRAINT fkPersonneReseau_Reseau FOREIGN KEY (identif_Reseau) REFERENCES Reseau (identif) ON DELETE CASCADE;

ALTER TABLE Personne_Competence ADD CONSTRAINT fkPersonneCompetence_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif) ON DELETE CASCADE;
ALTER TABLE Personne_Competence ADD CONSTRAINT fkPersonneCompetence_Competenc FOREIGN KEY (identif_Competence) REFERENCES Competence (identif) ON DELETE CASCADE;

ALTER TABLE Competence_Categorie ADD CONSTRAINT fkCompetenceCategorie_Competen FOREIGN KEY (identif_Competence) REFERENCES Competence (identif) ON DELETE CASCADE;
ALTER TABLE Competence_Categorie ADD CONSTRAINT fkCompetenceCategorie_Categori FOREIGN KEY (identif_Categorie) REFERENCES Categorie (identif) ON DELETE CASCADE;

ALTER TABLE Personne_Entreprise ADD CONSTRAINT fkPersonneEntreprise_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif) ON DELETE CASCADE;
ALTER TABLE Personne_Entreprise ADD CONSTRAINT fkPersonneEntreprise_Entrepris FOREIGN KEY (identif_Entreprise) REFERENCES Entreprise (identif) ON DELETE CASCADE;

ALTER TABLE Personne_Formation ADD CONSTRAINT fkPersonneFormation_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif) ON DELETE CASCADE;
ALTER TABLE Personne_Formation ADD CONSTRAINT fkPersonneFormation_Formation FOREIGN KEY (identif_Formation) REFERENCES Formation (identif) ON DELETE CASCADE;







/* INSERTS */
INSERT INTO MembreRessourceHumaine (identif, nom, prenom, email, nomUtilisateur, motDePasse) VALUES (1, 'MARTIN', 'Paul', 'paul.martin@gmail.com', 'pmartin', '123'); 
INSERT INTO MembreRessourceHumaine (identif, nom, prenom, email, nomUtilisateur, motDePasse) VALUES (2, 'BERNARD', 'Jules', 'jules.bernard@gmail.com', 'jbernard', '123');


INSERT INTO Formation(identif, nom) VALUES (1, 'BTS SIO : SLAM');
INSERT INTO Formation(identif, nom) VALUES (2, 'BTS SIO : SISR');


INSERT INTO Competence (identif, libelle) VALUES (1, 'PHP');
INSERT INTO Competence (identif, libelle) VALUES (2, 'Golang');
INSERT INTO Competence (identif, libelle) VALUES (3, 'JavaScript');
INSERT INTO Competence (identif, libelle) VALUES (4, 'Java');
INSERT INTO Competence (identif, libelle) VALUES (5, 'Réseau neuronal convolutif');
INSERT INTO Competence (identif, libelle) VALUES (6, 'D3.js');
INSERT INTO Competence (identif, libelle) VALUES (7, 'QOS');
INSERT INTO Competence (identif, libelle) VALUES (8, 'Téléphonie');
INSERT INTO Competence (identif, libelle) VALUES (9, 'Gestion de domaine');
INSERT INTO Competence (identif, libelle) VALUES (10, 'DNS');
INSERT INTO Competence (identif, libelle) VALUES (11, 'MySQL');
INSERT INTO Competence (identif, libelle) VALUES (12, 'UML');


INSERT INTO Categorie (identif, libelle) VALUES (1, 'Programmation Informatique');
INSERT INTO Categorie (identif, libelle) VALUES (2, 'Intelligence artificiel');
INSERT INTO Categorie (identif, libelle) VALUES (3, 'Réseaux Informatiques');
INSERT INTO Categorie (identif, libelle) VALUES (4, 'Systèmes Informatiques');
INSERT INTO Categorie (identif, libelle) VALUES (5, 'Analyse et Conception logiciel Informatique');


INSERT INTO region(nom) VALUES ('Alsace');
INSERT INTO region(nom) VALUES ('Aquitaine');
INSERT INTO region(nom) VALUES ('Auvergne');
INSERT INTO region(nom) VALUES ('Basse Normandie');
INSERT INTO region(nom) VALUES ('Bourgogne');
INSERT INTO region(nom) VALUES ('Bretagne');
INSERT INTO region(nom) VALUES ('Centre');
INSERT INTO region(nom) VALUES ('Champagne Ardenne');
INSERT INTO region(nom) VALUES ('Corse');
INSERT INTO region(nom) VALUES ('Franche Comte');
INSERT INTO region(nom) VALUES ('Haute Normandie');
INSERT INTO region(nom) VALUES ('Ile de France');
INSERT INTO region(nom) VALUES ('Languedoc Roussillon');
INSERT INTO region(nom) VALUES ('Limousin');
INSERT INTO region(nom) VALUES ('Lorraine');
INSERT INTO region(nom) VALUES ('Midi-Pyrénées');
INSERT INTO region(nom) VALUES ('Nord Pas de Calais');
INSERT INTO region(nom) VALUES ('PACA');
INSERT INTO region(nom) VALUES ('Pays de la Loire');
INSERT INTO region(nom) VALUES ('Picardie');
INSERT INTO region(nom) VALUES ('Poitou Charente');
INSERT INTO region(nom) VALUES ('Rhone Alpes');


INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, identif_MembreRessourceHumaine, identif_Region) VALUES  (1, 'BRIN', 'Sergueï', 'email@gmail.com', to_date('1973-08-21', 'YYYY-MM-DD'), 'Permis B et Voiture', 1, 2);
INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, identif_MembreRessourceHumaine, identif_Region) VALUES  (2, 'LARRY', 'Page', 'email@gmail.com', to_date('1973-04-26', 'YYYY-MM-DD'), 'Permis B', 1, 5);
INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, identif_MembreRessourceHumaine, identif_Region) VALUES  (3, 'BEZOS', 'Jeff', 'email@gmail.com', to_date('1946-01-12', 'YYYY-MM-DD'), 2, 2);
INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, identif_MembreRessourceHumaine, identif_Region) VALUES  (4, 'GATES', 'Bill', 'email@gmail.com', to_date('1955-10-28', 'YYYY-MM-DD'), 'Permis B', 2, 2);
INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, identif_MembreRessourceHumaine, identif_Region) VALUES  (5, 'ZUCKERBERG', 'Mark', 'email@gmail.com', to_date('1984-05-14', 'YYYY-MM-DD'), 'Permis B', 2, 7);
INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, identif_MembreRessourceHumaine, identif_Region) VALUES  (6, 'NIEL', 'Xavier', 'email@gmail.com', to_date('1967-08-25', 'YYYY-MM-DD'), 2, 2);


INSERT INTO Reseau(identif, nom) VALUES (1, 'Twitter');
INSERT INTO Reseau(identif, nom) VALUES (2, 'Facebook');
INSERT INTO Reseau(identif, nom) VALUES (3, 'Linkedin');
INSERT INTO Reseau(identif, nom) VALUES (4, 'Google+');
INSERT INTO Reseau(identif, nom) VALUES (5, 'Github');
INSERT INTO Reseau(identif, nom) VALUES (6, 'Site web');


INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 1);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 2);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 3);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 4);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 6);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (1, 11);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (2, 5);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (2, 6);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (3, 7);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (3, 8);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (4, 9);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (4, 10);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (4, 11);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (5, 11);
INSERT INTO Competence_Categorie (identif_Categorie, identif_Competence) VALUES (5, 12);


INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (4, 1, 'https://twitter.com/billgates');
INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (4, 3, 'https://www.linkedin.com/in/williamhgates');
INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (4, 6, 'https://microsoft.com');
INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (5, 1, 'https://twitter.com/finkd');
INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (5, 2, 'https://www.facebook.com/zuck');
INSERT INTO Personne_Reseau(identif_Personne, identif_Reseau, lien) VALUES (5, 6, 'https://facebook.com');


INSERT INTO Entreprise (identif, nom) VALUES (1, 'Entreprise 1');
INSERT INTO Entreprise (identif, nom) VALUES (2, 'Entreprise 2');


INSERT INTO Personne_Entreprise (identif_Personne, identif_Entreprise, dateDeb, dateFin) VALUES (1, 1, to_date('2008-11-12', 'YYYY-MM-DD'), to_date('2009-01-24', 'YYYY-MM-DD'));
INSERT INTO Personne_Entreprise (identif_Personne, identif_Entreprise, dateDeb, dateFin) VALUES (4, 1, to_date('2010-11-12', 'YYYY-MM-DD'), to_date('2012-02-12', 'YYYY-MM-DD'));
INSERT INTO Personne_Entreprise (identif_Personne, identif_Entreprise, dateDeb, dateFin) VALUES (5, 2, to_date('2006-11-12', 'YYYY-MM-DD'), to_date('2010-06-04', 'YYYY-MM-DD'));
INSERT INTO Personne_Entreprise (identif_Personne, identif_Entreprise, dateDeb, dateFin) VALUES (6, 2, to_date('2000-11-20', 'YYYY-MM-DD'), to_date('2012-07-30', 'YYYY-MM-DD'));


INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (1, 1, 1990);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (1, 2, 1991);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (2, 1, 1994);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (2, 2, 1995);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (3, 1, 1980);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (4, 1, 1979);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (4, 2, 1979);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (5, 1, 2002);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (6, 1, 1988);
INSERT INTO Personne_Formation(identif_Personne, identif_Formation, annee) VALUES (6, 2, 1989);


INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (1, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (2, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (3, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (4, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (5, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (6, 1);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (5, 5);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (3, 5);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (5, 6);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (6, 10);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (5, 7);
INSERT INTO Personne_Competence(identif_Personne, identif_Competence) VALUES (5, 8);



/* commit */
commit;