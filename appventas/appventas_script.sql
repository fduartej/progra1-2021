select * from t_contacto

insert into t_contacto (firstname, lastname) values ('Juan', 'Perez');

insert into t_contacto (firstname, lastname) values ('Bob', 'Marley');

insert into t_contacto (firstname, lastname) values ('Kurt', 'Cobain');

update t_contacto set lastname ='Perez' where firstname ='Juan'

delete from t_contacto where  firstname ='Juan'
