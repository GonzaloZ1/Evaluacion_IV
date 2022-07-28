-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-07-2022 a las 09:54:19
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `evaluacion`
--

--
-- Volcado de datos para la tabla `estudio`
--

INSERT INTO `estudio` (`Id`, `Nombre`, `Fundacion`, `Consola`, `Empleados`) VALUES
(1, 'Nintendo', '1889-09-23', 1, 6413),
(2, 'Ubisoft', '1986-03-28', 0, 20324),
(3, 'Sony', '1993-11-16', 1, 1455);

--
-- Volcado de datos para la tabla `juego`
--

INSERT INTO `juego` (`Id`, `EstudioId`, `Nombre`, `UnidadesVendidas`) VALUES
(1, 1, 'The Legend of Zelda', 6510000),
(2, 1, 'Super Mario Bros', 40240000),
(3, 1, 'Donkey Kong', 1560000),
(4, 1, 'Mario Kart 64', 9893000),
(5, 1, 'The Legend of Zelda: Majora´s Mask', 3360000),
(6, 1, 'The Legend of Zelda: Ocarina of Time', 7600000),
(7, 1, 'Super Mario 64', 11910000),
(8, 1, 'The Legend of Zelda: Breath of the Wild', 26550000),
(9, 1, 'Super Mario Odyssey', 23500000),
(10, 1, 'Super Mario Maker 2', 7150000),
(11, 2, 'Rayman', 4000000),
(12, 2, 'Rayman 2: The Great Escape', 430000),
(13, 2, 'Prince of Persia: The Sands of Time', 14000000),
(14, 2, 'Prince of Persia: Warrior Within', 1900000),
(15, 2, 'Prince of Persia: The Two Thrones', 1500000),
(16, 2, 'Assassin\'s Creed', 8000000),
(17, 2, 'Assassin\'s Creed II', 9000000),
(18, 2, 'Assassin\'s Creed: Brotherhood', 6500000),
(19, 2, 'Assassin\'s Creed: Revelations', 7000000),
(20, 2, 'Assassin\'s Creed III', 7000000),
(21, 3, 'Crash Bandicoot', 6000000),
(22, 3, 'Crash Bandicoot 2: Cortex Strikes Back', 7580000),
(23, 3, 'Crash Bandicoot 3: Warped', 7130000),
(24, 3, 'Crash Team Racing', 1900000),
(25, 3, 'Twisted Metal', 5000000),
(26, 3, 'Ratchet & Clank', 3710000),
(27, 3, 'MediEvil', 400000),
(28, 3, 'God of War', 4600000),
(29, 3, 'God of War II', 4240000),
(30, 3, 'God of War III', 5200000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
