-- BASE DE DATOS UTILIZADA

USE GD2C2013
BEGIN TRANSACTION

-- CREACION DEL ESQUEMA

IF NOT EXISTS ( SELECT *
				FROM sys.schemas 
				WHERE name = N'VARIETE_GDD')  
EXEC ('CREATE SCHEMA [VARIETE_GDD] AUTHORIZATION [gd]');
GO

-- CREACION DE TABLAS

CREATE TABLE VARIETE_GDD.AFILIADO ( 
	AFI_NUMERO INTEGER IDENTITY(1,1) NOT NULL,
	AFI_DNI NUMERIC(8),
	AFI_ESTADO_CIVIL VARCHAR(11) DEFAULT 'N',
	AFI_CANTIDAD_FAMILIARES INTEGER DEFAULT '0',
	AFI_PLAN_MEDICO NUMERIC(18)	
)

CREATE TABLE VARIETE_GDD.PROFESIONAL ( 
	--PRO_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	PRO_DNI NUMERIC(8),
	PRO_MATRICULA VARCHAR(50) DEFAULT '000'
)

CREATE TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES (
	PROESP_PROFESIONAL INTEGER NOT NULL,
	PROESP_ESPECIALIDAD INTEGER NOT NULL
)

CREATE TABLE VARIETE_GDD.ESPECIALIDADES (
	ESP_CODIGO INTEGER NOT NULL,
	ESP_DESCRIPCION VARCHAR (255),
	ESP_TIPO VARCHAR(80),
	ESP_TIPO_DESCRIPCION VARCHAR (255)
)

--CREATE TABLE VARIETE_GDD.ADMINISTRADOR (
--	ADM_CODIGO INTEGER IDENTITY(1,1) NOT NULL
--)

CREATE TABLE VARIETE_GDD.USUARIO (
	USU_USERNAME VARCHAR(255) UNIQUE NOT NULL ,
	USU_CLAVE VARCHAR(255) NOT NULL,
	USU_CANTIDAD_INTENTOS INTEGER DEFAULT '0',
	USU_HABILITADO BIT DEFAULT '1',
	USU_TIPO_DOCUMENTO VARCHAR(3) DEFAULT 'DNI',
	USU_DNI NUMERIC(8),
	USU_NOMBRES VARCHAR(255),
	USU_APELLIDO VARCHAR(255),
	USU_DIRRECCION VARCHAR(255),
	USU_TELEFONO NUMERIC(18),
	USU_MAIL VARCHAR(255),
	USU_FECHA_NACIMIENTO DATETIME,
	USU_SEXO CHAR DEFAULT 'N', --'F' O 'M'
)

CREATE TABLE VARIETE_GDD.ROL_USUARIO (
	ROLUSU_USUARIO VARCHAR(255) NOT NULL,
	ROLUSU_ROL INTEGER NOT NULL
)

CREATE TABLE VARIETE_GDD.ROL (
	--ROL_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	ROL_NOMBRE VARCHAR (255) NOT NULL, --AFILIADO O PROFESIONAL O ADMINISTRADOR
	HABILITADO BIT NOT NULL
)

CREATE TABLE VARIETE_GDD.ROL_FUNCIONALIDADES (
	ROLFUN_ROL INTEGER NOT NULL,
	ROLFUN_FUNCIONALIDAD INTEGER NOT NULL
)	

CREATE TABLE VARIETE_GDD.FUNCIONALIDADES (
	FUN_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	FUN_DESCRIPCION VARCHAR(80) NOT NULL
)

CREATE TABLE VARIETE_GDD.TURNOS (
	TUR_CODIGO INTEGER NOT NULL,
	TUR_PROFESIONAL INTEGER NOT NULL,
	TUR_AFILIADO INTEGER NOT NULL,
	TUR_FECHA DATETIME NOT NULL
)	

CREATE TABLE VARIETE_GDD.BONO_CONSULTA (
	BONCON_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	BONCON_AFILIADO INTEGER NOT NULL,
	BONCON_CONSULTA INTEGER NOT NULL,
	BONCON_FECHA DATETIME NOT NULL,
	BONCON_PLAN INTEGER NOT NULL,
	BONCON_COMPRA INTEGER NOT NULL
)

CREATE TABLE VARIETE_GDD.CONSULTA (
	CON_CONSULTA INTEGER IDENTITY(1,1) NOT NULL,
	--SEGUN ENTENDI DEL ENUNCIADO EL ID CONSULTA DEBE VARIAR POR CADA AFILIADO
	--PORQUE INDICA LA CANTIDAD DE VECES QUE ESE AFILIADO FUE ATENDIDO
	--POR LO QUE EL IDENTITY ME PARECE QUE NO NOS SIRVE PARA ESTO
--	Por su parte, los bonos consulta tienen un 
--campo �numero de consulta�, propio de cada afiliado, el mismo es completado en el 
--momento que se efectiviza la consulta m�dica en forma parcial (cuando el afiliado 
--registra su llegada a la atenci�n) que indica la cantidad de veces que el afiliado hizo una 
--consulta m�dica independientemente del especialista que lo atiende.
	CON_PROFESIONAL INTEGER NOT NULL, 
	CON_AFILIADO INTEGER NOT NULL,
	CON_TURNOS INTEGER NOT NULL,
	CON_FECHA_LLEGADA DATETIME,
	CON_SINTOMAS VARCHAR(255),
	CON_DIAGNOSTICO VARCHAR(1000),
	CON_BONO_CONSULTA INTEGER NOT NULL,
	CON_REALIZADA BIT
)

CREATE TABLE VARIETE_GDD.BONO_FARMACIA (
	--BONFAR_CODIGO INTEGER IDENTITY(1,1) NOT NULL,   YA VIENEN ALGUNOS
	--------------------------BUSCAR LA FORMA DE TOMAR EL ULTIMO E IR AUMENTANDO EN LAS NUEVAS INSERCIONES
	BONFAR_CODIGO INTEGER NOT NULL,
	BONFAR_AFILIADO INTEGER NOT NULL,
	BONFAR_FECHA DATETIME NOT NULL,
	--BONFAR_RECETA INTEGER, --> ESTE NO VA, LA RECETA HACE REFERENCIA AL BONO FARMACIA (DISCUTIBLE)
	--BONFAR_FECHA_VENCIMIENTO DATETIME?? ES CALCULABLE 
	-->RESPUESTA: SI ES CALCULABLE NO DEBERIA FIGURAR EN LA TABLA
	BONCON_PLAN INTEGER NOT NULL 
)

--A un bono farmacia le corresponde un bono receta
--Una receta es un conjunto de 5 medicamentos
CREATE TABLE VARIETE_GDD.RECETA (
	REC_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	REC_BONFAR INTEGER NOT NULL  --YA ES MUY TARDE Y PUEDE SER QUE ESTE MANDANDO FRUTA
)

CREATE TABLE VARIETE_GDD.RECETA_MEDICAMENTOS (
	RECMED_RECETA INTEGER NOT NULL,
	RECMED_MEDICAMENTOS INTEGER NOT NULL,
	RECMED_CANTIDAD INTEGER
)

CREATE TABLE VARIETE_GDD.MEDICAMENTOS (
	MED_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	MED_NOMBRE VARCHAR(255)
)

CREATE TABLE VARIETE_GDD.PLANES (
	PLA_CODIGO NUMERIC(18) NOT NULL,
	PLA_DESCRIPCION VARCHAR(255),
	PLA_PRECIO_BONO_FARMACIA NUMERIC(18),
	PLA_PRECIO_BONO_CONSULTA NUMERIC (18)	
)

CREATE TABLE VARIETE_GDD.COMPRA (
	COM_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	COM_FECHA DATETIME,
	COM_CANTIDAD_BONO_FARMACIA INTEGER, --RELACIONA CON BONO_FARMACIA (FK)
	COM_CANTIDAD_BONO_CONSULTA INTEGER, --RELACIONA CON BONO_FARMACIA (FK)
	COM_PRECIO FLOAT,
	COM_AFILIADO INTEGER	
)	

--El per�odo para la confecci�n de la agenda de un profesional no puede ser superior 
--a los 120 d�as corridos.
CREATE TABLE VARIETE_GDD.AGENDA(
	AGE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
	AGE_PROFESIONAL INTEGER NOT NULL,
	AGE_FECHA_INICIO DATETIME,
	AGE_FECHA_FIN DATETIME
)

CREATE TABLE VARIETE_GDD.DIAS_ATENCION(
	DIAATE_CODIGO INTEGER IDENTITY(1,1) NOT NULL,
    DIAATE_DIA CHAR (1) NOT NULL,
    DIAATE_HORARIO_INICIO DATETIME,
    DIAATE_HORARIO_FIN DATETIME,
    DIAATE_FECHA DATETIME,
    DIAATE_AGENDA INTEGER NOT NULL
)
               
        
--NO ESTOY SEGURA SI ESTA BIEN LA PARTE DE LA AGENDA, ES NA RELACION MUCHOS MUCHO ENTRE LOS DIAS_ATENCION Y LA AGENDA?
-->RESPUESTA: PARA MI SI ES UNA RELACION MUCHOS A MUCHOS

--FALTA CREAR TABLA  FORMULARIO Y ELEMENTOS


--CONSTRAINTS (PK Y FK)

--//AFILIADO
ALTER TABLE VARIETE_GDD.AFILIADO ADD PRIMARY KEY (AFI_DNI);
ALTER TABLE VARIETE_GDD.PROFESIONAL ADD FOREIGN KEY (AFI_DNI) REFERENCES USUARIO(USU_DNI);
ALTER TABLE VARIETE_GDD.AFILIADO ADD FOREIGN KEY (AFI_PLAN_MEDICO) REFERENCES PLANES(PLA_CODIGO);

--//PROFESIONAL	
ALTER TABLE VARIETE_GDD.PROFESIONAL ADD PRIMARY KEY (PRO_DNI);
ALTER TABLE VARIETE_GDD.PROFESIONAL ADD FOREIGN KEY (PRO_DNI) REFERENCES USUARIO(USU_DNI);

--//PROFESIONAL_ESPECIALIDADES
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD PRIMARY KEY (PROESP_PROFESIONAL,PROESP_ESPECIALIDAD);
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD FOREIGN KEY (PROESP_PROFESIONAL) REFERENCES PROFESIONAL(PRO_CODIGO);
ALTER TABLE VARIETE_GDD.PROFESIONAL_ESPECIALIDADES ADD FOREIGN KEY (PROESP_ESPECIALIDAD) REFERENCES ESPECIALIDADES(ESP_CODIGO);

--//ESPECIALIDADES
ALTER TABLE VARIETE_GDD.ESPECIALIDADES ADD PRIMARY KEY (ESP_CODIGO);

--//ADMINISTRADOR
--ALTER TABLE VARIETE_GDD.ADMINISTRADOR ADD PRIMARY KEY (ADM_CODIGO);

--//USUARIO
ALTER TABLE VARIETE_GDD.USUARIO ADD PRIMARY KEY (USU_DNI);

--//ROL_USUARIO
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD PRIMARY KEY (ROLUSU_USUARIO,ROLUSU_ROL);
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD FOREIGN KEY (ROLUSU_USUARIO) REFERENCES USUARIO(USU_USERNAME);
ALTER TABLE VARIETE_GDD.ROL_USUARIO ADD FOREIGN KEY (ROLUSU_ROL) REFERENCES ROL(ROL_CODIGO);


--//ROL
ALTER TABLE VARIETE_GDD.ROL ADD PRIMARY KEY (ROL_NOMBRE);

--//ROL_FUNCIONALIDADES
ALTER TABLE VARIETE_GDD.ROL_FUNCIONALIDADES ADD PRIMARY KEY (ROLFUN_ROL,ROLFUN_FUNCIONALIDAD);
ALTER TABLE VARIETE_GDD.AFILIADO ADD FOREIGN KEY (ROLFUN_ROL) REFERENCES ROL(ROL_CODIGO);
ALTER TABLE VARIETE_GDD.AFILIADO ADD FOREIGN KEY (ROLFUN_FUNCIONALIDAD) REFERENCES FUNCIONALIDADES(FUN_CODIGO);

--//FUNCIONALIDADES
ALTER TABLE VARIETE_GDD.FUNCIONALIDADES ADD PRIMARY KEY (FUN_TIPO);

--//TURNOS
ALTER TABLE VARIETE_GDD.TURNOS ADD PRIMARY KEY (TUR_CODIGO);
ALTER TABLE VARIETE_GDD.TURNOS ADD FOREIGN KEY (TUR_PROFESIONAL) REFERENCES PROFESIONAL(USU_DNI);
ALTER TABLE VARIETE_GDD.TURNOS ADD FOREIGN KEY (TUR_AFILIADO) REFERENCES AFILIADO(USU_DNI);


--//BONO_CONSULTA
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD PRIMARY KEY (BONCON_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_AFILIADO) REFERENCES AFILIADO(AFI_DNI);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_CONSULTA) REFERENCES CONSULTA(CON_CONSULTA);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_PLAN) REFERENCES PLANES(PLA_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_CONSULTA ADD FOREIGN KEY (BONCON_COMPRA) REFERENCES COMPRA(COM_CODIGO);

	
--//CONSULTA
ALTER TABLE VARIETE_GDD.CONSULTA ADD PRIMARY KEY (CON_CONSULTA);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_PROFESIONAL) REFERENCES PROFESIONAL(PRO_CODIGO);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_AFILIADO) REFERENCES AFILIADO(AFI_NUMERO);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_TURNOS) REFERENCES TURNOS(TUR_CODIGO);
ALTER TABLE VARIETE_GDD.CONSULTA ADD FOREIGN KEY (CON_BONO_CONSULTA) REFERENCES BONO_CONSULTA(BONCON_CODIGO);


--//BONO_FARMACIA
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD PRIMARY KEY (BONFAR_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD FOREIGN KEY (BONFAR_AFILIADO) REFERENCES AFILIADO(AFI_DNI);
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD FOREIGN KEY (BONFAR_RECETA) REFERENCES RECETA(REC_CODIGO);
ALTER TABLE VARIETE_GDD.BONO_FARMACIA ADD FOREIGN KEY (BONFAR_PLAN) REFERENCES PLANES(PLA_CODIGO);


--//RECETA
ALTER TABLE VARIETE_GDD.RECETA ADD PRIMARY KEY (REC_CODIGO);
ALTER TABLE VARIETE_GDD.RECETA ADD FOREIGN KEY (REC_BONFAR) REFERENCES BONO_FARMACIA(BONFAR_CODIGO);

--//RECETA_MEDICAMENTOS
ALTER TABLE VARIETE_GDD.RECETA_MEDICAMENTOS ADD PRIMARY KEY (RECMED_RECETA,RECMED_MEDICAMENTOS);

--//MEDICAMENTOS	
ALTER TABLE VARIETE_GDD.MEDICAMENTOS ADD PRIMARY KEY (MED_CODIGO);

--//PLANES
ALTER TABLE VARIETE_GDD.PLANES ADD PRIMARY KEY (PLA_CODIGO);

--//COMPRA
ALTER TABLE VARIETE_GDD.COMPRA ADD PRIMARY KEY (COM_CODIGO);
--EN EL ALTER DE ABAJO VER QUE CONVIENE SI REFERENCIAR A AFILIADO O A USUARIO
ALTER TABLE VARIETE_GDD.COMPRA ADD FOREIGN KEY (COM_AFILIADO) REFERENCES AFILIADO(AFI_DNI);

--//AGENDA
ALTER TABLE VARIETE_GDD.AGENDA ADD PRIMARY KEY (AGE_CODIGO);

--//DIAS_ATENCION
ALTER TABLE VARIETE_GDD.DIAS_ATENCION ADD PRIMARY KEY (DIAATE_CODIGO);

GO
 --STORED PRODECURES
 
--**MIGRA AFILIADOS
--Para Afiliados y Profesionales
--username: email
--pass: dni
CREATE PROCEDURE VARIETE_GDD.MIGRA_AFILIADOS
AS
BEGIN
	SELECT DISTINCT Paciente_Mail, Paciente_Dni, Paciente_Dni, Paciente_Nombre, Paciente_Apellido,	Paciente_Direccion, Paciente_Telefono, Paciente_Mail,	Paciente_Fecha_Nac
	INTO [VARIETE_GDD].[USUARIO]
	FROM  gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL
	
	 
	SELECT DISTINCT Paciente_Dni, Plan_Med_Codigo
	INTO [VARIETE_GDD].[AFILIADO]
	FROM gd_esquema.Maestra
END

--**MIGRA PROFESIONALES
--Para Afiliados y Profesionales
--username: email
--pass: dni
CREATE PROCEDURE VARIETE_GDD.MIGRA_PROFESIONALES
AS
BEGIN
	SELECT DISTINCT Medico_Mail, Medico_Dni, Medico_Dni, Medico_Nombre, Medico_Apellido, Medico_Direccion, Medico_Telefono, Medico_Mail,Medico_Fecha_Nac
	INTO [VARIETE_GDD].[USUARIO]
	FROM  gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL
	
	SELECT Medico_Dni
	INTO [VARIETE_GDD].[PROFESIONAL]
	FROM gd_esquema.Maestra
END

--**MIGRA PLANES
CREATE PROCEDURE VARIETE_GDD.MIGRA_PLANES
AS
BEGIN
	SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Farmacia, Plan_Med_Precio_Bono_Consulta
	INTO [VARIETE_GDD].[PLANES]
	FROM gd_esquema.Maestra
	WHERE Plan_Med_Codigo IS NOT NULL
END

--**MIGRA ESPECIALIDADES
CREATE PROCEDURE VARIETE_GDD.MIGRA_ESPECIALIDADES
AS
BEGIN
	SELECT DISTINCT Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
	INTO [VARIETE_GDD].[ESPECIALIDADES]
	FROM gd_esquema.Maestra
END

--**MIGRA TURNOS
CREATE PROCEDURE VARIETE_GDD.MIGRA_TURNOS
AS
BEGIN
	SELECT Turno_Numero,Medico_Dni,Paciente_Dni, Turno_Fecha
	INTO [VARIETE_GDD].[TURNOS] 
	FROM gd_esquema.Maestra
END


--**MIGRA COMPRA DE BONOS
CREATE PROCEDURE VARIETE_GDD.MIGRA_COMPRAS_BONOS
AS
BEGIN
	SELECT Compra_Bono_Fecha, COUNT (DISTINCT Bono_Farmacia_Numero), COUNT (DISTINCT Bono_Consulta_Numero), SUM(ISNULL(Plan_Med_Precio_Bono_Consulta,0) ) + SUM(ISNULL(Plan_Med_Precio_Bono_Farmacia,0) ), Paciente_Dni
	INTO [VARIETE_GDD].[COMPRA]
	FROM gd_esquema.Maestra
	WHERE Compra_Bono_Fecha IS NOT NULL
END

--**MIGRA BONO CONSULTA
CREATE PROCEDURE VARIETE_GDD.MIGRA_BONOS_CONSULTA
AS
BEGIN
	SELECT Paciente_Dni, Bono_Consulta_Numero, Bono_Consulta_Fecha_Impresion, Plan_Med_Codigo, (SELECT TOP 1 COM_CODIGO FROM [VARIETE_GDD].[COMPRA] WHERE COM_CODIGO = Compra_Bono_Fecha AND COM_AFILIADO = Paciente_Dni)
	INTO [VARIETE_GDD].[CONSULTA]
	FROM gd_esquema.Maestra
	WHERE Bono_Consulta_Fecha_Impresion IS NOT NULL AND Bono_Consulta_Numero IS NOT NULL 
END

--**MIGRA BONO FARMACIA
CREATE PROCEDURE VARIETE_GDD.MIGRA_BONOS_FARMACIA
AS
BEGIN
	SELECT Bono_Farmacia_Numero, Paciente_Dni, Bono_Farmacia_Fecha_Impresion, Plan_Med_Codigo
	INTO [VARIETE_GDD].[BONO_FARMACIA]
	FROM gd_esquema.Maestra
	WHERE Bono_Farmacia_Numero IS NOT NULL AND Compra_Bono_Fecha IS NOT NULL
END
COMMIT;	