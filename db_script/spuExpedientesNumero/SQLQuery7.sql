use ministerio_seguridad

go
create procedure spuExpedientesNumero
@cod_expediente int
as
select 
	fecha_inicio as FECHA_INICIO, 
	caratula_expediente as CARATULA,
	estados.descripcion as ESTADO,
	juicios.descripcion as JUICIO
from expedientes
inner join estados on expedientes.cod_estado = estados.cod_estado
inner join juicios on expedientes.cod_juicio = juicios.cod_juicio
where cod_expediente = @cod_expediente


exec spuExpedientesNumero 1

select * from expedientes