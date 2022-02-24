-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Feb 2022 pada 04.22
-- Versi server: 10.4.20-MariaDB
-- Versi PHP: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uaspem`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_mhsw`
--

CREATE TABLE `ms_mhsw` (
  `npm` varchar(10) NOT NULL,
  `nama_mhs` varchar(50) DEFAULT NULL,
  `kode_prodi` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_prodi`
--

CREATE TABLE `ms_prodi` (
  `kode_prodi` varchar(10) NOT NULL,
  `nama_prodi` varchar(50) DEFAULT NULL,
  `singkatan` varchar(5) DEFAULT NULL,
  `biaya_kuliah` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `ms_prodi`
--

INSERT INTO `ms_prodi` (`kode_prodi`, `nama_prodi`, `singkatan`, `biaya_kuliah`) VALUES
('PR1', 'Teknik Informatika', 'IT', 7000000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tr_daftar_ulang`
--

CREATE TABLE `tr_daftar_ulang` (
  `npm` varchar(10) NOT NULL,
  `grade` char(1) DEFAULT NULL,
  `total_biaya` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `ms_mhsw`
--
ALTER TABLE `ms_mhsw`
  ADD PRIMARY KEY (`npm`);

--
-- Indeks untuk tabel `ms_prodi`
--
ALTER TABLE `ms_prodi`
  ADD PRIMARY KEY (`kode_prodi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
