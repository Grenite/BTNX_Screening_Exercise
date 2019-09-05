CREATE SCHEMA if not exists `btnx_screening`;
use btnx_screening;
create table if not exists entry(
	entryId varchar(36) not null,
	experience int not null,
	primary key (entryId)
);
create table if not exists industry(
	entryId varchar(36) not null,
	industry varchar(255) not null,
	foreign key (entryId)
		references entry(entryId)
		on update cascade on delete cascade
);
create table if not exists location(
	entryId varchar(36) not null,
	city varchar(255),
	country varchar(255) not null,
	foreign key (entryId)
		references entry(entryId)
		on update cascade on delete cascade
);
create table if not exists keyword(
	entryId varchar(36) not null,
	keyword varchar(255) not null,
	foreign key (entryId)
		references entry(entryId)
		on update cascade on delete cascade
);
create schema if not exists `survey_location`;
use survey_location;
create table if not exists worldcities (
	city_ascii varchar(255) not null,
    country varchar(255) not null,
    id int not null,
    primary key (id)
);
#load data infile 'worldcities.csv' into table worldcities fields terminated by ',' lines terminated by '\n' ignore 1 rows (city_ascii, country, admin_name, id);
create user if not exists 'survey'@'localhost';
grant insert on btnx_screening.* to 'survey'@'localhost';
grant select on survey_location.worldcities to 'survey'@'localhost';