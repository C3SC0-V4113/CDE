USE master
GO
CREATE DATABASE RegistrosUnidadSalud
GO
USE RegistrosUnidadSalud
GO
--DROP DATABASE RegistrosUnidadSalud
--En tabla resultado, va el resultado, codigocriterio,codigoestandar
--CREACION DE TABLAS
--Tabla Instituciones
CREATE TABLE INSTITUCIONES
(
CodIntitución int identity(1,1) not null,
Nombre varchar(25),
Ubicación varchar(max)
)

--Tabla Usuarios
CREATE TABLE USUARIOS
(
CodUsuario  int identity(1,1) not null,
Usuario varchar(25),
Contraseña varchar(max),
Nombre varchar(25),
Apellido varchar(25),
CodIntitución  int
)

--Tabla Estandares
CREATE TABLE ESTANDARES
(
CodEstandar varchar(3) not null,
NombreEstandar varchar(max),
)

--Tabla Criterios
CREATE TABLE CRITERIOS
(
CodCriterio int identity(1,1) not null,
NumeroCriterio int,
Nombre varchar(max),
CodEstandar varchar(3)
)

--Tabla Evaluaciones
CREATE TABLE EVALUACIONES
(
CodEvaluacion varchar(7) not null,
total int,
CodEstandar varchar(3),
CodUsuario int,
FechaCreacion date,
CodCargo int
)

--Tabla Resultados
CREATE TABLE RESULTADOS
(
CodResultados int identity(1,1) not null,
CodCriterio int,
ResultadoCriterio int not null,
CodEvaluacion varchar(7) 
)

--Tabla Encargados
CREATE TABLE ENCARGADOS
(
CodCargo int identity(1,1),
Nombre varchar(25),
Apellido varchar(25),
)

--LLAVES PRIMARIAS
 Alter table INSTITUCIONES
 add constraint PK_CodIntitución
 primary key(CodIntitución)
 go

 Alter table USUARIOS
 add constraint PK_CodUsuario
 primary key(CodUsuario)
 go

 Alter table ESTANDARES
 add constraint PK_CodEstandar
 primary key(CodEstandar)
 go

 Alter table CRITERIOS
 add constraint PK_CodCriterio
 primary key(CodCriterio)
 go

 Alter table EVALUACIONES
 add constraint PK_CodEvaluacion
 primary key(CodEvaluacion)
 go

 Alter table RESULTADOS
 add constraint PK_CodResultados
 primary key(CodResultados)
 go

 Alter table ENCARGADOS
 add constraint PK_CodCargo
 primary key(CodCargo)
 GO

 --Llaves Foraneas
 alter table USUARIOS
 add constraint FK_CodIntitución
 foreign key (CodIntitución)
 references INSTITUCIONES(CodIntitución)
  ON DELETE CASCADE
 ON UPDATE CASCADE
 go

 alter table EVALUACIONES
 Add constraint FK_CodUsuario
 foreign key (CodUsuario)
 references USUARIOS(CodUsuario)
  ON DELETE CASCADE
 go

 alter table EVALUACIONES
 Add constraint FK_CodEstandar
 foreign key (CodEstandar)
 references ESTANDARES(CodEstandar)
  ON UPDATE CASCADE
  GO

   alter table EVALUACIONES
 Add constraint FK_CodCargo
 foreign key (CodCargo)
 references ENCARGADOS(CodCargo)
  ON UPDATE CASCADE
  GO

 alter table CRITERIOS
 Add constraint FK_CodEstandar1
 foreign key (CodEstandar)
 references ESTANDARES(CodEstandar)
  ON UPDATE CASCADE
 go

 alter table RESULTADOS
 Add constraint FK_CodCriterio
 foreign key (CodCriterio)
 references CRITERIOS(CodCriterio)
 go

 alter table RESULTADOS
 Add constraint FK_CodEvaluacion
 foreign key (CodEvaluacion)
 references EVALUACIONES(CodEvaluacion)
 ON DELETE CASCADE
 go


 --PROCEDIMIENTOS
 create proc CrearInstitucion
 @Nombre varchar(25),
 @Ubicación varchar(max)
 AS
 INSERT INTO INSTITUCIONES VALUES( @Nombre, @Ubicación)
 GO

 create proc CrearUsuario
 @Usuario varchar(25),
 @Contraseña varchar(max),
 @Nombre varchar(25),
 @Apellido varchar(25),
 @CodIntitución int
 AS
 INSERT INTO USUARIOS VALUES (@Usuario,@Contraseña,@Nombre,@Apellido,@CodIntitución)
 GO

 create proc CrearEstandar
 @CodEstandar varchar(3),
 @NombreEstandar varchar(max)
 AS
 INSERT INTO ESTANDARES VALUES(@CodEstandar, @NombreEstandar)
 GO

 create proc CrearCriterio
 @NumeroCriterio int,
 @Nombre varchar(max),
 @CodEstandar varchar(3)
 AS
 INSERT INTO CRITERIOS VALUES(@NumeroCriterio, @Nombre, @CodEstandar)
 GO

 create proc CrearEvaluacion
 @CodEvaluacion varchar(7),
 @total int,
 @CodEstandar varchar(3),
 @CodUsuario int,
 @FechaCreacion date,
 @CodCargo int
 AS
 INSERT INTO EVALUACIONES VALUES( @CodEvaluacion,@total, @CodEstandar, @CodUsuario,@FechaCreacion, @CodCargo)
 GO

 create proc CrearResultado
@CodCriterio int,
@ResultadoCriterio bit,
@CodEvaluacion varchar(7)
AS
INSERT INTO RESULTADOS VALUES(@CodCriterio, @ResultadoCriterio, @CodEvaluacion)
GO

create proc BuscarUsuario
@Usuario varchar(25),
@Contraseña varchar(max)
AS
SELECT*FROM USUARIOS
WHERE Usuario LIKE @Usuario AND Contraseña LIKE @Contraseña
GO

create proc EditarUsuario
 @CodUsuario int,
 @Usuario varchar(25),
 @Contraseña varchar(max),
 @Nombre varchar(25),
 @Apellido varchar(25),
 @CodIntitución int
As
UPDATE USUARIOS SET Usuario=@Usuario,Contraseña=@Contraseña,Nombre=@Nombre,Apellido=@Apellido,CodIntitución=@CodIntitución
where CodUsuario=@CodUsuario
go

create proc EliminarUsuario
 @CodUsuario int
 AS DELETE FROM USUARIOS
 WHERE CodUsuario=@CodUsuario
 GO

 create proc EditarInstitucion
  @CodIntitución int,
 @Nombre varchar(25),
 @Ubicación varchar(max)
 AS
 UPDATE INSTITUCIONES SET Nombre=@Nombre, Ubicación=@Ubicación
 WHERE CodIntitución=@CodIntitución
 GO

 create proc EliminarInstitucion
 @CodIntitución int
 AS DELETE FROM INSTITUCIONES
 WHERE CodIntitución=@CodIntitución
 GO

 create proc LeerNombreInstitucion
 AS
 SELECT CodIntitución, Nombre FROM INSTITUCIONES
 GO

create proc LeerEvaluado
@CodEvaluacion varchar(7)
AS
SELECT C.Nombre as 'Nombre de Criterio',ResultadoCriterio as'Resultado' FROM RESULTADOS R
INNER JOIN EVALUACIONES E ON R.CodEvaluacion=E.CodEvaluacion
INNER JOIN CRITERIOS C ON R.CodCriterio=C.CodCriterio
WHERE E.CodEvaluacion=@CodEvaluacion
GO

create proc EliminarResultados
@CodEvaluacion varchar(7)
as
DELETE RESULTADOS
WHERE CodEvaluacion=@CodEvaluacion
GO

create proc BuscarEvaluadoFecha
@fechainicial date,
@fechafinal date,
@CodEstandar varchar(3)
as
SELECT E.CodEvaluacion AS 'Codigo de Evaluacion',(EN.Apellido+', '+EN.Nombre)AS'Nombre de Evaluador',E.FechaCreacion AS'Fecha de Creación' FROM EVALUACIONES E
INNER JOIN ENCARGADOS EN ON E.CodCargo=EN.CodCargo
WHERE (E.FechaCreacion BETWEEN @fechainicial AND @fechafinal) AND (E.CodEstandar=@CodEstandar)
GO

create proc CrearEncargado
@Nombre varchar(25),
@Apellido varchar(25)
AS
INSERT INTO ENCARGADOS VALUES(@Nombre, @Apellido)
GO

create proc ListarEncargado
as
SELECT CodCargo, (Apellido+', '+Nombre)AS'Nombre' FROM ENCARGADOS
GO

create proc ListarEstandar
as
SELECT CodEstandar FROM ESTANDARES


create proc CrearEncargados
@Nombre varchar(25),
@Apellido varchar(25)
AS
INSERT INTO ENCARGADOS VALUES(@Nombre,@Apellido)
GO

create proc EditarEncargados
@CodCargo int,
@Nombre varchar(25),
@Apellido varchar(25)
AS
 UPDATE ENCARGADOS SET Nombre=@Nombre, Apellido=@Apellido
 WHERE CodCargo=@CodCargo
 GO

 create proc EliminarEncargados
 @CodCargo int
 as
 DELETE FROM ENCARGADOS
 WHERE CodCargo=@CodCargo
 GO

 create proc ListarEncargados
as
SELECT CodCargo,(Apellido+', '+Nombre)AS 'Nombres' FROM ENCARGADOS
go

create proc ComprobarEvaluado
@CodEvaluacion varchar(7)
as
select CodEvaluacion from EVALUACIONES
where CodEvaluacion=@CodEvaluacion

--REGISTROS EXPERIMENTALES

--Creacion de Unidad de Salud
exec CrearInstitucion 'Unidad de Salud Chiptuc',Apopa

--Creacion de usuario
exec CrearUsuario admin,admin,Francisco,Valle,1

--Creacion de Estandar 1
exec CrearEstandar 1,'Toda mujer en edad fértil captada recibe atención integral en salud'
exec CrearCriterio 1,'¿Los Datos generales de la usuaria cuentan con la información detallada?',1
exec CrearCriterio 2,'¿La Historia Clínica cuenta con la siguiente información?',1
exec CrearCriterio 3,'¿La citología aún se encuentra vigente?',1
exec CrearCriterio 4,'¿El examen de mama aún se encuentra vigente?',1
exec CrearCriterio 5,'¿Se recibió la atención que se detalla?',1
exec CrearCriterio 6,'¿La usuaria recibió consejería en el continuo de la atención?',1

--Creación de Estandar 2
exec CrearEstandar 2,'Toda Usuaria recibe atención integral pre-concepcional, prenatal y postnatal'
exec CrearCriterio 1,'¿Los Datos generales de la usuaria cuentan con la información detallada?',2
exec CrearCriterio 2,'¿La Historia Clínica cuenta con la siguiente información?',2
exec CrearCriterio 3,'¿La citología aún se encuentra vigente?',2
exec CrearCriterio 4,'¿El examen de mama aún se encuentra vigente?',2
exec CrearCriterio 5,'¿Está llena la hoja filtro de Cuidado Preconcepcional?',2
exec CrearCriterio 6,'¿Se inscribió en control prenatal antes de las 12 semanas de edad gestacional?',2
exec CrearCriterio 7,'¿Se llenó la hoja filtro de Control Prenatal?',2
exec CrearCriterio 8,'¿Cuenta con el esquema de vacunación de acuerdo al esquema nacional de vacunación?',2
exec CrearCriterio 9,'¿Se verifica y registra la detección de ECNT de la embarazada?',2
exec CrearCriterio 10,'¿Se llenó la hoja de historia clínica perinatal?(HCP)',2
exec CrearCriterio 11,'¿Las curvas de ganacia de peso materno y altura uterina están llenas?',2
exec CrearCriterio 12,'¿Se ha evidenciado el cumplimiento de los cinco controles prenatales?',2
exec CrearCriterio 13,'¿Se le indicó a la usuaria y registro en el expediente los dos perfiles prenatales de laboratorio?',2
exec CrearCriterio 14,'¿Se le prescribió a la usuaria ácido fólico en el período preconcepcional y micronutrientes en el prenatal y postnatal?',2
exec CrearCriterio 15,'¿Se registró la consejería en el continuo de la atención?',2
exec CrearCriterio 16,'¿Se llena la hoja de Plan de Parto de acuerdo a la edad Gestacional?',2
exec CrearCriterio 17,'¿Se ha inscrito a la usuaria en control odontológico?',2
exec CrearCriterio 18,'¿Se ha indicado y registrado el examen de orina con tira reactiva?',2
exec CrearCriterio 19,'¿Se ha registrado la evaluación ginecológica, verificando la presencia o ausencia de secreción vaginal?',2
exec CrearCriterio 20,'¿Se ha llenado la hoja de tamizaje de violencia?',2
exec CrearCriterio 21,'¿Se ha registrado la búsqueda de malformación congénita en el reporte de USG obstétrica?',2
exec CrearCriterio 22,'¿Se refirió a la usuaria a control prenatal por ginecólogo en el período que le corresponde?',2
exec CrearCriterio 23,'¿La usuaria tuvo control puerperal precoz antes de los 7 días post parto y el control antes de los 42 días y verifico su puerperio dentro del área de responsabilidad de la UCSF?',2
exec CrearCriterio 24,'¿Se llenó completamente la HCP? relacionado a:',2
exec CrearCriterio 25,'¿Se registró la evaluación ginecológica verificando la característica de los loquios y/o herida operatoria?',2

--Creación Estándar 3
exec CrearEstandar 3,'Todo prematuro con peso menor de 2,000 gr. al nacer recibe atención integral, según normativa vigente'
exec CrearCriterio 1,'¿Se encuentra en el expediente la hoja de referencia y seguimiento al prematuro referido del hospital con los siguientes datos? :',3
exec CrearCriterio 2,'¿Se encuentran los datos generales del niño?',3
exec CrearCriterio 3,'¿Se encuentran escritos los antecedentes perinatales?',3
exec CrearCriterio 4,'¿Se encuentra escrita la clasificación por peso y edad gestacional al nacer?',3
exec CrearCriterio 5,'¿Se encuentra registrado el examen físico?',3
exec CrearCriterio 6,'¿Se encuentra registrada la clasificación de patología según lineamientos técnicos para la atención integral de niñas y niños en la última consulta?',3
exec CrearCriterio 7,'¿Se encuentra registrada la prescripción de los siguientes micronutrientes?',3
exec CrearCriterio 8,'¿Se encuentra registrado el de diagnóstico nutricional?',3
exec CrearCriterio 9,'¿Se encuentra registrado el diagnóstico clínico?',3
exec CrearCriterio 10,'¿Se encuentra registrado el tratamiento?',3
exec CrearCriterio 11,'¿Se encuentra registrada la evaluación del riesgo social?',3
exec CrearCriterio 12,'¿Se encuentra registrado el esquema de vacunación completo de acuerdo a la edad cronológica?',3
exec CrearCriterio 13,'¿Se encuentra llena la escala simplificada de desarrollo y gráficas de crecimiento y desarrollo de acuerdo a la edad corregida en la última consulta con los siguientes datos: ?',3
exec CrearCriterio 14,'¿Se encuentran registrados los controles en la ficha de control del niño y la niña con antecedente de prematurez con la siguiente información: ?',3
exec CrearCriterio 15,'¿Se encuentra registrada la consejería específica para cuidados del prematuro?',3

--Creación Estándar 4.1
exec CrearEstandar 4.1,'Porcentaje de recién nacidos que recibieron visitas integrales, por promotor de salud, durante los primeros 28 días de nacidos'
exec CrearCriterio 1,'¿Se realiza visita domiciliar por promotor de salud al recién nacido en las primeras 24 horas de nacido o de haber regresado a la comunidad posterior al egreso hospitalatio?',4.1
exec CrearCriterio 2,'¿El promotor de salud registra el cumplimiento de las 4 visitas de salud a los 3, 7, 15 y 28 días?',4.1
exec CrearCriterio 3,'¿Se registra la temperatura en la hoja de vigilancia comunitaria de la embarazada, puérpera y recién nacido?',4.1
exec CrearCriterio 4,'¿Se registra la frecuencia respiratoria en la hoja de vigilancia comunitaria de la embarazada, puérpera y recién nacido?',4.1
exec CrearCriterio 5,'¿Se encuentra registro de lactancia materna exclusiva en la hoja de vigilancia comunitaria de la embarazada, puérpera y recién nacido?',4.1
exec CrearCriterio 6,'¿Se registra la identificación los signos de peligro del recién nacido?',4.1

--Creación Estándar 4.2
exec CrearEstandar 4.2,'Porcentaje de niños y niñas de 0 a 2 meses que reciben atención integral en salud, en la inscripción'
exec CrearCriterio 1,'¿Se encuentran registrados los datos generales: ?',4.2
exec CrearCriterio 2,'¿Se encuentran registrados los antecedentes Perinatales?',4.2
exec CrearCriterio 3,'¿Se inscribe al recién nacido antes de los 7 días de nacido?',4.2
exec CrearCriterio 4,'¿Se registra la clasificación por peso y edad gestacional al nacer?',4.2
exec CrearCriterio 5,'¿Se registra el examen físico?',4.2
exec CrearCriterio 6,'¿Se registra la clasificación de salud bucal?',4.2
exec CrearCriterio 7,'¿Se registra la clasificación de patología según lineamientos técnicos para la atención integral de niñas y niños?',4.2
exec CrearCriterio 8,'¿Se registra el de diagnóstico nutricional?',4.2
exec CrearCriterio 9,'¿Se registra el diagnóstico clínico?',4.2
exec CrearCriterio 10,'¿Se registra el tratamiento?',4.2
exec CrearCriterio 11,'¿Se registra la evaluación del riesgo social?',4.2
exec CrearCriterio 12,'¿Se llena la escala simplificada de desarrollo y gráficas de crecimiento y desarrollo: ?',4.2
exec CrearCriterio 13,'¿Se registra el esquema de vacunación completo de acuerdo a la edad cronológica y el peso al nacer?',4.2
exec CrearCriterio 14,'¿Se registra la lactancia materna exclusiva?',4.2
exec CrearCriterio 15,'¿Se registra la consejería en el continuo de la atención?',4.2

--Creación Estándar 4.3
exec CrearEstandar 4.3,'Porcentaje de niñ@s con edades entre 2 meses a 5 años que recibieron atención integral en salud (control infantil) durante su último control, en el período evaluado'
exec CrearCriterio 1,'¿Se registran los datos generales?',4.3
exec CrearCriterio 2,'¿Se verifica si en la hoja subsecuente de atención integral de la niña y el niño, se indaga los signos de peligro?',4.3
exec CrearCriterio 3,'¿Se registra en la hoja subsecuente de atención integral si se indaga y se anotan signos y síntomas de anemia?',4.3
exec CrearCriterio 4,'¿Se registra la descripción del examen físico en la hoja de atención integral de niños y niñas menores de 5 años?',4.3
exec CrearCriterio 5,'¿Se registra la clasificación de patología según lineamientos técnicos para la atención integral de niñas y niños?',4.3
exec CrearCriterio 6,'¿Se registra la prescripción de micronutrientes?',4.3
exec CrearCriterio 7,'¿Se registra la entrega de antiparasitarios en los niños mayores de 1 año?',4.3
exec CrearCriterio 8,'¿Se registra la evaluación de la salud bucal y referencia a odontología?',4.3
exec CrearCriterio 9,'¿El niño o la niña ha sufrido o sufre maltrato o violencia sexual?¿Se cumplen sus derechos?',4.3
exec CrearCriterio 10,'¿Se registra diagnóstico nutricional?',4.3
exec CrearCriterio 11,'¿Se registra el diagnóstico clínico?',4.3
exec CrearCriterio 12,'¿Se registra el tratamiento?',4.3
exec CrearCriterio 13,'¿Se registra la evaluación del riesgo social?',4.3
exec CrearCriterio 14,'¿Se llenan la escala simplificada y las gráficas de crecimiento y desarrollo?',4.3
exec CrearCriterio 15,'¿Se registra el esquema de vacunación completo según edad cronológica?',4.3
exec CrearCriterio 16,'¿Se registra que el niño o la niña reciben o han recibido lactancia materna exclusiva hasta los 6 meses?',4.3
exec CrearCriterio 17,'¿Hay registro de la consejería en el continuo de la atención?',4.3

--Creación Estándar 5
exec CrearEstandar 5,'Todo usuario o usuaria que es referido a un establecimiento de mayor complejidad debe ser retornado a su UCSF de origen, para el continuo de la atención'
exec CrearCriterio 1,'¿Se encuentra registro de la referencia en el expediente clínico?',5
exec CrearCriterio 2,'¿Se encuentra registro del retorno en el expediente clínico?',5
exec CrearCriterio 3,'¿Se encuentra registro de los datos generales de la referencia?',5
exec CrearCriterio 4,'¿Existe correspondencia de la impresión diagnóstica de la referencia con el expediente clínico?',5
exec CrearCriterio 5,'¿Se registra el motivo de referencia del usuario o usuaria?',5
exec CrearCriterio 6,'¿Se registra los datos positivos al interrogatorio y examen físico?',5
exec CrearCriterio 7,'¿Se registra el estado actual con los siguentes datos: ?',5
exec CrearCriterio 8,'¿Se registra la información relevante del paciente (exámenes realizados y resultados?',5
exec CrearCriterio 9,'¿Se registra el tratamiento del usuario que es referido de acuerdo al expediente clínico?',5
exec CrearCriterio 10,'¿Se cuenta registrado el nombre de la persona que refiere?',5
---