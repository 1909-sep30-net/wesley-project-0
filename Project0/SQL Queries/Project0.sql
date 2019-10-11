-- create table
create table pokemon(
	id int not null primary key identity,
	name nvarchar(64) not null unique,
	height int not null,
	weight int not null
);

create table type (
	id int not null primary key identity,
	name nvarchar(64) not null unique
);

create table pokemontype(
	id int not null primary key identity,
	pokemonid int not null foreign key references pokemon(id),
	typeid int not null foreign key references type(id)
);

insert into pokemon(name, height, weight) values ('bulbasaur', 7, 69), ('ditto', 3, 40);

insert into type (name) values ('normal'), ('grass');

insert into pokemontype(pokemonid, typeid) values ((select id from pokemon where name = 'bulbasaur'), (select id from type where name = 'grass'),
													(select id from pokemon where name = 'ditto'), (select id from type where name = 'normal'));