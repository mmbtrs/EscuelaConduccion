/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     25/01/2020 7:46:48 a. m.                     */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACUERDO_PAGO') and o.name = 'FK_ACUERDO__REF_ACUER_ACUERDOESTADO_')
alter table ACUERDO_PAGO
   drop constraint FK_ACUERDO__REF_ACUER_ACUERDOESTADO_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACUERDO_PAGO') and o.name = 'FK_ACUERDO__REF_ACUER_LIQUIDAC')
alter table ACUERDO_PAGO
   drop constraint FK_ACUERDO__REF_ACUER_LIQUIDAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACUERDO_PAGO_DETALLE') and o.name = 'FK_ACUERDO__REF_ACUER_ACUERDODETALLE_')
alter table ACUERDO_PAGO_DETALLE
   drop constraint FK_ACUERDO__REF_ACUER_ACUERDODETALLE_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACUERDO_PAGO_DETALLE') and o.name = 'FK_ACUERDO__REF_ACUER_RECIBO')
alter table ACUERDO_PAGO_DETALLE
   drop constraint FK_ACUERDO__REF_ACUER_RECIBO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CIUDAD') and o.name = 'FK_CIUDAD_REF_CIUDA_DEPARTAM')
alter table CIUDAD
   drop constraint FK_CIUDAD_REF_CIUDA_DEPARTAM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_REF_CLIEN_CIUDAD')
alter table CLIENTE
   drop constraint FK_CLIENTE_REF_CLIEN_CIUDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_REF_CLIEN_GENERO')
alter table CLIENTE
   drop constraint FK_CLIENTE_REF_CLIEN_GENERO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_REF_CLIEN_TIPO_DOC')
alter table CLIENTE
   drop constraint FK_CLIENTE_REF_CLIEN_TIPO_DOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_REFFACTUR_FACTURAC')
alter table FACTURA
   drop constraint FK_FACTURA_REFFACTUR_FACTURAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_REF_FACTU_FACTURA_')
alter table FACTURA
   drop constraint FK_FACTURA_REF_FACTU_FACTURA_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURA') and o.name = 'FK_FACTURA_REF_FACTU_LIQUIDAC')
alter table FACTURA
   drop constraint FK_FACTURA_REF_FACTU_LIQUIDAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIQUIDACION') and o.name = 'FK_LIQUIDAC_REFERENCE_TIPO_LIQ')
alter table LIQUIDACION
   drop constraint FK_LIQUIDAC_REFERENCE_TIPO_LIQ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIQUIDACION') and o.name = 'FK_LIQUIDAC_REF_LIQUI_CLIENTE')
alter table LIQUIDACION
   drop constraint FK_LIQUIDAC_REF_LIQUI_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIQUIDACION_DETALLE') and o.name = 'FK_LIQUIDAC_REF_LIQUI_TARIFA_D')
alter table LIQUIDACION_DETALLE
   drop constraint FK_LIQUIDAC_REF_LIQUI_TARIFA_D
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LIQUIDACION_DETALLE') and o.name = 'FK_LIQUIDAC_REF_LIQUI_LIQUIDAC')
alter table LIQUIDACION_DETALLE
   drop constraint FK_LIQUIDAC_REF_LIQUI_LIQUIDAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PERFIL_DETALLE') and o.name = 'FK_PERFIL_D_REF_PERFI_PERFIL')
alter table PERFIL_DETALLE
   drop constraint FK_PERFIL_D_REF_PERFI_PERFIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECIBO') and o.name = 'FK_RECIBO_REF_LIQUI_LIQUIDAC')
alter table RECIBO
   drop constraint FK_RECIBO_REF_LIQUI_LIQUIDAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RECIBO') and o.name = 'FK_RECIBO_REF_RECIB_RECIBO_E')
alter table RECIBO
   drop constraint FK_RECIBO_REF_RECIB_RECIBO_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TARIFA') and o.name = 'FK_TARIFA_REF_TARIF_TARIFA_C')
alter table TARIFA
   drop constraint FK_TARIFA_REF_TARIF_TARIFA_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TARIFA') and o.name = 'FK_TARIFA_REF_TARIF_VIGENCIA')
alter table TARIFA
   drop constraint FK_TARIFA_REF_TARIF_VIGENCIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TARIFA_DETALLE') and o.name = 'FK_TARIFA_D_REF_TARIF_TARIFA_C')
alter table TARIFA_DETALLE
   drop constraint FK_TARIFA_D_REF_TARIF_TARIFA_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TARIFA_DETALLE') and o.name = 'FK_TARIFA_D_REF_TARIF_TARIFA')
alter table TARIFA_DETALLE
   drop constraint FK_TARIFA_D_REF_TARIF_TARIFA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_REF_USUAR_PERFIL')
alter table USUARIO
   drop constraint FK_USUARIO_REF_USUAR_PERFIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_REF_USUAR_TIPO_DOC')
alter table USUARIO
   drop constraint FK_USUARIO_REF_USUAR_TIPO_DOC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VIEW_CIUDAD')
            and   type = 'V')
   drop view VIEW_CIUDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VIEW_CLIENTE')
            and   type = 'V')
   drop view VIEW_CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACUERDO_ESTADO')
            and   type = 'U')
   drop table ACUERDO_ESTADO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACUERDO_PAGO')
            and   type = 'U')
   drop table ACUERDO_PAGO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACUERDO_PAGO_DETALLE')
            and   type = 'U')
   drop table ACUERDO_PAGO_DETALLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CIUDAD')
            and   type = 'U')
   drop table CIUDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONFIGURACIONINICIAL')
            and   type = 'U')
   drop table CONFIGURACIONINICIAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTAMENTO')
            and   type = 'U')
   drop table DEPARTAMENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DIAFESTIVO')
            and   type = 'U')
   drop table DIAFESTIVO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURA')
            and   type = 'U')
   drop table FACTURA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURACONSECUTIVO')
            and   type = 'U')
   drop table FACTURACONSECUTIVO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURA_ESTADO')
            and   type = 'U')
   drop table FACTURA_ESTADO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GENERO')
            and   type = 'U')
   drop table GENERO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIQUIDACION')
            and   type = 'U')
   drop table LIQUIDACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LIQUIDACION_DETALLE')
            and   type = 'U')
   drop table LIQUIDACION_DETALLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERFIL')
            and   type = 'U')
   drop table PERFIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERFIL_DETALLE')
            and   type = 'U')
   drop table PERFIL_DETALLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECIBO')
            and   type = 'U')
   drop table RECIBO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RECIBO_ESTADO')
            and   type = 'U')
   drop table RECIBO_ESTADO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SALARIOMINIMO')
            and   type = 'U')
   drop table SALARIOMINIMO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARIFA')
            and   type = 'U')
   drop table TARIFA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARIFA_CATEGORIA')
            and   type = 'U')
   drop table TARIFA_CATEGORIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARIFA_CONCEPTO')
            and   type = 'U')
   drop table TARIFA_CONCEPTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TARIFA_DETALLE')
            and   type = 'U')
   drop table TARIFA_DETALLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_DOCUMENTO')
            and   type = 'U')
   drop table TIPO_DOCUMENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPO_LIQUIDACION')
            and   type = 'U')
   drop table TIPO_LIQUIDACION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VIGENCIA')
            and   type = 'U')
   drop table VIGENCIA
go

/*==============================================================*/
/* Table: ACUERDO_ESTADO                                        */
/*==============================================================*/
create table ACUERDO_ESTADO (
   ID                   int                  identity,
   NOMBRE               varchar(20)          not null,
   constraint PK_ACUERDO_ESTADO primary key (ID)
)
go

/*==============================================================*/
/* Table: ACUERDO_PAGO                                          */
/*==============================================================*/
create table ACUERDO_PAGO (
   ID                   int                  identity,
   ID_LIQUIDACION       int                  not null,
   ID_ACUERDO_ESTADO    int                  not null,
   NUMERO_ACUERDO       varchar(10)          not null,
   FECHA_ACUERDO        datetime             not null,
   constraint PK_ACUERDO_PAGO primary key (ID)
)
go

/*==============================================================*/
/* Table: ACUERDO_PAGO_DETALLE                                  */
/*==============================================================*/
create table ACUERDO_PAGO_DETALLE (
   ID                   int                  identity,
   ID_ACUERDO_PAGO      int                  not null,
   ID_RECIBO            Int                  null,
   NUMERO_CUOTA         int                  not null,
   VALOR                float                not null,
   FECHA_LIMITE_PAGO    datetime             not null,
   PORCENTAJE           float                not null,
   constraint PK_ACUERDO_PAGO_DETALLE primary key (ID)
)
go

/*==============================================================*/
/* Table: CIUDAD                                                */
/*==============================================================*/
create table CIUDAD (
   ID                   int                  identity,
   ID_DEPARTAMENTO      int                  not null,
   NOMBRE               varchar(30)          not null,
   constraint PK_CIUDAD primary key (ID)
)
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   ID                   int                  identity,
   ID_GENERO            int                  not null,
   ID_CIUDAD            int                  not null,
   ID_TIPO_DOCUMENTO    int                  not null,
   IDENTIFICACION       varchar(20)          not null,
   NOMBRES              varchar(50)          not null,
   APELLIDOS            varchar(50)          not null,
   DIRECCION            varchar(100)         not null,
   TELEFONO             varchar(50)          null,
   CELULAR              varchar(10)          null,
   CORREO               varchar(50)          not null,
   FECHA_NACIMIENTO     datetime             not null,
   constraint PK_CLIENTE primary key (ID)
)
go

/*==============================================================*/
/* Table: CONFIGURACIONINICIAL                                  */
/*==============================================================*/
create table CONFIGURACIONINICIAL (
   ID                   int                  identity,
   NOMBRE               varchar(30)          not null,
   DESCRIPCION          varchar(100)         not null,
   VALOR                varchar(50)          not null,
   ESTADO               varchar(1)           not null,
   constraint PK_CONFIGURACIONINICIAL primary key (ID)
)
go

/*==============================================================*/
/* Table: DEPARTAMENTO                                          */
/*==============================================================*/
create table DEPARTAMENTO (
   ID                   int                  not null,
   NOMBRE               varchar(30)          not null,
   constraint PK_DEPARTAMENTO primary key (ID)
)
go

/*==============================================================*/
/* Table: DIAFESTIVO                                            */
/*==============================================================*/
create table DIAFESTIVO (
   ID                   int                  identity,
   FECHA                datetime             not null,
   DESCRIPCION          varchar(20)          not null,
   constraint PK_DIAFESTIVO primary key (ID)
)
go

/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA (
   ID                   int                  not null,
   ID_FACTURA_ESTADO    int                  not null,
   ID_LIQUIDACION       int                  not null,
   NUMERO_FACTURA       varchar(20)          not null,
   DISPONIBLE           varchar(2)           not null
      constraint CKC_DISPONIBLE_FACTURA check (DISPONIBLE in ('SI','NO') and DISPONIBLE = upper(DISPONIBLE)),
   ARCHIVO_FISICO       image                not null,
   constraint PK_FACTURA primary key (ID)
)
go

/*==============================================================*/
/* Table: FACTURACONSECUTIVO                                    */
/*==============================================================*/
create table FACTURACONSECUTIVO (
   ID                   int                  identity,
   RANGO_INICIAL        float                not null,
   RANGO_FINAL          float                not null,
   SUFIJO               varchar(3)           null,
   RESOLUCION           varchar(20)          not null,
   FECHA_RESOLUCION     datetime             not null,
   constraint PK_FACTURACONSECUTIVO primary key (ID)
)
go

/*==============================================================*/
/* Table: FACTURA_ESTADO                                        */
/*==============================================================*/
create table FACTURA_ESTADO (
   ID                   int                  identity,
   ESTADO               varchar(20)          not null,
   constraint PK_FACTURA_ESTADO primary key (ID)
)
go

/*==============================================================*/
/* Table: GENERO                                                */
/*==============================================================*/
create table GENERO (
   ID                   int                  identity,
   NOMBRE               varchar(20)          not null,
   constraint PK_GENERO primary key (ID)
)
go

/*==============================================================*/
/* Table: LIQUIDACION                                           */
/*==============================================================*/
create table LIQUIDACION (
   ID                   int                  identity,
   ID_CLIENTE           int                  not null,
   ID_TIPO_LIQUIDACION  int                  null,
   FECHA_LIQUIDACION    datetime             not null,
   TOTAL                float                not null,
   constraint PK_LIQUIDACION primary key (ID)
)
go

/*==============================================================*/
/* Table: LIQUIDACION_DETALLE                                   */
/*==============================================================*/
create table LIQUIDACION_DETALLE (
   ID                   int                  identity,
   ID_LIQUIDACION       int                  not null,
   ID_TARIFA_DETALLE    int                  not null,
   VALOR_CONCEPTO       float                not null,
   constraint PK_LIQUIDACION_DETALLE primary key (ID)
)
go

/*==============================================================*/
/* Table: PERFIL                                                */
/*==============================================================*/
create table PERFIL (
   ID                   int                  identity,
   NOMBRE               varchar(20)          not null,
   constraint PK_PERFIL primary key (ID)
)
go

/*==============================================================*/
/* Table: PERFIL_DETALLE                                        */
/*==============================================================*/
create table PERFIL_DETALLE (
   ID                   int                  identity,
   ID_PERFIL            int                  not null,
   DESCRIPCION          varchar(100)         not null,
   MODULO               varchar(20)          not null,
   constraint PK_PERFIL_DETALLE primary key (ID)
)
go

/*==============================================================*/
/* Table: RECIBO                                                */
/*==============================================================*/
create table RECIBO (
   ID                   Int                  not null,
   ID_LIQUIDACION       int                  not null,
   ID_ESTADO            int                  not null,
   NUMERO_RECIBO        varchar(10)          not null,
   FECHA_RECIBO         datetime             not null,
   FECHA_REGISTRO_PAGO  datetime             null,
   FECHA_PAGO           datetime             null,
   VALOR                float                not null,
   FECHA_VENCIMIENTO    datetime             not null,
   FECHA_ENTRAMITE      datetime             null,
   FECHA_ANULADO        datetime             null,
   FECHA_PAGOANULADO    datetime             null,
   FECHA_PROCESADO      datetime             null,
   ARCHIVO_FISICO       image                not null,
   constraint PK_RECIBO primary key (ID)
)
go

/*==============================================================*/
/* Table: RECIBO_ESTADO                                         */
/*==============================================================*/
create table RECIBO_ESTADO (
   ID                   int                  identity,
   ESTADO               varchar(20)          not null,
   DESCRIPCION_ESTADO   varchar(100)         null,
   constraint PK_RECIBO_ESTADO primary key (ID)
)
go

/*==============================================================*/
/* Table: SALARIOMINIMO                                         */
/*==============================================================*/
create table SALARIOMINIMO (
   ID                   int                  identity,
   VIGENCIA             int                  not null,
   VALOR                float                not null,
   constraint PK_SALARIOMINIMO primary key (ID)
)
go

/*==============================================================*/
/* Table: TARIFA                                                */
/*==============================================================*/
create table TARIFA (
   ID                   int                  identity,
   ID_VIGENCIA          int                  not null,
   ID_TARIFA_CATEGORIA  int                  null,
   NOMBRE               varchar(50)          not null,
   ESTADO               varchar(1)           not null
      constraint CKC_ESTADO_TARIFA check (ESTADO in ('A','I') and ESTADO = upper(ESTADO)),
   constraint PK_TARIFA primary key (ID)
)
go

/*==============================================================*/
/* Table: TARIFA_CATEGORIA                                      */
/*==============================================================*/
create table TARIFA_CATEGORIA (
   ID                   int                  identity,
   NOMBRE               varchar(20)          not null,
   constraint PK_TARIFA_CATEGORIA primary key (ID)
)
go

/*==============================================================*/
/* Table: TARIFA_CONCEPTO                                       */
/*==============================================================*/
create table TARIFA_CONCEPTO (
   ID                   int                  identity,
   CODIGO               varchar(20)          not null,
   NOMBRE               varchar(50)          not null,
   DESCRIPCION          varchar(500)         null,
   ESTADO               varchar(1)           not null
      constraint CKC_ESTADO_TARIFA_C check (ESTADO in ('A','I') and ESTADO = upper(ESTADO)),
   constraint PK_TARIFA_CONCEPTO primary key (ID)
)
go

/*==============================================================*/
/* Table: TARIFA_DETALLE                                        */
/*==============================================================*/
create table TARIFA_DETALLE (
   ID                   int                  identity,
   ID_TARIFA            int                  not null,
   ID_TARIFA_CONCEPTO   int                  not null,
   TERCERO              varchar(2)           not null
      constraint CKC_TERCERO_TARIFA_D check (TERCERO in ('SI','NO') and TERCERO = upper(TERCERO)),
   DESCONTABLE          varchar(2)           not null
      constraint CKC_DESCONTABLE_TARIFA_D check (DESCONTABLE in ('SI','NO') and DESCONTABLE = upper(DESCONTABLE)),
   FORMULA              varchar(8000)        not null,
   constraint PK_TARIFA_DETALLE primary key (ID)
)
go

/*==============================================================*/
/* Table: TIPO_DOCUMENTO                                        */
/*==============================================================*/
create table TIPO_DOCUMENTO (
   ID                   int                  identity,
   TIPO                 varchar(20)          not null,
   ABREVIACION          varchar(3)           not null,
   constraint PK_TIPO_DOCUMENTO primary key (ID)
)
go

/*==============================================================*/
/* Table: TIPO_LIQUIDACION                                      */
/*==============================================================*/
create table TIPO_LIQUIDACION (
   ID                   int                  identity,
   TIPO                 varchar(20)          not null,
   constraint PK_TIPO_LIQUIDACION primary key (ID)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID                   int                  identity,
   ID_PERFIL            int                  not null,
   ID_TIPO_DOCUMENTO    int                  not null,
   LOGIN                varchar(20)          not null,
   PASSWORD             varchar(1000)        not null,
   FECHA_INGRESO        datetime             not null,
   FECHA_RETIRO         datetime             null,
   IDENTIFICACION       varchar(20)          not null,
   NOMBRES              varchar(50)          not null,
   APELLIDOS            varchar(50)          not null,
   ESTADO               varchar(1)           not null
      constraint CKC_ESTADO_USUARIO check (ESTADO in ('A','I') and ESTADO = upper(ESTADO)),
   FOTO                 image                null,
   constraint PK_USUARIO primary key (ID)
)
go

/*==============================================================*/
/* Table: VIGENCIA                                              */
/*==============================================================*/
create table VIGENCIA (
   ID                   int                  identity,
   NOMBRE               int                  not null,
   constraint PK_VIGENCIA primary key (ID)
)
go

/*==============================================================*/
/* View: VIEW_CIUDAD                                            */
/*==============================================================*/
create view VIEW_CIUDAD as
SELECT CIUDAD.ID, DEPARTAMENTO.NOMBRE AS DEPARTAMENTO, CIUDAD.NOMBRE AS CIUDAD
FROM DEPARTAMENTO INNER JOIN CIUDAD ON (DEPARTAMENTO.ID = CIUDAD.ID_DEPARTAMENTO)
go

/*==============================================================*/
/* View: VIEW_CLIENTE                                           */
/*==============================================================*/
create view VIEW_CLIENTE as
SELECT CLIENTE.ID,
TIPO_DOCUMENTO.TIPO AS TIPO_DOCUMENTO,
CLIENTE.IDENTIFICACION,
CLIENTE.NOMBRES,
CLIENTE.APELLIDOS,
CLIENTE.DIRECCION,
VIEW_CIUDAD.CIUDAD,
VIEW_CIUDAD.DEPARTAMENTO,
GENERO.NOMBRE AS GENERO,
ISNULL(CLIENTE.TELEFONO,'') AS TELEFONO,
ISNULL(CLIENTE.CELULAR,'') AS CELULAR,
CLIENTE.CORREO,
CONVERT(VARCHAR(11), CLIENTE.FECHA_NACIMIENTO, 103) AS FECHA_NACIMIENTO
FROM
CLIENTE 
LEFT JOIN TIPO_DOCUMENTO ON (CLIENTE.ID_TIPO_DOCUMENTO = TIPO_DOCUMENTO.ID)
LEFT JOIN VIEW_CIUDAD ON (CLIENTE.ID_CIUDAD = VIEW_CIUDAD.ID)
LEFT JOIN GENERO ON (CLIENTE.ID_GENERO = GENERO.ID)
go

alter table ACUERDO_PAGO
   add constraint FK_ACUERDO__REF_ACUER_ACUERDOESTADO_ foreign key (ID_ACUERDO_ESTADO)
      references ACUERDO_ESTADO (ID)
go

alter table ACUERDO_PAGO
   add constraint FK_ACUERDO__REF_ACUER_LIQUIDAC foreign key (ID_LIQUIDACION)
      references LIQUIDACION (ID)
go

alter table ACUERDO_PAGO_DETALLE
   add constraint FK_ACUERDO__REF_ACUER_ACUERDODETALLE_ foreign key (ID_ACUERDO_PAGO)
      references ACUERDO_PAGO (ID)
go

alter table ACUERDO_PAGO_DETALLE
   add constraint FK_ACUERDO__REF_ACUER_RECIBO foreign key (ID_RECIBO)
      references RECIBO (ID)
go

alter table CIUDAD
   add constraint FK_CIUDAD_REF_CIUDA_DEPARTAM foreign key (ID_DEPARTAMENTO)
      references DEPARTAMENTO (ID)
go

alter table CLIENTE
   add constraint FK_CLIENTE_REF_CLIEN_CIUDAD foreign key (ID_CIUDAD)
      references CIUDAD (ID)
go

alter table CLIENTE
   add constraint FK_CLIENTE_REF_CLIEN_GENERO foreign key (ID_GENERO)
      references GENERO (ID)
go

alter table CLIENTE
   add constraint FK_CLIENTE_REF_CLIEN_TIPO_DOC foreign key (ID_TIPO_DOCUMENTO)
      references TIPO_DOCUMENTO (ID)
go

alter table FACTURA
   add constraint FK_FACTURA_REFFACTUR_FACTURAC foreign key (ID)
      references FACTURACONSECUTIVO (ID)
go

alter table FACTURA
   add constraint FK_FACTURA_REF_FACTU_FACTURA_ foreign key (ID_FACTURA_ESTADO)
      references FACTURA_ESTADO (ID)
go

alter table FACTURA
   add constraint FK_FACTURA_REF_FACTU_LIQUIDAC foreign key (ID_LIQUIDACION)
      references LIQUIDACION (ID)
go

alter table LIQUIDACION
   add constraint FK_LIQUIDAC_REFERENCE_TIPO_LIQ foreign key (ID_TIPO_LIQUIDACION)
      references TIPO_LIQUIDACION (ID)
go

alter table LIQUIDACION
   add constraint FK_LIQUIDAC_REF_LIQUI_CLIENTE foreign key (ID_CLIENTE)
      references CLIENTE (ID)
go

alter table LIQUIDACION_DETALLE
   add constraint FK_LIQUIDAC_REF_LIQUI_TARIFA_D foreign key (ID_TARIFA_DETALLE)
      references TARIFA_DETALLE (ID)
go

alter table LIQUIDACION_DETALLE
   add constraint FK_LIQUIDAC_REF_LIQUI_LIQUIDAC foreign key (ID_LIQUIDACION)
      references LIQUIDACION (ID)
go

alter table PERFIL_DETALLE
   add constraint FK_PERFIL_D_REF_PERFI_PERFIL foreign key (ID_PERFIL)
      references PERFIL (ID)
go

alter table RECIBO
   add constraint FK_RECIBO_REF_LIQUI_LIQUIDAC foreign key (ID_LIQUIDACION)
      references LIQUIDACION (ID)
go

alter table RECIBO
   add constraint FK_RECIBO_REF_RECIB_RECIBO_E foreign key (ID_ESTADO)
      references RECIBO_ESTADO (ID)
go

alter table TARIFA
   add constraint FK_TARIFA_REF_TARIF_TARIFA_C foreign key (ID_TARIFA_CATEGORIA)
      references TARIFA_CATEGORIA (ID)
go

alter table TARIFA
   add constraint FK_TARIFA_REF_TARIF_VIGENCIA foreign key (ID_VIGENCIA)
      references VIGENCIA (ID)
go

alter table TARIFA_DETALLE
   add constraint FK_TARIFA_D_REF_TARIF_TARIFA_C foreign key (ID_TARIFA_CONCEPTO)
      references TARIFA_CONCEPTO (ID)
go

alter table TARIFA_DETALLE
   add constraint FK_TARIFA_D_REF_TARIF_TARIFA foreign key (ID_TARIFA)
      references TARIFA (ID)
go

alter table USUARIO
   add constraint FK_USUARIO_REF_USUAR_PERFIL foreign key (ID_PERFIL)
      references PERFIL (ID)
go

alter table USUARIO
   add constraint FK_USUARIO_REF_USUAR_TIPO_DOC foreign key (ID_TIPO_DOCUMENTO)
      references TIPO_DOCUMENTO (ID)
go

