CREATE DATABASE IF NOT EXISTS `proyecto_eurekabit`;
USE `proyecto_eurekabit`;


CREATE TABLE IF NOT EXISTS `departamento` (
  `id_dep` tinyint(4) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id_dep`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `localidad` (
  `id_loc` smallint(6) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `id_dep` tinyint(4) NOT NULL,
  PRIMARY KEY (`id_loc`),
  UNIQUE KEY `nombre` (`nombre`,`id_dep`),
  KEY `id_dep` (`id_dep`),
  CONSTRAINT `localidad_ibfk_1` FOREIGN KEY (`id_dep`) REFERENCES `departamento` (`id_dep`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `persona` (
  `ci` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `direc` varchar(75) NOT NULL,
  `id_loc` smallint(6) NOT NULL,
  PRIMARY KEY (`ci`),
  KEY `id_loc` (`id_loc`),
  CONSTRAINT `persona_ibfk_1` FOREIGN KEY (`id_loc`) REFERENCES `localidad` (`id_loc`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `cliente` (
  `ci_cli` int(11) NOT NULL,
  `correo` varchar(75) NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`ci_cli`),
  UNIQUE KEY `correo` (`correo`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`ci_cli`) REFERENCES `persona` (`ci`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `sucursal` (
  `cod_suc` smallint(6) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `direc` varchar(75) NOT NULL,
  `id_loc` smallint(6) NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`cod_suc`),
  KEY `id_loc` (`id_loc`),
  CONSTRAINT `sucursal_ibfk_1` FOREIGN KEY (`id_loc`) REFERENCES `localidad` (`id_loc`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;



CREATE TABLE IF NOT EXISTS `empleado` (
  `ci_emp` int(11) NOT NULL,
  `passwd` varchar(41) NOT NULL,
  `cod_suc` smallint(6) NOT NULL,
  `rol` varchar(15) NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`ci_emp`),
  KEY `cod_suc` (`cod_suc`),
  CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`ci_emp`) REFERENCES `persona` (`ci`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `empleado_ibfk_2` FOREIGN KEY (`cod_suc`) REFERENCES `sucursal` (`cod_suc`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `ch_rol` CHECK (`rol` in ('gerente','agente'))
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `propiedad` (
  `cod_prop` smallint(6) NOT NULL AUTO_INCREMENT,
  `ci_cli` int(11) NOT NULL,
  `tipo` varchar(25) NOT NULL,
  `operacion` varchar(25) NOT NULL,
  `precio` int(11) NOT NULL,
  `cant_habs` int(11) NOT NULL,
  `mts2` int(11) NOT NULL,
  `direc` varchar(75) NOT NULL,
  `id_loc` smallint(6) NOT NULL,
  `imagen` mediumblob NOT NULL,
  `activo` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`cod_prop`),
  KEY `id_loc` (`id_loc`),
  KEY `ci_cli` (`ci_cli`),
  CONSTRAINT `propiedad_ibfk_1` FOREIGN KEY (`id_loc`) REFERENCES `localidad` (`id_loc`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `propiedad_ibfk_2` FOREIGN KEY (`ci_cli`) REFERENCES `cliente` (`ci_cli`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `ch_tipo_local` CHECK (`tipo` in ('casa','apartamento','local comercial')),
  CONSTRAINT `ch_operacion` CHECK (`operacion` in ('alquiler','venta','ambas'))
) ENGINE=InnoDB AUTO_INCREMENT=221 DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `telefono` (
  `ci` int(11) NOT NULL,
  `numero` varchar(45) NOT NULL,
  UNIQUE KEY `numero` (`numero`),
  KEY `ci` (`ci`),
  CONSTRAINT `telefono_ibfk_1` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `visita` (
  `ci_cli` int(11) NOT NULL,
  `cod_prop` smallint(6) NOT NULL,
  `ci_emp` int(11) DEFAULT NULL,
  `fh_visita` datetime NOT NULL,
  `fh_reserva` datetime NOT NULL DEFAULT current_timestamp(),
  `fh_modificada` datetime DEFAULT NULL,
  `fh_cancelada` datetime DEFAULT NULL,
  PRIMARY KEY (`ci_cli`,`cod_prop`),
  KEY `ci_emp` (`ci_emp`),
  KEY `cod_prop` (`cod_prop`),
  CONSTRAINT `visita_ibfk_1` FOREIGN KEY (`ci_emp`) REFERENCES `empleado` (`ci_emp`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `visita_ibfk_2` FOREIGN KEY (`ci_cli`) REFERENCES `cliente` (`ci_cli`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `visita_ibfk_3` FOREIGN KEY (`cod_prop`) REFERENCES `propiedad` (`cod_prop`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `ch_visita` CHECK (`fh_visita` > `fh_reserva`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE VIEW datos_cliente AS SELECT P.*,C.correo FROM cliente C, persona P WHERE P.ci = C.ci_cli AND C.activo = true;

