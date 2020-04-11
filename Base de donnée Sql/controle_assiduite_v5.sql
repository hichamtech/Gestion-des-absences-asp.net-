-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : sam. 11 avr. 2020 à 02:57
-- Version du serveur :  10.4.11-MariaDB
-- Version de PHP : 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `controle_assiduite_v5`
--

-- --------------------------------------------------------

--
-- Structure de la table `Abscence`
--

CREATE TABLE `Abscence` (
  `code_abs` int(11) NOT NULL,
  `date_abs` datetime(6) NOT NULL,
  `etudiantcode_etudiant` int(11) NOT NULL,
  `seancecode_seance` int(11) NOT NULL,
  `professeurcode_professeur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Abscence`
--

INSERT INTO `Abscence` (`code_abs`, `date_abs`, `etudiantcode_etudiant`, `seancecode_seance`, `professeurcode_professeur`) VALUES
(8, '2020-04-11 01:49:28.799543', 6, 4, 10),
(9, '2020-04-11 01:50:10.220690', 7, 4, 10),
(10, '2020-04-11 01:54:55.719830', 12, 6, 10);

-- --------------------------------------------------------

--
-- Structure de la table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `AspNetRoles`
--

INSERT INTO `AspNetRoles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`) VALUES
('8aabc939-aa50-4c42-86fe-e76263352737', 'Prof', 'PROF', '6fcab291-3b01-4f66-96a4-e595bc307c9a'),
('fa175f7f-3115-42b5-8866-eff7fb34036a', 'Admin', 'ADMIN', 'ba19cbc7-c2b7-4b85-aeb8-141253f4233d');

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `AspNetUserRoles`
--

INSERT INTO `AspNetUserRoles` (`UserId`, `RoleId`) VALUES
('1def75b3-da05-4058-847d-a1ac567bd205', 'fa175f7f-3115-42b5-8866-eff7fb34036a'),
('477f1a4c-3459-4297-b693-c774b189d686', '8aabc939-aa50-4c42-86fe-e76263352737'),
('9e9791a7-5b4e-4cae-80e7-85e96ba71b98', '8aabc939-aa50-4c42-86fe-e76263352737'),
('ad9126eb-b357-426c-ac67-e580c29fdf0b', 'fa175f7f-3115-42b5-8866-eff7fb34036a'),
('c76eb8cf-c7b5-4957-a533-c44cd36d37e4', '8aabc939-aa50-4c42-86fe-e76263352737'),
('ca454eac-cd26-45a6-8122-b3c33c227d03', '8aabc939-aa50-4c42-86fe-e76263352737'),
('da77b50a-c4e9-423f-8531-520a58cc3218', '8aabc939-aa50-4c42-86fe-e76263352737');

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Discriminator` longtext NOT NULL,
  `nom` longtext DEFAULT NULL,
  `prenom` longtext DEFAULT NULL,
  `status` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Discriminator`, `nom`, `prenom`, `status`) VALUES
('1def75b3-da05-4058-847d-a1ac567bd205', 'demo_admin@gmail.com', 'DEMO_ADMIN@GMAIL.COM', 'demo_admin@gmail.com', 'DEMO_ADMIN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEARBHeGzgJ26XAHdRycuOpzlAwq9c/YChyVOVWlHBWBv/3lO0sWGpE2cSggY+WWlPA==', 'L5FCM74TGABCGJUFC622OL3CGFOQABEN', '1e68d5b4-857c-49ad-92f4-2fa532a047f2', '0624987272', 0, 0, NULL, 1, 0, 'ApplicationUser', 'AdminNom', 'AdminPrenom', 'a'),
('477f1a4c-3459-4297-b693-c774b189d686', 'Professeur4@gmail.com', 'PROFESSEUR4@GMAIL.COM', 'Professeur4@gmail.com', 'PROFESSEUR4@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEAnvu478hweAi/Ag3PIFku77cqTP/v54Hl7AV7Q+dAOJyAwbxunEVQQHFBpKU+TZpg==', 'CCG4TFNUQ3SW7AAU3MVGNKUMPVPVBOYK', 'd908dd4e-4a6e-4790-8d39-5c5d7193d7d9', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'Professeur4', 'Professeur4', 'p'),
('9e9791a7-5b4e-4cae-80e7-85e96ba71b98', 'Professeur3@gmail.com', 'PROFESSEUR3@GMAIL.COM', 'Professeur3@gmail.com', 'PROFESSEUR3@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEBAhs3LhFmRAje9VvjfvaXZWsaBzz0LF0xXn29nP1usj0QMqo4ZM9pIasclTVsg+Uw==', 'YVOPJLS2ONHBTLNINUF72HPRJMSYYWMM', '78f5b76b-9e5f-4005-be33-c8e5ee516133', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'Professeur3', 'Professeur3', 'p'),
('ad9126eb-b357-426c-ac67-e580c29fdf0b', 'demo_admin1@gmail.com', 'DEMO_ADMIN1@GMAIL.COM', 'demo_admin1@gmail.com', 'DEMO_ADMIN1@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEJvjjklCPXwBYjmdegThWpKljQYvXbSGQHtCY8n1swn39f1XJZ+TZVCZqViu+L04Ow==', 'RK2XTX637HO5BH27RJLZHPARJXGGKXQW', '1dc1046c-0618-48c0-9c3f-91c8ca5316c0', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'AdminNom', 'AdminPrenom', 'a'),
('c76eb8cf-c7b5-4957-a533-c44cd36d37e4', 'professeur2@gmail.com', 'PROFESSEUR2@GMAIL.COM', 'professeur2@gmail.com', 'PROFESSEUR2@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEF0K4ws2yjTg9tSf585VgNwPkOWF1chslWYIy+rC1KqInTa99seNqxGC2wrvxjEQxQ==', '3IRZZ2Z3STX5W67MXIHD5AISUYI7YQGM', 'a2948af5-ba79-43fa-8c08-896f9abe512c', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'Professeur2', 'professeur2', 'p'),
('ca454eac-cd26-45a6-8122-b3c33c227d03', 'prof1@gmail.com', 'PROF1@GMAIL.COM', 'prof1@gmail.com', 'PROF1@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAENq8yNN/eBY5Or+ioX+WGEopw1Ox3z1u6G6OfIan9jrsmmyP+mJqtkPApdTVB0Vvuw==', '46OAG5YYWLQBTWN3HOJG4CO76KII7GIR', '37de19d9-07a7-4a50-b5e0-ff7ece3c206f', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'prof1', 'prof1', 'p'),
('da77b50a-c4e9-423f-8531-520a58cc3218', 'demo_prof@gmail.com', 'DEMO_PROF@GMAIL.COM', 'demo_prof@gmail.com', 'DEMO_PROF@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEP/Oawz7hBV3q6mICMNySfpluuhT9pdt/3PGrOvLWfD1Mo2lcrqNd9dA/2Wcx2OeAA==', 'TJ5BVU6SKMMGVPLM7WGZY6JRQHHHCDCF', 'f27aeb53-8d65-4cd8-8c3e-6736e6f22c0c', NULL, 0, 0, NULL, 1, 0, 'ApplicationUser', 'demoNom', 'demoPrenom', 'p');

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `Etudiant`
--

CREATE TABLE `Etudiant` (
  `code_etudiant` int(11) NOT NULL,
  `nom` longtext DEFAULT NULL,
  `prenom` longtext DEFAULT NULL,
  `cin` longtext DEFAULT NULL,
  `date_naissance` datetime(6) NOT NULL,
  `email` longtext DEFAULT NULL,
  `code_rfid` longtext DEFAULT NULL,
  `Filierecode_filiere` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Etudiant`
--

INSERT INTO `Etudiant` (`code_etudiant`, `nom`, `prenom`, `cin`, `date_naissance`, `email`, `code_rfid`, `Filierecode_filiere`) VALUES
(6, 'Hassani', 'Hicham', 'AE183650', '1997-09-18 00:00:00.000000', 'hicham_barakate@hotmail.fr', 'AE183650-3-13', 3),
(7, 'Lazar', 'Widyane', 'A52971', '1995-03-21 00:00:00.000000', 'Lazarwidyane@gmail.com', 'A52971-3-55', 3),
(8, 'Bellahcen', 'Saad', 'A2858C', '1997-09-10 00:00:00.000000', 'Saadbellahcen@gmail.com', 'A2858C-5-83', 5),
(9, 'Nasri', 'Khalil', 'AC5842', '1998-03-28 00:00:00.000000', 'nasrikhalil@gmail.com', 'AC5842-4-99', 4),
(10, 'Erraouihi', 'Youness', 'A5851A', '1998-04-15 00:00:00.000000', 'younesserraouihi@gmail.com', 'A5851A-5-76', 5),
(11, 'Malih', 'Hamza', 'C5841', '1997-04-10 00:00:00.000000', 'malihamza@gmail.com', 'C5841-3-24', 3),
(12, 'Kadmiri', 'Chaimae', 'A2951', '1997-09-14 00:00:00.000000', 'chaimaekadmiri@gmail.com', 'A2951-6-34', 6);

-- --------------------------------------------------------

--
-- Structure de la table `Filiere`
--

CREATE TABLE `Filiere` (
  `code_filiere` int(11) NOT NULL,
  `libele_filiere` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Filiere`
--

INSERT INTO `Filiere` (`code_filiere`, `libele_filiere`) VALUES
(3, 'GI'),
(4, 'GC'),
(5, 'GM'),
(6, 'AD');

-- --------------------------------------------------------

--
-- Structure de la table `Matiere`
--

CREATE TABLE `Matiere` (
  `code_matiere` int(11) NOT NULL,
  `libele_matiere` longtext DEFAULT NULL,
  `nbr_heures` int(11) NOT NULL,
  `Filierecode_filiere` int(11) NOT NULL,
  `Professeurcode_professeur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Matiere`
--

INSERT INTO `Matiere` (`code_matiere`, `libele_matiere`, `nbr_heures`, `Filierecode_filiere`, `Professeurcode_professeur`) VALUES
(5, 'Dev web', 35, 3, 10),
(6, 'Résistance des Materiaux', 30, 4, 12),
(7, 'Audit', 55, 6, 10),
(8, 'Electronic', 50, 5, 10),
(9, 'Android', 40, 3, 9);

-- --------------------------------------------------------

--
-- Structure de la table `Professeur`
--

CREATE TABLE `Professeur` (
  `code_professeur` int(11) NOT NULL,
  `nom` longtext DEFAULT NULL,
  `prenom` longtext DEFAULT NULL,
  `email` longtext DEFAULT NULL,
  `telephone` longtext DEFAULT NULL,
  `code_user` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Professeur`
--

INSERT INTO `Professeur` (`code_professeur`, `nom`, `prenom`, `email`, `telephone`, `code_user`) VALUES
(8, 'demoNom', 'demoPrenom', 'demo_prof@gmail.com', NULL, 'da77b50a-c4e9-423f-8531-520a58cc3218'),
(9, 'prof1', 'prof1', 'prof1@gmail.com', NULL, 'ca454eac-cd26-45a6-8122-b3c33c227d03'),
(10, 'Professeur2', 'professeur2', 'professeur2@gmail.com', NULL, 'c76eb8cf-c7b5-4957-a533-c44cd36d37e4'),
(11, 'Professeur3', 'Professeur3', 'Professeur3@gmail.com', NULL, '9e9791a7-5b4e-4cae-80e7-85e96ba71b98'),
(12, 'Professeur4', 'Professeur4', 'Professeur4@gmail.com', NULL, '477f1a4c-3459-4297-b693-c774b189d686');

-- --------------------------------------------------------

--
-- Structure de la table `Salle`
--

CREATE TABLE `Salle` (
  `code_salle` int(11) NOT NULL,
  `numero_salle` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Salle`
--

INSERT INTO `Salle` (`code_salle`, `numero_salle`) VALUES
(1, 'A1'),
(2, 'B4'),
(3, 'C5'),
(4, 'B1'),
(5, 'A2');

-- --------------------------------------------------------

--
-- Structure de la table `Seance`
--

CREATE TABLE `Seance` (
  `code_seance` int(11) NOT NULL,
  `libele_seance` longtext DEFAULT NULL,
  `date_debut` datetime(6) NOT NULL,
  `date_fin` datetime(6) NOT NULL,
  `Matierecode_matiere` int(11) NOT NULL,
  `Sallecode_salle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Seance`
--

INSERT INTO `Seance` (`code_seance`, `libele_seance`, `date_debut`, `date_fin`, `Matierecode_matiere`, `Sallecode_salle`) VALUES
(4, 'Seance Dev Web', '2020-04-11 08:10:00.000000', '2020-04-11 10:00:00.000000', 5, 1),
(5, 'RDM1', '2020-04-13 08:00:00.000000', '2020-04-13 10:00:00.000000', 6, 3),
(6, 'Adt1', '2020-04-14 10:00:00.000000', '2020-04-14 00:00:00.000000', 7, 3),
(8, 'Andr1', '2020-04-12 16:00:00.000000', '2020-04-12 18:00:00.000000', 9, 1);

-- --------------------------------------------------------

--
-- Structure de la table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20200402032800_CreateDb', '3.1.2'),
('20200410005249_ProfUser', '3.1.2');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Abscence`
--
ALTER TABLE `Abscence`
  ADD PRIMARY KEY (`code_abs`),
  ADD KEY `IX_Abscence_etudiantcode_etudiant` (`etudiantcode_etudiant`),
  ADD KEY `IX_Abscence_professeurcode_professeur` (`professeurcode_professeur`),
  ADD KEY `IX_Abscence_seancecode_seance` (`seancecode_seance`);

--
-- Index pour la table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Index pour la table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Index pour la table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Index pour la table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Index pour la table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Index pour la table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Index pour la table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Index pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  ADD PRIMARY KEY (`code_etudiant`),
  ADD KEY `IX_Etudiant_Filierecode_filiere` (`Filierecode_filiere`);

--
-- Index pour la table `Filiere`
--
ALTER TABLE `Filiere`
  ADD PRIMARY KEY (`code_filiere`);

--
-- Index pour la table `Matiere`
--
ALTER TABLE `Matiere`
  ADD PRIMARY KEY (`code_matiere`),
  ADD KEY `IX_Matiere_Filierecode_filiere` (`Filierecode_filiere`),
  ADD KEY `IX_Matiere_Professeurcode_professeur` (`Professeurcode_professeur`);

--
-- Index pour la table `Professeur`
--
ALTER TABLE `Professeur`
  ADD PRIMARY KEY (`code_professeur`),
  ADD UNIQUE KEY `IX_Professeur_code_user` (`code_user`);

--
-- Index pour la table `Salle`
--
ALTER TABLE `Salle`
  ADD PRIMARY KEY (`code_salle`);

--
-- Index pour la table `Seance`
--
ALTER TABLE `Seance`
  ADD PRIMARY KEY (`code_seance`),
  ADD KEY `IX_Seance_Matierecode_matiere` (`Matierecode_matiere`),
  ADD KEY `IX_Seance_Sallecode_salle` (`Sallecode_salle`);

--
-- Index pour la table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Abscence`
--
ALTER TABLE `Abscence`
  MODIFY `code_abs` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  MODIFY `code_etudiant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `Filiere`
--
ALTER TABLE `Filiere`
  MODIFY `code_filiere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `Matiere`
--
ALTER TABLE `Matiere`
  MODIFY `code_matiere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `Professeur`
--
ALTER TABLE `Professeur`
  MODIFY `code_professeur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `Salle`
--
ALTER TABLE `Salle`
  MODIFY `code_salle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `Seance`
--
ALTER TABLE `Seance`
  MODIFY `code_seance` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Abscence`
--
ALTER TABLE `Abscence`
  ADD CONSTRAINT `FK_Abscence_Etudiant_etudiantcode_etudiant` FOREIGN KEY (`etudiantcode_etudiant`) REFERENCES `Etudiant` (`code_etudiant`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Abscence_Professeur_professeurcode_professeur` FOREIGN KEY (`professeurcode_professeur`) REFERENCES `Professeur` (`code_professeur`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Abscence_Seance_seancecode_seance` FOREIGN KEY (`seancecode_seance`) REFERENCES `Seance` (`code_seance`) ON DELETE CASCADE;

--
-- Contraintes pour la table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  ADD CONSTRAINT `FK_Etudiant_Filiere_Filierecode_filiere` FOREIGN KEY (`Filierecode_filiere`) REFERENCES `Filiere` (`code_filiere`) ON DELETE CASCADE;

--
-- Contraintes pour la table `Matiere`
--
ALTER TABLE `Matiere`
  ADD CONSTRAINT `FK_Matiere_Filiere_Filierecode_filiere` FOREIGN KEY (`Filierecode_filiere`) REFERENCES `Filiere` (`code_filiere`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Matiere_Professeur_Professeurcode_professeur` FOREIGN KEY (`Professeurcode_professeur`) REFERENCES `Professeur` (`code_professeur`) ON DELETE CASCADE;

--
-- Contraintes pour la table `Professeur`
--
ALTER TABLE `Professeur`
  ADD CONSTRAINT `FK_Professeur_AspNetUsers_code_user` FOREIGN KEY (`code_user`) REFERENCES `AspNetUsers` (`Id`);

--
-- Contraintes pour la table `Seance`
--
ALTER TABLE `Seance`
  ADD CONSTRAINT `FK_Seance_Matiere_Matierecode_matiere` FOREIGN KEY (`Matierecode_matiere`) REFERENCES `Matiere` (`code_matiere`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Seance_Salle_Sallecode_salle` FOREIGN KEY (`Sallecode_salle`) REFERENCES `Salle` (`code_salle`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
