-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : lun. 30 mars 2020 à 02:53
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
-- Base de données : `controle_assiduite_v4`
--

-- --------------------------------------------------------

--
-- Structure de la table `Abscence`
--

CREATE TABLE `Abscence` (
  `code_abs` int(11) NOT NULL,
  `date_abs` datetime(6) NOT NULL,
  `etudiantcode_etudiant` int(11) NOT NULL,
  `professeurcode_professeur` int(11) DEFAULT NULL,
  `seancecode_seance` int(11) NOT NULL DEFAULT 0,
  `professeucode_professeur` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Abscence`
--

INSERT INTO `Abscence` (`code_abs`, `date_abs`, `etudiantcode_etudiant`, `professeurcode_professeur`, `seancecode_seance`, `professeucode_professeur`) VALUES
(10, '2020-03-26 21:46:25.204908', 1, 1, 1, 0),
(11, '2020-03-27 22:58:27.381119', 1, 1, 1, 0),
(12, '2020-03-27 22:58:32.249548', 1, 1, 1, 0),
(13, '2020-03-27 22:58:34.377068', 2, 2, 3, 0);

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
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
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
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('0e14dca1-331a-4485-9aee-50278c36a4a0', 'hicham.hassani@uir.ac.ma', 'HICHAM.HASSANI@UIR.AC.MA', 'hicham.hassani@uir.ac.ma', 'HICHAM.HASSANI@UIR.AC.MA', 1, 'AQAAAAEAACcQAAAAEBf//6XbB3aySi/O0y+hZ887KdWK2dlBHsGSkqBNc55EvVuB4Gm8Ts1kWNP1Iwb1EQ==', 'AF7RKA37KOFMPWL5WQ26RPJRFBVZ4B2D', '7668238e-ba71-4099-b938-a80e8d9d747b', NULL, 0, 0, NULL, 1, 0),
('a6cda0b4-5e6f-4daf-886a-d3f02cb3c9c2', 'hicham_barakate@hotmail.fr', 'HICHAM_BARAKATE@HOTMAIL.FR', 'hicham_barakate@hotmail.fr', 'HICHAM_BARAKATE@HOTMAIL.FR', 0, 'AQAAAAEAACcQAAAAEPbQgV5rKPOTQ77ZyodbAmhVd+y8ut5vDKr34LNegG9f+rkMupfUYn54/k4ujT2nkw==', 'AEM2MPQGV5FICPPCQSYGGMZDRDFU4FTH', '1a941699-c08d-466a-bc28-990eed985c4d', '0624987272', 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Structure de la table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
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
  `Filierecode_filiere` int(11) NOT NULL,
  `code_rfid` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Etudiant`
--

INSERT INTO `Etudiant` (`code_etudiant`, `nom`, `prenom`, `cin`, `date_naissance`, `email`, `Filierecode_filiere`, `code_rfid`) VALUES
(1, 'Hassani', 'Hicham', 'AE183650', '2020-03-26 00:00:00.000000', 'xxxxx@hotmail.fr', 3, 'rfid1'),
(2, 'zayed', 'opac', 'A2198', '1996-12-09 00:00:00.000000', 'zayed@hotmail.com', 2, 'rfid2');

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
(1, 'GC'),
(2, 'GM'),
(3, 'GI');

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
(1, 'Dev web', 40, 3, 1),
(2, 'oracle', 30, 2, 2),
(3, 'dev mobile', 45, 3, 2);

-- --------------------------------------------------------

--
-- Structure de la table `Professeur`
--

CREATE TABLE `Professeur` (
  `code_professeur` int(11) NOT NULL,
  `nom` longtext DEFAULT NULL,
  `prenom` longtext DEFAULT NULL,
  `email` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `Professeur`
--

INSERT INTO `Professeur` (`code_professeur`, `nom`, `prenom`, `email`) VALUES
(1, 'Hassani', 'Hicham', 'hicham.hassani@uir.ac.ma'),
(2, 'Sam', 'Notra', 'sam@hotmail.com');

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
(3, 'B4'),
(4, 'C5');

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
(1, 'Seance Dev Web', '2020-03-21 10:00:00.000000', '2020-03-21 00:00:00.000000', 1, 3),
(3, 'seance oracle', '2020-03-26 09:00:00.000000', '2020-03-26 10:00:00.000000', 2, 3),
(4, 'TestSeance', '2020-03-27 08:00:00.000000', '2020-03-27 10:30:00.000000', 1, 4),
(6, 'SeanceO', '2020-04-05 08:00:00.000000', '2020-04-05 10:00:00.000000', 1, 1),
(9, 'testAdd', '2020-03-29 09:00:00.000000', '2020-03-29 10:00:00.000000', 2, 3),
(11, 'btnAdd', '2020-03-29 00:00:00.000000', '2020-03-29 14:00:00.000000', 2, 3),
(12, 'btnAdd', '2020-04-01 08:00:00.000000', '2020-04-01 10:00:00.000000', 2, 3),
(14, 'lasttestbtn', '2020-03-09 16:00:00.000000', '2020-03-09 18:00:00.000000', 2, 4);

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
('20200320184319_InitialCreate', '3.1.2'),
('20200326124754_rfidAttr', '3.1.2');

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
  ADD PRIMARY KEY (`code_professeur`);

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
  MODIFY `code_abs` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

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
  MODIFY `code_etudiant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `Filiere`
--
ALTER TABLE `Filiere`
  MODIFY `code_filiere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `Matiere`
--
ALTER TABLE `Matiere`
  MODIFY `code_matiere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `Professeur`
--
ALTER TABLE `Professeur`
  MODIFY `code_professeur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `Salle`
--
ALTER TABLE `Salle`
  MODIFY `code_salle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `Seance`
--
ALTER TABLE `Seance`
  MODIFY `code_seance` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Abscence`
--
ALTER TABLE `Abscence`
  ADD CONSTRAINT `FK_Abscence_Professeur_professeurcode_professeur` FOREIGN KEY (`professeurcode_professeur`) REFERENCES `Professeur` (`code_professeur`);

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
-- Contraintes pour la table `Seance`
--
ALTER TABLE `Seance`
  ADD CONSTRAINT `FK_Seance_Matiere_Matierecode_matiere` FOREIGN KEY (`Matierecode_matiere`) REFERENCES `Matiere` (`code_matiere`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Seance_Salle_Sallecode_salle` FOREIGN KEY (`Sallecode_salle`) REFERENCES `Salle` (`code_salle`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
