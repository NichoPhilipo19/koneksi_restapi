-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Jan 2023 pada 10.50
-- Versi server: 10.4.11-MariaDB
-- Versi PHP: 7.3.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tescasemst`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `recid` int(3) NOT NULL,
  `fullname` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `isActive` int(1) DEFAULT 0,
  `isBanned` int(1) DEFAULT 0,
  `Role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`recid`, `fullname`, `email`, `username`, `password`, `isActive`, `isBanned`, `Role`) VALUES
(1, 'nicho philipo', 'nichophilipo.xrpl2.vx@gmail.com', 'niko_krenz', '123', 0, 0, 'Admin'),
(2, 'aimara stephanny', 'aimara@gmail.com', 'aimara123', '123', 0, 0, 'Admin'),
(3, 'gloria karmila sinaga', 'gloriaKS@gmail.com', 'gloriaKS123', '123', 0, 0, 'Admin'),
(4, 'puja vita septiani', 'pujavita@gmail.com', 'pujavita123', '123', 0, 0, 'Admin'),
(5, 'agus dani', 'agusD@gmail.com', 'agusD123', '123', 0, 0, 'Admin'),
(6, 'daffa ksatria putra', 'daffaKP@gmail.com', 'daffaKP123', '123', 0, 0, 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`recid`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `recid` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
