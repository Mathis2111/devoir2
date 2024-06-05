-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 05 juin 2024 à 16:28
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projet_devoir_2`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

CREATE TABLE `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(3, '2024-01-14 11:03:55', '2025-03-09 07:17:42', 1),
(3, '2024-02-20 05:37:38', '2024-09-03 19:21:31', 3),
(3, '2024-03-10 11:22:30', '2023-06-19 02:06:09', 3),
(3, '2024-10-24 17:32:16', '2023-10-31 00:11:49', 4),
(3, '2025-04-29 08:39:04', '2024-10-08 06:40:31', 1),
(4, '2024-01-05 08:19:34', '2024-05-25 01:30:02', 2),
(4, '2024-01-08 06:06:05', '2024-10-27 16:48:01', 3),
(4, '2024-05-03 15:12:37', '2023-11-11 13:24:30', 3),
(4, '2024-06-01 10:38:47', '2024-06-03 10:38:47', 3),
(4, '2025-04-10 22:06:39', '2025-02-09 15:51:26', 2),
(5, '2024-05-11 09:57:37', '2024-04-26 01:26:51', 1),
(5, '2024-06-27 17:53:53', '2024-09-19 02:15:16', 2),
(5, '2024-10-24 18:24:12', '2023-09-05 06:29:59', 3),
(6, '2024-04-29 12:19:39', '2024-08-27 05:03:58', 3),
(6, '2024-06-03 16:07:28', '2024-05-14 12:18:21', 3),
(6, '2024-07-03 07:42:43', '2023-08-23 08:53:40', 2),
(6, '2024-08-06 18:54:54', '2023-09-05 14:50:06', 2),
(6, '2024-08-13 21:47:28', '2023-08-14 14:14:48', 3),
(6, '2024-09-30 02:00:19', '2024-08-08 02:10:34', 3),
(6, '2024-12-29 19:09:33', '2023-11-18 15:53:12', 4),
(6, '2025-01-14 22:40:55', '2025-02-20 18:10:03', 3),
(7, '2023-07-10 02:12:28', '2024-12-18 20:31:29', 1),
(7, '2024-05-18 14:23:31', '2024-02-23 13:32:00', 3),
(7, '2024-05-19 19:53:52', '2023-10-31 07:30:55', 4),
(7, '2024-07-14 20:37:11', '2023-07-27 22:26:51', 1),
(7, '2024-10-09 11:13:16', '2025-01-28 07:31:25', 3),
(8, '2023-12-03 22:10:00', '2025-05-09 17:26:24', 3),
(8, '2023-12-20 16:39:23', '2023-12-29 02:38:04', 4),
(8, '2024-04-14 01:20:38', '2024-03-25 09:14:00', 2),
(8, '2024-08-14 18:39:14', '2024-08-21 10:57:35', 3),
(8, '2024-10-29 07:03:00', '2023-08-11 21:02:03', 2),
(8, '2024-12-17 00:46:10', '2024-05-05 21:46:09', 4),
(8, '2024-12-22 01:33:50', '2023-09-06 18:10:46', 4),
(8, '2025-02-14 12:09:40', '2024-03-15 16:23:06', 1),
(9, '2023-11-18 12:58:16', '2024-02-04 00:48:39', 1),
(9, '2023-12-11 03:26:58', '2023-06-09 23:58:28', 1),
(9, '2024-02-02 13:24:21', '2024-08-08 11:36:18', 2),
(9, '2025-02-17 00:19:49', '2024-11-03 22:40:33', 1),
(10, '2024-04-14 05:17:50', '2024-09-23 05:21:26', 2),
(10, '2024-04-25 18:35:07', '2023-08-26 00:49:30', 2),
(10, '2024-08-14 11:59:19', '2024-01-22 08:28:15', 1),
(11, '2023-07-20 05:05:17', '2024-01-13 22:05:06', 3),
(11, '2023-09-03 06:16:24', '2024-06-19 12:43:16', 2),
(11, '2024-01-21 07:06:46', '2024-10-04 15:33:07', 2),
(11, '2024-02-22 08:33:13', '2025-05-30 23:01:35', 1),
(11, '2024-03-31 04:55:51', '2023-07-06 06:39:09', 3),
(11, '2024-06-09 16:18:02', '2024-06-01 21:44:09', 4),
(11, '2024-07-08 08:05:10', '2023-09-06 04:21:21', 2),
(12, '2023-07-21 16:27:12', '2025-03-14 03:42:50', 3),
(12, '2024-02-07 13:18:48', '2024-08-28 21:50:02', 3),
(12, '2024-05-21 00:00:53', '2024-12-11 23:06:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

CREATE TABLE `motif` (
  `idmotif` int(11) NOT NULL,
  `libelle` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

CREATE TABLE `personnel` (
  `idpersonnel` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(2, 'Dupont', 'Jean', '0665656565', 'jean.dupont@gmail.com', 1),
(3, 'Lester', 'Caryn', '06 12 76 16 02', 'quisque@protonmail.com', 1),
(4, 'Bryant', 'Daquan', '08 12 81 88 23', 'mi@outlook.net', 3),
(5, 'Mccullough', 'Illana', '07 73 06 44 43', 'eros.turpis.non@hotmail.ca', 2),
(6, 'Higgins', 'Asher', '01 64 87 73 25', 'orci.ut@hotmail.couk', 1),
(7, 'Harmon', 'Imani', '06 51 11 42 22', 'elit.etiam@protonmail.org', 2),
(8, 'Manning', 'Rowan', '07 25 87 46 41', 'fringilla.cursus@google.edu', 1),
(9, 'Hodges', 'Amir', '03 35 65 69 56', 'phasellus.vitae@protonmail.couk', 2),
(10, 'Irwin', 'Vanna', '03 86 67 36 34', 'duis.at@yahoo.com', 3),
(11, 'Burton', 'Ursa', '09 52 08 11 72', 'suspendisse.sed@hotmail.ca', 2),
(12, 'Powers', 'Ulysses', '07 77 42 61 75', 'nec@google.couk', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

CREATE TABLE `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('login', '9bf831a94921178b1f165a5e3a1580e83be738c82c057f3dbe180b3bb66a53a8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `idmotif` (`idmotif`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `idservice` (`idservice`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `idmotif` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `idservice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
