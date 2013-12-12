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

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.DIAATE_AGENDA') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE VARIETE_GDD.DIAS_ATENCION DROP CONSTRAINT DIAATE_AGENDA;

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

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.DIAS_ATENCION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.DIAS_ATENCION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.AFILIADO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.AFILIADO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('VARIETE_GDD.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE VARIETE_GDD.USUARIO;

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

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('VARIETE_GDD.DIAS_ATENCION') AND type in (N'P', N'PC'))
DROP PROCEDURE VARIETE_GDD.DIAS_ATENCION;
GO


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

CREATE TABLE VARIETE_GDD.AFILIADO ( 
	AFI_NUMERO INTEGER IDENTITY (1,1) NOT NULL,
	AFI_GRUPO INTEGER DEFAULT '01',
	AFI_DNI NUMERIC(8) UNIQUE NOT NULL,
	AFI_ESTADO_CIVIL VARCHAR(11) DEFAULT 'N',
	AFI_CANTIDAD_FAMILIARES INTEGER DEFAULT '0',
	AFI_PLAN_MEDICO NUMERIC(18) NOT NULL,
	AFI_CANTIDAD_CONSULTAS INTEGER DEFAULT '0'	
)

CREATE TABLE VARIETE_GDD.PROFESIONAL ( 
	PRO_DNI NUMERIC(8) UNIQUE NOT NULL,
	PRO_MATRICULA VARCHAR(50) DEFAULT '000'
)

CREATE TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES (
	PROESP_PROFESIONAL NUMERIC(8) NOT NULL,
	PROESP_ESPECIALIDAD INTEGER NOT NULL
)

CREATE TABLE VARIETE_GDD.ESPECIALIDADES (
	ESP_CODIGO INTEGER UNIQUE NOT NULL,
	ESP_DESCRIPCION VARCHAR (255),
	ESP_TIPO VARCHAR(80),
	ESP_TIPO_DESCRIPCION VARCHAR (255)
)



CREATE TABLE VARIETE_GDD.ROL_USUARIO (
	ROLUSU_USUARIO NUMERIC(8) NOT NULL,
	ROLUSU_ROL VARCHAR (15) NOT NULL
)

CREATE TABLE VARIETE_GDD.ROL (
	ROL_NOMBRE VARCHAR (15) UNIQUE NOT NULL, --AFILIADO O PROFESIONAL O ADMINISTRADOR
	ROL_HABILITADO BIT NOT NULL
)

CREATE TABLE VARIETE_GDD.ROL_FUNCIONALIDADES (
	ROLFUN_ROL VARCHAR (15) UNIQUE NOT NULL,
	ROLFUN_FUNCIONALIDAD INTEGER NOT NULL
)	

CREATE TABLE VARIETE_GDD.FUNCIONALIDADES (
	FUN_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	FUN_DESCRIPCION VARCHAR(80) NOT NULL
)

CREATE TABLE VARIETE_GDD.TURNOS (
	TUR_CODIGO INTEGER NOT NULL,
	TUR_PROFESIONAL NUMERIC(8) NOT NULL,
	TUR_AFILIADO NUMERIC(8) NOT NULL,
	TUR_FECHA DATETIME NOT NULL
)	

CREATE TABLE VARIETE_GDD.BONO_CONSULTA (
	BONCON_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	BONCON_AFILIADO NUMERIC(8) NOT NULL,
	BONCON_CONSULTA INTEGER NOT NULL,
	BONCON_FECHA DATETIME NOT NULL,
	BONCON_PLAN NUMERIC(18) NOT NULL,
	BONCON_COMPRA INTEGER NOT NULL
)

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

CREATE TABLE VARIETE_GDD.BONO_FARMACIA (
	BONFAR_CODIGO INTEGER NOT NULL,
	BONFAR_AFILIADO NUMERIC(8) NOT NULL,
	BONFAR_FECHA DATETIME NOT NULL,
	BONFAR_PLAN NUMERIC(18) NOT NULL 
)

CREATE TABLE VARIETE_GDD.RECETA (
	REC_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	REC_BONFAR INTEGER NOT NULL  
)

CREATE TABLE VARIETE_GDD.RECETA_MEDICAMENTOS (
	RECMED_RECETA INTEGER NOT NULL,
	RECMED_MEDICAMENTOS INTEGER NOT NULL,
	RECMED_CANTIDAD INTEGER DEFAULT '1'
)

CREATE TABLE VARIETE_GDD.MEDICAMENTOS (
	MED_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	MED_NOMBRE VARCHAR(255)
)

CREATE TABLE VARIETE_GDD.PLANES (
	PLA_CODIGO NUMERIC(18) NOT NULL,
	PLA_DESCRIPCION VARCHAR(255),
	PLA_PRECIO_BONO_FARMACIA NUMERIC(18) DEFAULT '0',
	PLA_PRECIO_BONO_CONSULTA NUMERIC (18) DEFAULT '0'	
)

CREATE TABLE VARIETE_GDD.COMPRA (
	COM_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	COM_FECHA DATETIME,
	COM_CANTIDAD_BONO_FARMACIA INTEGER, 
	COM_CANTIDAD_BONO_CONSULTA INTEGER,  
	COM_PRECIO FLOAT,
	COM_AFILIADO NUMERIC(8) NOT NULL	
)	

CREATE TABLE VARIETE_GDD.AGENDA(
	AGE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	AGE_PROFESIONAL NUMERIC(8) NOT NULL,
	AGE_FECHA_INICIO DATETIME DEFAULT NULL,
	AGE_FECHA_FIN DATETIME DEFAULT NULL
)

CREATE TABLE VARIETE_GDD.DIAS_ATENCION(
	DIAATE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
    DIAATE_DIA CHAR (2) NOT NULL,
    DIAATE_HORARIO_INICIO DATETIME,
    DIAATE_HORARIO_FIN DATETIME,
    DIAATE_FECHA DATETIME,
    DIAATE_AGENDA INTEGER NOT NULL
)
               
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
ALTER TABLE VARIETE_GDD.DIAS_ATENCION ADD PRIMARY KEY (DIAATE_CODIGO);
ALTER TABLE VARIETE_GDD.DIAS_ATENCION ADD FOREIGN KEY (DIAATE_AGENDA) REFERENCES VARIETE_GDD.AGENDA(AGE_CODIGO);

COMMIT TRANSACTION

GO
 --STORED PRODECURES (MIGRACION E INSERTS)
 
--**MIGRA AFILIADOS (TABLAS USUARIO, ROL_USUARIO, AFILIADOS)
--Para Afiliados y Profesionales
--username: email
--pass: dni
CREATE PROCEDURE VARIETE_GDD.MIGRA_AFILIADOS
AS
BEGIN
	
	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME, USU_CLAVE, USU_DNI, USU_NOMBRES, USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	SELECT DISTINCT Paciente_Mail, Paciente_Dni, Paciente_Dni, Paciente_Nombre, Paciente_Apellido,	Paciente_Direccion, Paciente_Telefono, Paciente_Mail,	Paciente_Fecha_Nac 
	FROM  gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL	 
	
	SELECT DISTINCT Paciente_Dni, Plan_Med_Codigo 
	INTO [VARIETE_GDD].[AFILIADO]
	FROM gd_esquema.Maestra
	WHERE Paciente_Dni IS NOT NULL

	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ((SELECT DISTINCT Paciente_Dni FROM gd_esquema.Maestra WHERE Paciente_Dni IS NOT NULL),'AFILIADO')	
END
GO

--**MIGRA PROFESIONALES (TABLAS USUARIO, ROL_USUARIO, PROFESIONAL)
--Para Afiliados y Profesionales
--username: email
--pass: dni

CREATE PROCEDURE VARIETE_GDD.MIGRA_PROFESIONALES
AS
BEGIN

	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME, USU_CLAVE, USU_DNI, USU_NOMBRES, USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	SELECT DISTINCT Medico_Mail, Medico_Dni, Medico_Dni, Medico_Nombre, Medico_Apellido, Medico_Direccion, Medico_Telefono, Medico_Mail,Medico_Fecha_Nac
	FROM  gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL	
	
	
	SELECT Medico_Dni
	INTO [VARIETE_GDD].[PROFESIONAL]
	FROM gd_esquema.Maestra
	WHERE Medico_Dni IS NOT NULL
	
	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ((SELECT DISTINCT Medico_Dni FROM gd_esquema.Maestra WHERE Medico_Dni IS NOT NULL),'PROFESIONAL')	

END
GO

--**MIGRA PLANES 
CREATE PROCEDURE VARIETE_GDD.MIGRA_PLANES
AS
BEGIN
	SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Farmacia, Plan_Med_Precio_Bono_Consulta
	INTO [VARIETE_GDD].[PLANES]
	FROM gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL
END
GO

--**MIGRA ESPECIALIDADES Y PROFESIONAL_ESPECIALIDADES
CREATE PROCEDURE VARIETE_GDD.MIGRA_ESPECIALIDADES
AS
BEGIN
	SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
	INTO [VARIETE_GDD].[ESPECIALIDADES]
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL
	
	SELECT DISTINCT Medico_Dni,Especialidad_Codigo
	INTO [VARIETE_GDD].[PROFESIONAL_ESPECIALIDADES]
	FROM gd_esquema.Maestra
	WHERE Especialidad_Codigo IS NOT NULL AND Medico_Dni IS NOT NULL
	
END
GO

--**MIGRA TURNOS
CREATE PROCEDURE VARIETE_GDD.MIGRA_TURNOS
AS
BEGIN
	SELECT Turno_Numero,Medico_Dni,Paciente_Dni, Turno_Fecha
	INTO [VARIETE_GDD].[TURNOS] 
	FROM gd_esquema.Maestra
END
GO

--**MIGRA COMPRA DE BONOS -- ARREGLAR!
CREATE PROCEDURE VARIETE_GDD.MIGRA_COMPRAS_BONOS
AS
BEGIN
	INSERT INTO [VARIETE_GDD].COMPRA (COM_FECHA , COM_CANTIDAD_BONO_FARMACIA , COM_CANTIDAD_BONO_CONSULTA , COM_PRECIO , COM_AFILIADO ) 
	SELECT Compra_Bono_Fecha, COUNT(Bono_Farmacia_Numero),COUNT( Bono_Consulta_Numero),SUM ( CASE WHEN Bono_Farmacia_Numero IS NOT NULL THEN Plan_Med_Precio_Bono_Farmacia ELSE 0 END + CASE WHEN Bono_Consulta_Numero IS NOT NULL THEN  Plan_Med_Precio_Bono_Consulta ELSE 0 END) , Paciente_Dni
	FROM  gd_esquema.Maestra
	WHERE Compra_Bono_Fecha IS NOT NULL  
	GROUP BY Paciente_Dni,Compra_Bono_Fecha	
END
GO

--**MIGRA BONO CONSULTA
CREATE PROCEDURE VARIETE_GDD.MIGRA_BONOS_CONSULTA
AS
BEGIN
	--SELECT Paciente_Dni, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion, Plan_Med_Codigo, (SELECT TOP 1 COM_CODIGO FROM [VARIETE_GDD].[COMPRA] WHERE COM_CODIGO = Compra_Bono_Fecha AND COM_AFILIADO = Paciente_Dni)
	--INTO [VARIETE_GDD].[BONO_CONSULTA]
	--FROM gd_esquema.Maestra
	--WHERE Bono_Consulta_Fecha_Impresion IS NOT NULL AND Bono_Consulta_Numero IS NOT NULL
	
	INSERT INTO [VARIETE_GDD].BONO_CONSULTA(BONCON_CODIGO ,BONCON_AFILIADO ,BONCON_CONSULTA,BONCON_FECHA ,BONCON_PLAN, BONCON_COMPRA)
SELECT DISTINCT M.Bono_Consulta_Numero,(SELECT TOP 1 CB.COM_AFILIADO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni),M.Bono_Consulta_Numero,M.Bono_Consulta_Fecha_Impresion, M.Plan_Med_Codigo,(SELECT TOP 1 CB.COM_CODIGO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni)
FROM gd_esquema.Maestra M 
WHERE M.Bono_Consulta_Numero IS NOT NULL AND M.Compra_Bono_Fecha IS NOT NULL 
ORDER BY M.Bono_Consulta_Numero
	 
END
GO

--**MIGRA BONO FARMACIA
CREATE PROCEDURE VARIETE_GDD.MIGRA_BONOS_FARMACIA
AS
BEGIN
	--SELECT Bono_Farmacia_Numero, Paciente_Dni, Bono_Farmacia_Fecha_Impresion, Plan_Med_Codigo
	--INTO [VARIETE_GDD].[BONO_FARMACIA]
	--FROM gd_esquema.Maestra
	--WHERE Bono_Farmacia_Numero IS NOT NULL AND Compra_Bono_Fecha IS NOT NULL
	
INSERT INTO [VARIETE_GDD].[BONO_FARMACIA](BONFAR_CODIGO,BONFAR_AFILIADO ,BONFAR_FECHA ,BONFAR_PLAN)
SELECT DISTINCT M.Bono_Farmacia_Numero,(SELECT TOP 1 CB.COM_AFILIADO FROM [VARIETE_GDD].COMPRA CB WHERE CB.COM_FECHA=M.Compra_Bono_Fecha AND CB.COM_AFILIADO=M.Paciente_Dni),M.Bono_Farmacia_Fecha_Impresion, M.Plan_Med_Codigo
FROM gd_esquema.Maestra M 
WHERE m.Bono_Farmacia_Numero IS NOT NULL AND m.Compra_Bono_Fecha IS NOT NULL 
ORDER BY Bono_Farmacia_Numero
	
END
GO

--** MIGRA CONSULTA
CREATE PROCEDURE VARIETE_GDD.MIGRA_CONSULTA
AS 
BEGIN
	SELECT DISTINCT Medico_Dni, Paciente_Dni,Turno_Numero,Turno_Fecha,Consulta_Sintomas,Consulta_Enfermedades,Bono_Consulta_Numero
	INTO[VARIETE_GDD].[CONSULTA]
	FROM gd_esquema.Maestra
	WHERE Turno_Numero IS NOT NULL AND (Consulta_Sintomas IS NOT NULL OR Consulta_Enfermedades IS NOT NULL)
END
GO



--** MIGRA MEDICAMENTOS
CREATE PROCEDURE VARIETE_GDD.MIGRA_MEDICAMENTOS
AS
BEGIN
	SELECT DISTINCT Bono_Farmacia_Medicamento
	INTO [VARIETE_GDD].[MEDICAMENTOS]
	FROM gd_esquema.Maestra
	WHERE Bono_Farmacia_Medicamento IS NOT NULL
END
GO

--** MIGRA RECETA Y RECETA_MEDICAMENTOS
CREATE PROCEDURE VARIETE_GDD.MIGRA_RECETA
AS
BEGIN
	SELECT DISTINCT Bono_Farmacia_Numero
	INTO [VARIETE_GDD].[MEDICAMENTOS]
	FROM gd_esquema.Maestra
	WHERE Bono_Farmacia_Medicamento IS NOT NULL
	
	SELECT DISTINCT Bono_Farmacia_Numero,Bono_Farmacia_Medicamento
	INTO [VARIETE_GDD].[RECETA_MEDICAMENTOS]
	FROM gd_esquema.Maestra
	WHERE Bono_Farmacia_Medicamento IS NOT NULL
	
END
GO

CREATE PROCEDURE VARIETE_GDD.INSERT_ROL
AS
BEGIN
	INSERT INTO [VARIETE_GDD].[ROL] (ROL_NOMBRE,ROL_HABILITADO) 
	VALUES ('ADMINISTRADOR','1'),
		   ('AFILIADO','1'),
		   ('PROFESIONAL','1')
END
GO

CREATE PROCEDURE VARIETE_GDD.INSERT_ROL_FUNCIONALIDADES
AS
BEGIN
	INSERT INTO [VARIETE_GDD].[ROL_FUNCIONALIDADES] (ROLFUN_ROL,ROLFUN_FUNCIONALIDAD) 
	VALUES 	('ADMINISTRADOR','Abm de Rol'), 
			('ADMINISTRADOR','Registro de Usuario'), 
			('ADMINISTRADOR','Abm Afiliado'), 
			('ADMINISTRADOR','Abm Profesional'), 
			('ADMINISTRADOR','Abm Especialidades M�dicas'), 
			('ADMINISTRADOR','Abm de Plan'), 
			('ADMINISTRADOR','Compra de bonos'), 
			('ADMINISTRADOR','Registro de llegada para atenci�n m�dica'), 
			('ADMINISTRADOR','Listado estad�stico'),
			('ADMINISTRADOR','Login y Seguridad'),
			('AFILIADO','Compra de bonos'), 
			('AFILIADO','Pedido de turno'), 
			('AFILIADO','Cancelar atenci�n m�dica'), 
			('AFILIADO','Login y Seguridad'),
			('AFILIADO','Abm Afiliado'), --solo puede modificar algunos de los campos
			('PROFESIONAL','Registro de resultado para atenci�n m�dica'), 
			('PROFESIONAL','Abm Especialidades M�dicas'), 
			('PROFESIONAL','Registrar Agenda Profesional'),
			('PROFESIONAL','Cancelar atenci�n m�dica'), 
			('PROFESIONAL','Generar Receta'),
			('PROFESIONAL','Login y Seguridad')
END
GO

CREATE PROCEDURE VARIETE_GDD.MIGRA_FUNCIONALIDADES
AS
BEGIN
	INSERT INTO [VARIETE_GDD].[FUNCIONALIDADES] (FUN_DESCRIPCION) 
	VALUES 	('Abm de Rol'), 
			('Registro de Usuario'), 
			('Abm Afiliado'), 
			('Abm Profesional'), 
			('Abm Especialidades M�dicas'), 
			('Abm de Plan'), 
			('Registrar Agenda Profesional'), 
			('Compra de bonos'), 
			('Pedido de turno'), 
			('Registro de llegada para atenci�n m�dica'), 
			('Registro de resultado para atenci�n m�dica'), 
			('Cancelar atenci�n m�dica'), 
			('Generar Receta'), 
			('Listado estad�stico')
END
GO

CREATE PROCEDURE VARIETE_GDD.ADMINISTRADOR
AS
BEGIN
	INSERT INTO [VARIETE_GDD].[USUARIO] (USU_USERNAME,USU_CLAVE,USU_DNI,USU_NOMBRES,USU_APELLIDO,USU_DIRECCION,USU_TELEFONO,USU_MAIL,USU_FECHA_NACIMIENTO) 
	VALUES 	('admin','w23e',NULL,NULL,NULL,NULL,NULL,NULL,NULL)
	
	
	INSERT INTO [VARIETE_GDD].[ROL_USUARIO] (ROLUSU_USUARIO,ROLUSU_ROL) 
	VALUES ('admin','ADMINISTRADOR')
END	
GO

CREATE PROCEDURE VARIETE_GDD.MIGRA_AGENDA
AS
BEGIN
	SELECT DISTINCT Medico_Dni
	INTO [VARIETE_GDD].[AGENDA]
	FROM gd_esquema.Maestra
	WHERE Medico_Dni IS NOT NULL

END
GO

--CREATE PROCEDURE VARIETE_GDD.DIAS_ATENCION
--AS
--BEGIN
--END
--GO

-- INSERT: DIAS_ATENCION


-- // TRIGGERS

-- CREACION DE TRIGGER SOBRE TABLA RECETA
-- NO SE PUEDE MODIFICAR O ELIMINAR UNA VEZ QUE FUE CREADA

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'TRIGGER_RECETA' AND xtype = 'TR')
	DROP TRIGGER  VARIETE_GDD.TRIGGER_RECETA;
GO

CREATE TRIGGER VARIETE_GDD.TRIGGER_RECETA
	ON VARIETE_GDD.RECETA
	INSTEAD OF UPDATE,DELETE
	AS	
		BEGIN TRANSACTION
		ROLLBACK

GO
