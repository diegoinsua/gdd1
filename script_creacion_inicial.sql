-- BASE DE DATOS UTILIZADA

USE GD2C2013


-- CREACION DEL ESQUEMA

IF NOT EXISTS ( SELECT *
				FROM sys.schemas 
				WHERE name = N'VARIETE_GDD')  
EXEC ('CREATE SCHEMA [VARIETE_GDD] AUTHORIZATION [gd]');
GO



-- DROP FK
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AFI_DNI') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.AFILIADO DROP CONSTRAINT AFI_DNI;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AFI_PLAN_MEDICO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.AFILIADO DROP CONSTRAINT AFI_PLAN_MEDICO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PRO_DNI') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PROFESIONAL DROP CONSTRAINT PRO_DNI;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PROESP_PROFESIONAL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES DROP CONSTRAINT PROESP_PROFESIONAL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PROESP_ESPECIALIDAD') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES DROP CONSTRAINT PROESP_ESPECIALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROLUSU_USUARIO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.ROL_USUARIO DROP CONSTRAINT ROLUSU_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROLUSU_ROL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.ROL_USUARIO DROP CONSTRAINT ROLUSU_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROLFUN_ROL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES DROP CONSTRAINT ROLFUN_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROLFUN_FUNCIONALIDAD') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES DROP CONSTRAINT ROLFUN_FUNCIONALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.TUR_PROFESIONAL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.TURNOS DROP CONSTRAINT TUR_PROFESIONAL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.TUR_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.TURNOS DROP CONSTRAINT TUR_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONCON_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_CONSULTA DROP CONSTRAINT BONCON_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONCON_CONSULTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_CONSULTA DROP CONSTRAINT BONCON_CONSULTA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONCON_PLAN') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_CONSULTA DROP CONSTRAINT BONCON_PLAN;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONCON_COMPRA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_CONSULTA DROP CONSTRAINT BONCON_COMPRA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CON_PROFESIONAL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.CONSULTA DROP CONSTRAINT CON_PROFESIONAL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CON_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.CONSULTA DROP CONSTRAINT CON_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CON_TURNOS') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.CONSULTA DROP CONSTRAINT CON_TURNOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CON_BONO_CONSULTA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.CONSULTA DROP CONSTRAINT CON_BONO_CONSULTA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONFAR_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_FARMACIA DROP CONSTRAINT BONFAR_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONFAR_PLAN') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.BONO_FARMACIA DROP CONSTRAINT BONFAR_PLAN;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.REC_BONFAR') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.RECETA DROP CONSTRAINT REC_BONFAR;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.RECMED_RECETA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS DROP CONSTRAINT RECMED_RECETA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.RECMED_MEDICAMENTOS') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS DROP CONSTRAINT RECMED_MEDICAMENTOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.COM_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.COMPRA DROP CONSTRAINT COM_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AGE_PROFESIONAL') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.AGENDA DROP CONSTRAINT AGE_PROFESIONAL;

--IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.DIAATE_AGENDA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
--ALTER TABLE VARIETE_GDD.DIAS_ATENCION DROP CONSTRAINT DIAATE_AGENDA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PLAMOD_PLAN_NUEVO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS DROP CONSTRAINT PLAMOD_PLAN_NUEVO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PLAMOD_PLAN_VIEJO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS DROP CONSTRAINT PLAMOD_PLAN_VIEJO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PLAMOD_AFILIADO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS DROP CONSTRAINT PLAMOD_AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CANTUR_TURNO') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.CANCELACION_TURNO DROP CONSTRAINT CANTUR_TURNO;


GO
 

-- DROP TABLAS
--ORDENAR PARA QUE BORRE EN ORDEN BIEN

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PROFESIONAL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.PROFESIONAL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PROFESIONAL_ESPECIALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ESPECIALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.ESPECIALIDADES;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROL_USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.ROL_USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.ROL_FUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.ROL_FUNCIONALIDADES;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.FUNCIONALIDADES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.FUNCIONALIDADES;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.TURNOS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.TURNOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONO_CONSULTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.BONO_CONSULTA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CONSULTA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.CONSULTA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.BONO_FARMACIA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.BONO_FARMACIA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.RECETA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.RECETA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.RECETA_MEDICAMENTOS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.RECETA_MEDICAMENTOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.MEDICAMENTOS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.MEDICAMENTOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.COMPRA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PLANES') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.PLANES;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AGENDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.AGENDA;

--IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.DIAS_ATENCION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
--DROP TABLE VARIETE_GDD.DIAS_ATENCION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AFILIADO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.PLANES_MODIFICADOS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.PLANES_MODIFICADOS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.CANCELACION_TURNO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.CANCELACION_TURNO;


GO

  -- DROP PROCEDURES
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_AFILIADOS') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_AFILIADOS;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_PROFESIONALES') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_PROFESIONALES;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_PLANES') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_PLANES;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_ESPECIALIDADES') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_ESPECIALIDADES;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_TURNOS') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_TURNOS;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_COMPRAS_BONOS') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_COMPRAS_BONOS;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_BONOS_CONSULTA') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_BONOS_CONSULTA;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_CONSULTA') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_CONSULTA;


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.INSERT_ROL') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.INSERT_ROL;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_BONOS_FARMACIA') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_BONOS_FARMACIA;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_RECETA') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_RECETA;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_MEDICAMENTOS') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_MEDICAMENTOS;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.ADMINISTRADOR') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.ADMINISTRADOR;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.ROL') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.ROL;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_FUNCIONALIDADES') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_FUNCIONALIDADES;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.INSERT_ROL_FUNCIONALIDADES') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.INSERT_ROL_FUNCIONALIDADES;

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.MIGRA_AGENDA') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.MIGRA_AGENDA;

GO
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.DIAS_ATENCION') AND type in (N'P', N'PC'))
--DROP PROCEDURE VARIETE_GDD.DIAS_ATENCION;
--GO


BEGIN TRANSACTION

-- CREACION DE TABLAS
CREATE TABLE VARIETE_GDD.USUARIO (
	USU_DNI NUMERIC(8) UNIQUE NOT NULL,
	USU_USERNAME VARCHAR(255) UNIQUE NOT NULL ,
	USU_CLAVE VARCHAR(255) NOT NULL,
	USU_CANTIDAD_INTENTOS INTEGER DEFAULT '0',
	USU_HABILITADO BIT DEFAULT '1',
	USU_TIPO_DOCUMENTO VARCHAR(3) DEFAULT 'DNI',
	USU_NOMBRES VARCHAR(255),
	USU_APELLIDO VARCHAR(255),
	USU_DIRECCION VARCHAR(255),
	USU_TELEFONO NUMERIC(18),
	USU_MAIL VARCHAR(255),
	USU_FECHA_NACIMIENTO DATETIME,
	USU_SEXO CHAR DEFAULT 'N' --'F' O 'M'
)
GO

CREATE TABLE VARIETE_GDD.AFILIADO ( 
	AFI_NUMERO INTEGER IDENTITY (1,1) NOT NULL,
	AFI_GRUPO INTEGER DEFAULT '01',
	AFI_DNI NUMERIC(8) UNIQUE NOT NULL,
	AFI_ESTADO_CIVIL VARCHAR(11) DEFAULT 'N',
	AFI_CANTIDAD_FAMILIARES INTEGER DEFAULT '0',
	AFI_PLAN_MEDICO NUMERIC(18) NOT NULL,
	AFI_CANTIDAD_CONSULTAS INTEGER DEFAULT '0'	
)
GO

CREATE TABLE VARIETE_GDD.PROFESIONAL ( 
	PRO_DNI NUMERIC(8) UNIQUE NOT NULL,
	PRO_MATRICULA VARCHAR(50) DEFAULT '000'
)
GO

CREATE TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES (
	PROESP_PROFESIONAL NUMERIC(8) NOT NULL,
	PROESP_ESPECIALIDAD INTEGER NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.ESPECIALIDADES (
	ESP_CODIGO INTEGER UNIQUE NOT NULL,
	ESP_DESCRIPCION VARCHAR (255),
	ESP_TIPO VARCHAR(80),
	ESP_TIPO_DESCRIPCION VARCHAR (255)
)
GO

CREATE TABLE VARIETE_GDD.ROL_USUARIO (
	ROLUSU_USUARIO NUMERIC(8) NOT NULL,
	ROLUSU_ROL VARCHAR (15) NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.ROL (
	ROL_NOMBRE VARCHAR (15) UNIQUE NOT NULL, --AFILIADO O PROFESIONAL O ADMINISTRADOR
	ROL_HABILITADO BIT NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.ROL_FUNCIONALIDADES (
	ROLFUN_ROL VARCHAR (15) UNIQUE NOT NULL,
	ROLFUN_FUNCIONALIDAD INTEGER NOT NULL
)	
GO

CREATE TABLE VARIETE_GDD.FUNCIONALIDADES (
	FUN_CODIGO INTEGER NOT NULL,
	FUN_DESCRIPCION VARCHAR(80) NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.TURNOS (
	TUR_CODIGO INTEGER NOT NULL,
	TUR_PROFESIONAL NUMERIC(8) NOT NULL,
	TUR_AFILIADO NUMERIC(8) NOT NULL,
	TUR_FECHA DATETIME NOT NULL
)	
GO

CREATE TABLE VARIETE_GDD.BONO_CONSULTA (
	BONCON_CODIGO INTEGER NOT NULL,
	BONCON_AFILIADO NUMERIC(8) NOT NULL,
	BONCON_CONSULTA INTEGER NOT NULL,
	BONCON_FECHA DATETIME NOT NULL,
	BONCON_PLAN NUMERIC(18) NOT NULL,
	BONCON_COMPRA INTEGER NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.CONSULTA (
	CON_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	CON_PROFESIONAL NUMERIC(8) NOT NULL, 
	CON_AFILIADO NUMERIC(8) NOT NULL,
	CON_TURNOS INTEGER NOT NULL,
	CON_FECHA_LLEGADA DATETIME,
	CON_SINTOMAS VARCHAR(255),
	CON_DIAGNOSTICO VARCHAR(1000),
	CON_BONO_CONSULTA INTEGER NOT NULL,
	CON_REALIZADA BIT DEFAULT '1'
)
GO

CREATE TABLE VARIETE_GDD.BONO_FARMACIA (
	BONFAR_CODIGO INTEGER NOT NULL,
	BONFAR_AFILIADO NUMERIC(8) NOT NULL,
	BONFAR_FECHA DATETIME NOT NULL,
	BONFAR_PLAN NUMERIC(18) NOT NULL 
)
GO

CREATE TABLE VARIETE_GDD.RECETA (
	REC_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	REC_BONFAR INTEGER NOT NULL  
)
GO

CREATE TABLE VARIETE_GDD.RECETA_MEDICAMENTOS (
	RECMED_RECETA INTEGER NOT NULL,
	RECMED_MEDICAMENTOS INTEGER NOT NULL,
	RECMED_CANTIDAD INTEGER DEFAULT '1'
)
GO

CREATE TABLE VARIETE_GDD.MEDICAMENTOS (
	MED_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	MED_NOMBRE VARCHAR(255)
)
GO

CREATE TABLE VARIETE_GDD.PLANES (
	PLA_CODIGO NUMERIC(18) NOT NULL,
	PLA_DESCRIPCION VARCHAR(255),
	PLA_PRECIO_BONO_FARMACIA NUMERIC(18) DEFAULT '0',
	PLA_PRECIO_BONO_CONSULTA NUMERIC (18) DEFAULT '0'	
)
GO

CREATE TABLE VARIETE_GDD.COMPRA (
	COM_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	COM_FECHA DATETIME,
	COM_CANTIDAD_BONO_FARMACIA INTEGER, 
	COM_CANTIDAD_BONO_CONSULTA INTEGER,  
	COM_PRECIO FLOAT,
	COM_AFILIADO NUMERIC(8) NOT NULL	
)	
GO

CREATE TABLE VARIETE_GDD.AGENDA(
	AGE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	AGE_PROFESIONAL NUMERIC(8) NOT NULL,
	AGE_FECHA_INICIO DATETIME DEFAULT NULL,
	AGE_FECHA_FIN DATETIME DEFAULT NULL
)
GO

--CREATE TABLE VARIETE_GDD.DIAS_ATENCION(
--	DIAATE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
--    DIAATE_DIA CHAR (2) NOT NULL,
--    DIAATE_HORARIO_INICIO DATETIME,
--    DIAATE_HORARIO_FIN DATETIME,
-- --   DIAATE_FECHA DATETIME,
--    DIAATE_AGENDA INTEGER NOT NULL
--)

CREATE TABLE VARIETE_GDD.PLANES_MODIFICADOS(
	PLAMOD_CODIGO INTEGER IDENTITY (1,1) NOT NULL,
	PLAMOD_PLAN_NUEVO NUMERIC(18) NOT NULL,
	PLAMOD_PLAN_VIEJO NUMERIC(18) NOT NULL,
	PLAMOD_FECHA DATETIME,
	PLAMOD_MOTIVO VARCHAR(255),
	PLAMOD_AFILIADO NUMERIC(8) NOT NULL
)
GO

CREATE TABLE VARIETE_GDD.CANCELACION_TURNO(
	CANTUR_CODIGO INTEGER IDENTITY (1,1) NOT NULL,
	CANTUR_TURNO INTEGER NOT NULL,
	CANTUR_RAZON VARCHAR (255)
)
GO
               
--CONSTRAINTS (PK Y FK)

--//USUARIO
ALTER TABLE VARIETE_GDD.USUARIO ADD PRIMARY KEY (USU_DNI);

--//MEDICAMENTOS	
ALTER TABLE VARIETE_GDD.MEDICAMENTOS ADD PRIMARY KEY (MED_CODIGO);

--//PLANES
ALTER TABLE VARIETE_GDD.PLANES ADD PRIMARY KEY (PLA_CODIGO);

--//ESPECIALIDADES
ALTER TABLE VARIETE_GDD.ESPECIALIDADES ADD PRIMARY KEY (ESP_CODIGO);

--//ROL
ALTER TABLE VARIETE_GDD.ROL ADD PRIMARY KEY (ROL_NOMBRE);

--//FUNCIONALIDADES
ALTER TABLE VARIETE_GDD.FUNCIONALIDADES ADD PRIMARY KEY (FUN_CODIGO);

--//AFILIADO
ALTER TABLE VARIETE_GDD.AFILIADO ADD PRIMARY KEY (AFI_DNI);
ALTER TABLE VARIETE_GDD.AFILIADO ADD FOREIGN KEY (AFI_DNI) REFERENCES VARIETE_GDD.USUARIO(USU_DNI);
ALTER TABLE VARIETE_GDD.AFILIADO ADD FOREIGN KEY (AFI_PLAN_MEDICO) REFERENCES VARIETE_GDD.PLANES(PLA_CODIGO);

--//PROFESIONAL	
ALTER TABLE VARIETE_GDD.PROFESIONAL ADD PRIMARY KEY (PRO_DNI);
ALTER TABLE VARIETE_GDD.PROFESIONAL ADD FOREIGN KEY (PRO_DNI) REFERENCES VARIETE_GDD.USUARIO(USU_DNI);

--//PROFESIONAL_ESPECIALIDADES
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD PRIMARY KEY (PROESP_PROFESIONAL,PROESP_ESPECIALIDAD);
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD FOREIGN KEY (PROESP_PROFESIONAL) REFERENCES VARIETE_GDD.PROFESIONAL(PRO_DNI);
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD FOREIGN KEY (PROESP_ESPECIALIDAD) REFERENCES VARIETE_GDD.ESPECIALIDADES(ESP_CODIGO);



--//ROL_USUARIO
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD PRIMARY KEY (ROLUSU_USUARIO,ROLUSU_ROL);
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD FOREIGN KEY (ROLUSU_USUARIO) REFERENCES VARIETE_GDD.USUARIO(USU_DNI);
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD FOREIGN KEY (ROLUSU_ROL) REFERENCES VARIETE_GDD.ROL(ROL_NOMBRE);

--//ROL_FUNCIONALIDADES
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES ADD PRIMARY KEY (ROLFUN_ROL,ROLFUN_FUNCIONALIDAD);
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES ADD FOREIGN KEY (ROLFUN_ROL) REFERENCES VARIETE_GDD.ROL(ROL_NOMBRE);
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES ADD FOREIGN KEY (ROLFUN_FUNCIONALIDAD) REFERENCES VARIETE_GDD.FUNCIONALIDADES(FUN_CODIGO);

--//COMPRA
ALTER TABLE VARIETE_GDD.COMPRA ADD PRIMARY KEY (COM_CODIGO);
ALTER TABLE VARIETE_GDD.COMPRA ADD FOREIGN KEY (COM_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);

--//TURNOS
ALTER TABLE VARIETE_GDD.TURNOS ADD PRIMARY KEY (TUR_CODIGO);
ALTER TABLE VARIETE_GDD.TURNOS ADD FOREIGN KEY (TUR_PROFESIONAL) REFERENCES VARIETE_GDD.PROFESIONAL(PRO_DNI);
ALTER TABLE VARIETE_GDD.TURNOS ADD FOREIGN KEY (TUR_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);

--//CONSULTA
ALTER TABLE VARIETE_GDD.CONSULTA ADD PRIMARY KEY (CON_CODIGO);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_PROFESIONAL) REFERENCES VARIETE_GDD.PROFESIONAL(PRO_DNI);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_TURNOS) REFERENCES VARIETE_GDD.TURNOS(TUR_CODIGO);

--//BONO_CONSULTA
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD PRIMARY KEY (BONCON_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_CONSULTA) REFERENCES VARIETE_GDD.CONSULTA(CON_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_PLAN) REFERENCES VARIETE_GDD.PLANES(PLA_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_COMPRA) REFERENCES VARIETE_GDD.COMPRA(COM_CODIGO);

--//BONO_FARMACIA
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD PRIMARY KEY (BONFAR_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD FOREIGN KEY (BONFAR_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD FOREIGN KEY (BONFAR_PLAN) REFERENCES VARIETE_GDD.PLANES(PLA_CODIGO);

--//RECETA
ALTER TABLE VARIETE_GDD.RECETA ADD PRIMARY KEY (REC_CODIGO);
ALTER TABLE VARIETE_GDD.RECETA ADD FOREIGN KEY (REC_BONFAR) REFERENCES VARIETE_GDD.BONO_FARMACIA(BONFAR_CODIGO);

--//RECETA_MEDICAMENTOS
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS ADD PRIMARY KEY (RECMED_RECETA,RECMED_MEDICAMENTOS);
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS ADD FOREIGN KEY (RECMED_RECETA) REFERENCES VARIETE_GDD.RECETA(REC_CODIGO);
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS ADD FOREIGN KEY (RECMED_MEDICAMENTOS) REFERENCES VARIETE_GDD.MEDICAMENTOS(MED_CODIGO);

--//AGENDA
ALTER TABLE VARIETE_GDD.AGENDA ADD PRIMARY KEY (AGE_CODIGO);
ALTER TABLE VARIETE_GDD.AGENDA ADD FOREIGN KEY (AGE_PROFESIONAL) REFERENCES VARIETE_GDD.PROFESIONAL(PRO_DNI);

--//DIAS_ATENCION
--ALTER TABLE VARIETE_GDD.DIAS_ATENCION ADD PRIMARY KEY (DIAATE_CODIGO);
--ALTER TABLE VARIETE_GDD.DIAS_ATENCION ADD FOREIGN KEY (DIAATE_AGENDA) REFERENCES VARIETE_GDD.AGENDA(AGE_CODIGO);

--//PLANES_MODIFICADOS
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS ADD PRIMARY KEY (PLAMOD_CODIGO);
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS ADD FOREIGN KEY (PLAMOD_PLAN_NUEVO) REFERENCES VARIETE_GDD.PLANES(PLA_CODIGO);
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS ADD FOREIGN KEY (PLAMOD_PLAN_VIEJO) REFERENCES VARIETE_GDD.PLANES(PLA_CODIGO);
ALTER TABLE VARIETE_GDD.PLANES_MODIFICADOS ADD FOREIGN KEY (PLAMOD_AFILIADO) REFERENCES VARIETE_GDD.AFILIADO(AFI_DNI);

--//CANCELACION_TURNO
ALTER TABLE VARIETE_GDD.CANCELACION_TURNO ADD PRIMARY KEY (CANTUR_CODIGO);
ALTER TABLE VARIETE_GDD.CANCELACION_TURNO ADD FOREIGN KEY (CANTUR_TURNO) REFERENCES VARIETE_GDD.TURNO(TUR_CODIGO);


COMMIT TRANSACTION

--// MIGRACION

--// USUARIO, AFILIADO
	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME, USU_CLAVE, USU_DNI, USU_NOMBRES, USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	SELECT DISTINCT Paciente_Mail, 
					Paciente_Dni, 
					Paciente_Dni, 
					Paciente_Nombre, 
					Paciente_Apellido,	
					Paciente_Direccion, 
					Paciente_Telefono, 
					Paciente_Mail,	
					Paciente_Fecha_Nac 
	FROM  gd_esquema.Maestra
	WHERE Paciente_Dni IS NOT NULL	

--// USUARIO, PROFESIONAL

	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME, USU_CLAVE, USU_DNI, USU_NOMBRES, USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	SELECT DISTINCT Medico_Mail, 
					Medico_Dni, 
					Medico_Dni, 
					Medico_Nombre, 
					Medico_Apellido, 
					Medico_Direccion, 
					Medico_Telefono, 
					Medico_Mail,
					Medico_Fecha_Nac
	FROM  gd_esquema.Maestra
	WHERE Medico_Dni IS NOT NULL
	
--// USUARIO, ADMINISTRADOR	

	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME,USU_CLAVE,USU_DNI,USU_NOMBRES,USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	VALUES 	('admin','w23e',NULL,NULL,NULL,NULL,NULL,NULL,NULL)

--// AFILIADO

	INSERT INTO [VARIETE_GDD].[AFILIADO] (AFI_DNI, AFI_PLAN_MEDICO) 
	SELECT DISTINCT Paciente_Dni, 
					Plan_Med_Codigo 
	FROM gd_esquema.Maestra
	WHERE Paciente_Dni IS NOT NULL
	
--// PROFESIONAL

	INSERT INTO [VARIETE_GDD].[PROFESIONAL] (PRO_DNI) 
	SELECT DISTINCT Medico_Dni
	FROM gd_esquema.Maestra
	WHERE Medico_Dni IS NOT NULL

--// ROL
	INSERT INTO [VARIETE_GDD].[ROL] (ROL_NOMBRE,ROL_HABILITADO) 
	VALUES ('ADMINISTRADOR','1'),
		   ('AFILIADO','1'),
		   ('PROFESIONAL','1')
		   
--// ROL_USUARIO, ADMINISTRADOR

	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ('admin','ADMINISTRADOR')
	
--// ROL_USUARIO, PROFESIONAL

	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ((SELECT DISTINCT Medico_Dni FROM gd_esquema.Maestra WHERE Medico_Dni IS NOT NULL),'PROFESIONAL')

--// ROL_USUARIO, AFILIADO

	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ((SELECT DISTINCT Paciente_Dni FROM gd_esquema.Maestra WHERE Paciente_Dni IS NOT NULL),'AFILIADO')
	

--// FUNCIONALIDADES

	SET IDENTITY_INSERT VARIETE_GDD.FUNCIONALIDADES ON


	INSERT INTO [VARIETE_GDD].[FUNCIONALIDADES] (FUN_CODIGO,FUN_DESCRIPCION) 
	VALUES 	('1','Abm de Rol'), 
			('2','Registro de Usuario'), 
			('3','Abm Afiliado'), 
			('4','Abm Profesional'), 
			('5','Abm Especialidades M�dicas'), 
			('6','Abm de Plan'), 
			('7','Registrar AGENDA Profesional'), 
			('8','Compra de bonos'), 
			('9','Pedido de turno'), 
			('10','Registro de llegada para atenci�n m�dica'), 
			('11','Registro de resultado para atenci�n m�dica'), 
			('12','Cancelar atenci�n m�dica'), 
			('13','Generar Receta'), 
			('14','Listado estad�stico')
	
	SET IDENTITY_INSERT VARIETE_GDD.FUNCIONALIDADES OFF

--// ROL_FUNCIONALIDADES

	INSERT INTO [VARIETE_GDD].[ROL_FUNCIONALIDADES] (ROLFUN_ROL,ROLFUN_FUNCIONALIDAD) 
	VALUES 	('ADMINISTRADOR','1'), 
			('ADMINISTRADOR','2'), 
			('ADMINISTRADOR','3'), 
			('ADMINISTRADOR','4'), 
			('ADMINISTRADOR','5'), 
			('ADMINISTRADOR','6'), 
			('ADMINISTRADOR','7'), 
			('ADMINISTRADOR','8'), 
			('ADMINISTRADOR','9'),
			('ADMINISTRADOR','10'),
			('ADMINISTRADOR','11'), 
			('ADMINISTRADOR','12'), 
			('ADMINISTRADOR','13'), 
			('ADMINISTRADOR','14'), 
			('AFILIADO','8'), 
			('AFILIADO','9'), 
			('AFILIADO','12'), 
			('AFILIADO','3'),
			('PROFESIONAL','10'), 
			('PROFESIONAL','5'), 
			('PROFESIONAL','7'),
			('PROFESIONAL','12'), 
			('PROFESIONAL','13')

--// PLANES

	SET IDENTITY_INSERT VARIETE_GDD.PLANES ON

	INSERT INTO [VARIETE_GDD].[PLANES] (PLA_CODIGO,PLA_DESCRIPCION,PLA_PRECIO_BONO_FARMACIA,PLA_PRECIO_BONO_CONSULTA) 
	SELECT DISTINCT Plan_Med_Codigo, 
					Plan_Med_Descripcion, 
					Plan_Med_Precio_Bono_Farmacia, 
					Plan_Med_Precio_Bono_Consulta
	FROM gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL
	
	SET IDENTITY_INSERT VARIETE_GDD.PLANES OFF

--// ESPECIALIDADES

	SET IDENTITY_INSERT VARIETE_GDD.ESPECIALIDADES ON

	INSERT INTO [VARIETE_GDD].[ESPECIALIDADES] (ESP_CODIGO,ESP_DESCRIPCION,ESP_TIPO,ESP_TIPO_DESCRIPCION) 
	SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL
	
	SET IDENTITY_INSERT VARIETE_GDD.ESPECIALIDADES OFF

	
--// PROFESIONAL_ESPECIALIDADES

	INSERT INTO [VARIETE_GDD].[PROFESIONAL_ESPECIALIDADES] (PROESP_PROFESIONAL,PROESP_ESPECIALIDAD) 
	SELECT DISTINCT PRO_DNI,ESP_CODIGO
	FROM VARIETE_GDD.PROFESIONAL JOIN gd_esquema.Maestra ON Medico_Dni=PRO_DNI 
								 JOIN VARIETE_GDD.ESPECIALIDADES ON Especialidad_Codigo=ESP_CODIGO 
	WHERE Especialidad_Codigo IS NOT NULL AND Medico_Dni IS NOT NULL

--// TURNOS

	SET IDENTITY_INSERT VARIETE_GDD.TURNOS ON

	INSERT INTO [VARIETE_GDD].[TURNOS] (TUR_CODIGO,TUR_PROFESIONAL,TUR_AFILIADO,TUR_FECHA) 
	SELECT DISTINCT M.Turno_Numero,PRO_DNI,AFI_DNI,M.Turno_Fecha
	FROM VARIETE_GDD.PROFESIONAL JOIN gd_esquema.Maestra M ON Medico_Dni=PRO_DNI
								 JOIN VARIETE_GDD.AFILIADO ON Paciente_Dni=AFI_DNI
	WHERE M.Turno_Numero IS NOT NULL AND Medico_Dni IS NOT NULL AND Paciente_Dni IS NOT NULL
	
	SET IDENTITY_INSERT VARIETE_GDD.TURNOS OFF		

--// COMPRAS

	INSERT INTO [VARIETE_GDD].[COMPRA] (COM_FECHA,COM_CANTIDAD_BONO_FARMACIA,COM_CANTIDAD_BONO_CONSULTA,COM_PRECIO,COM_AFILIADO) 
	SELECT M.Compra_Bono_Fecha,
		  (CASE WHEN Bono_Farmacia_Numero IS NOT NULL THEN 1 ELSE 0 END),
		  (CASE WHEN Bono_Consulta_Numero IS NOT NULL THEN 1 ELSE 0 END),
		  (CASE WHEN Bono_Farmacia_Numero IS NOT NULL THEN M.Plan_Med_Precio_Bono_Farmacia ELSE M.Plan_Med_Precio_Bono_Consulta END),
		  AFI_DNI
	FROM  gd_esquema.Maestra M JOIN VARIETE_GDD.AFILIADO ON M.Paciente_Dni=AFI_DNI
							   JOIN VARIETE_GDD.PLANES ON M.Plan_Med_Codigo=PLA_CODIGO 
	WHERE Compra_Bono_Fecha IS NOT NULL  

--// BONO CONSULTA

	SET IDENTITY_INSERT VARIETE_GDD.BONO_CONSULTA ON

	INSERT INTO [VARIETE_GDD].BONO_CONSULTA(BONCON_CODIGO ,BONCON_AFILIADO ,BONCON_CONSULTA,BONCON_FECHA ,BONCON_PLAN, BONCON_COMPRA)
	SELECT DISTINCT M.Bono_Consulta_Numero,
					(SELECT TOP 1 CB.COM_AFILIADO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni),
					M.Bono_Consulta_Numero,
					M.Bono_Consulta_Fecha_Impresion, 
					M.Plan_Med_Codigo,
					(SELECT TOP 1 CB.COM_CODIGO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni)
	FROM gd_esquema.Maestra M 
	WHERE M.Bono_Consulta_Numero IS NOT NULL AND M.Compra_Bono_Fecha IS NOT NULL 
	 	 
	SET IDENTITY_INSERT THE_SHIRE.Bonos_Consulta OFF
	
--// BONO FARMACIA

	SET IDENTITY_INSERT VARIETE_GDD.BONO_FARMACIA ON
	
	INSERT INTO [VARIETE_GDD].[BONO_FARMACIA](BONFAR_CODIGO,BONFAR_AFILIADO ,BONFAR_FECHA ,BONFAR_PLAN)
	SELECT DISTINCT M.Bono_Farmacia_Numero,
					(SELECT TOP 1 CB.COM_AFILIADO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni),
					M.Bono_Farmacia_Fecha_Impresion, 
					M.Plan_Med_Codigo
	FROM gd_esquema.Maestra M 
	WHERE M.Bono_Farmacia_Numero IS NOT NULL AND M.Compra_Bono_Fecha IS NOT NULL 
	
	SET IDENTITY_INSERT VARIETE_GDD.BONO_FARMACIA OFF

--// CONSULTA

	INSERT INTO [VARIETE_GDD].[CONSULTA](CON_PROFESIONAL,CON_AFILIADO ,CON_TURNOS ,CON_FECHA_LLEGADA,CON_SINTOMAS,CON_DIAGNOSTICO,CON_BONO_CONSULTA)
	SELECT DISTINCT PRO_DNI, 
					AFI_DNI,
					TUR_CODIGO,
					M.Turno_Fecha,
					M.Consulta_Sintomas,
					M.Consulta_Enfermedades,
					BONCON_CODIGO
	FROM gd_esquema.Maestra M JOIN VARIETE_GDD.AFILIADO ON AFI_DNI=M.Paciente_Dni
							  JOIN VARIETE_GDD.PROFESIONAL ON PRO_DNI=M.Medico_Dni
							  JOIN VARIETE_GDD.BONO_CONSULTA ON BONCON_CODIGO=M.Bono_Consulta_Numero
							  JOIN VARIETE_GDD.TURNOS ON TUR_CODIGO=M.Turno_Numero
		
	WHERE M.Turno_Numero IS NOT NULL AND M.Paciente_Dni IS NOT NULL AND M.Medico_Dni IS NOT NULL AND M.Bono_Consulta_Numero IS NOT NULL
	
--// RECETA

	INSERT INTO [VARIETE_GDD].[RECETA](REC_BONFAR) 
	SELECT DISTINCT BONFAR_CODIGO					
	FROM gd_esquema.Maestra M JOIN VARIETE_GDD.BONO_FARMACIA ON BONFAR_CODIGO=M.Bono_Farmacia_Numero
	WHERE M.Bono_Farmacia_Numero IS NOT NULL 

--// MEDICAMENTOS

	INSERT INTO [VARIETE_GDD].[MEDICAMENTOS](MED_NOMBRE) 
	SELECT DISTINCT M.Bono_Farmacia_Medicamento					
	FROM gd_esquema.Maestra M 
	WHERE M.Bono_Farmacia_Medicamento IS NOT NULL 

--// RECETA_MEDICAMENTOS

	INSERT INTO [VARIETE_GDD].[RECETA_MEDICAMENTOS](RECMED_RECETA,RECMED_MEDICAMENTOS) 
	SELECT DISTINCT REC_CODIGO,
					MED_CODIGO										
	FROM gd_esquema.Maestra M JOIN VARIETE_GDD.BONO_FARMACIA ON BONFAR_CODIGO=M.Bono_Farmacia_Numero
    						  JOIN VARIETE_GDD.RECETA ON REC_BONFAR=BONFAR_CODIGO
							  JOIN VARIETE_GDD.MEDICAMENTOS ON M.Bono_Farmacia_Medicamento=MED_NOMBRE 
	WHERE M.Bono_Farmacia_Medicamento IS NOT NULL AND BONFAR_CODIGO IS NOT NULL
	GROUP BY REC_CODIGO,MED_CODIGO,M.Bono_Farmacia_Medicamento



--// AGENDA

	INSERT INTO [VARIETE_GDD].[AGENDA](AGE_PROFESIONAL,AGE_FECHA_INICIO,AGE_FECHA_FIN) 
	SELECT DISTINCT PRO_DNI,
					AGE_FECHA_INICIO= MIN(DISTINCT M.Turno_Fecha),
					AGE_FECHA_FIN= MAX(DISTINCT M.Turno_Fecha)															
	FROM gd_esquema.Maestra M JOIN VARIETE_GDD.PROFESIONAL ON PRO_DNI=M.Medico_Dni
	WHERE M.Medico_Dni IS NOT NULL 
	GROUP BY PRO_DNI, DATEPART(DAYOFYEAR,M.Turno_fecha)
GO	

--// DIAS ATENCION
	
--	INSERT INTO [VARIETE_GDD].[DIAS_ATENCION](DIAATE_DIA,DIAATE_HORARIO_INICIO,DIAATE_HORARIO_FIN,DIAATE_FECHA,DIAATE_AGENDA) 
--	SELECT DISTINCT (SELECT ),
--					DIAATE_HORARIO_INICIO=MIN(DISTINCT DATEPART(HH,M.Turno_Fecha)),
--					DIAATE_HORARIO_FIN=MAX(DISTINCT DATEPART(HH,M.Turno_Fecha)),
--					AGE_CODIGO									
--	FROM gd_esquema.Maestra M JOIN VARIETE_GDD.PROFESIONAL ON PRO_DNI=M.Medico_Dni
--							  JOIN VARIETE_GDD.AGENDA ON AGE_PROFESIONAL=PRO_DNI
--	WHERE M.Medico_Dni IS NOT NULL 
--	GROUP BY AGE_CODIGO
	

-- // TRIGGERS

-- CREACION DE TRIGGER SOBRE TABLA RECETA
-- NO SE PUEDE MODIFICAR O ELIMINAR UNA VEZ QUE FUE CREADA

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'TRIGGER_RECETA' AND xtype = 'TR')
	DROP TRIGGER  VARIETE_GDD.TRIGGER_RECETA;
GO

CREATE TRIGGER VARIETE_GDD.TRIGGER_RECETA
	ON [VARIETE_GDD].[RECETA]
	INSTEAD OF UPDATE,DELETE
	AS	
		BEGIN TRANSACTION
		ROLLBACK

GO


