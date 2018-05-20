CREATE TABLE MembreRessourceHumaine (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255),
	prenom varchar(255),
	email varchar(255),
	nomUtilisateur varchar(255) NOT NULL,
	motDePasse varchar(255) NOT NULL,
	CONSTRAINT pk_MembreRessourceHumaine PRIMARY KEY (identif)
);

CREATE TABLE Personne (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255) NOT NULL,
	prenom varchar(255) NOT NULL,
	email varchar(255),
	dateDeNaissance DATE,
	transport text,
	noteRessourceHumaine text,
	identif_MembreRessourceHumaine int,
	identif_Region int,
	CONSTRAINT pk_Personne PRIMARY KEY (identif)
);

CREATE TABLE Reseau (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255) NOT NULL,
	CONSTRAINT pk_Reseau PRIMARY KEY (identif)
);

CREATE TABLE Competence (
	identif int NOT NULL AUTO_INCREMENT,
	libelle varchar(255) NOT NULL,
	CONSTRAINT pk_Competence PRIMARY KEY (identif)
);

CREATE TABLE Categorie (
	identif int NOT NULL AUTO_INCREMENT,
	libelle varchar(255) NOT NULL,
	CONSTRAINT pk_Categorie PRIMARY KEY (identif)
);

CREATE TABLE Entreprise (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255) NOT NULL,
	CONSTRAINT pk_Entreprise PRIMARY KEY (identif)
);

CREATE TABLE Formation (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255) NOT NULL,
	CONSTRAINT pk_Formation PRIMARY KEY (identif)
);

CREATE TABLE Region (
	identif int NOT NULL AUTO_INCREMENT,
	nom varchar(255) NOT NULL,
	CONSTRAINT pk_Region PRIMARY KEY (identif)
);

CREATE TABLE Personne_Reseau (
	identif_Personne int NOT NULL,
	identif_Reseau int NOT NULL,
	lien varchar(255) NOT NULL,
	CONSTRAINT pk_Personne_Reseau PRIMARY KEY (identif_Personne, identif_Reseau)
);

ALTER TABLE Personne_Reseau ADD CONSTRAINT fkPersonne_Reseau_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Reseau ADD CONSTRAINT fkPersonne_Reseau_Reseau FOREIGN KEY (identif_Reseau) REFERENCES Reseau (identif);


CREATE TABLE Personne_Competence (
	identif_Personne int NOT NULL,
	identif_Competence int NOT NULL,
	CONSTRAINT pk_Personne_Competence PRIMARY KEY (identif_Personne, identif_Competence)
);

ALTER TABLE Personne_Competence ADD CONSTRAINT fkPersonne_Competence_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Competence ADD CONSTRAINT fkPersonne_Competence_Competence FOREIGN KEY (identif_Competence) REFERENCES Competence (identif);



CREATE TABLE Competence_Categorie (
	identif_Competence int NOT NULL,
	identif_Categorie int NOT NULL,
	CONSTRAINT pk_Competence_Categorie PRIMARY KEY (identif_Categorie, identif_Competence)
);

ALTER TABLE Competence_Categorie ADD CONSTRAINT fkCompetence_Categorie_Competence FOREIGN KEY (identif_Competence) REFERENCES Competence (identif);
ALTER TABLE Competence_Categorie ADD CONSTRAINT fkCompetence_Categorie_Categorie FOREIGN KEY (identif_Categorie) REFERENCES Categorie (identif);



CREATE TABLE Personne_Entreprise (
	identif_Personne int NOT NULL,
	identif_Entreprise int NOT NULL,
	dateDeb date NOT NULL,
	dateFin date NOT NULL,
	CONSTRAINT pk_Personne_Entreprise PRIMARY KEY (identif_Personne, identif_Entreprise)
);

ALTER TABLE Personne_Entreprise ADD CONSTRAINT fkPersonne_Entreprise_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Entreprise ADD CONSTRAINT fkPersonne_Entreprise_Entreprise FOREIGN KEY (identif_Entreprise) REFERENCES Entreprise (identif);



CREATE TABLE Personne_Formation (
	identif_Formation int NOT NULL,
	identif_Personne int NOT NULL,
	annee char(4),
	CONSTRAINT pk_Personne_Formation PRIMARY KEY (identif_Personne, identif_Formation)
);

ALTER TABLE Personne_Formation ADD CONSTRAINT fkPersonne_Formation_Personne FOREIGN KEY (identif_Personne) REFERENCES Personne (identif);
ALTER TABLE Personne_Formation ADD CONSTRAINT fkPersonne_Formation_Formation FOREIGN KEY (identif_Formation) REFERENCES Formation (identif);








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


INSERT INTO Personne(identif, nom, prenom, email, dateDeNaissance, transport, noteRessourceHumaine, identif_MembreRessourceHumaine, identif_Region) VALUES  (1, 'SERGUEÏ', 'Brin', 'email@gmail.com', '1973-08-21', 'Permis B & Voiture', '', 1, 2),
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