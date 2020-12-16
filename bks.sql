
create table personisiguruar(
emriMbiemri varchar(50) primary key,
qyteti varchar(70),
adresa varchar(100),
telefoni varchar(50),
email varchar(200)
)

create table personisiguruar(
lloji varchar(80),
shasia varchar(16),
markaTipi varchar(80),
targat varchar(80),
ngjyra varchar(50)
)


insert into personisiguruar(emriMbiemri,qyteti,adresa,telefoni,email) values ('Mihrije Kadriu','Prishtine','Martiret','049 567 432','emri.mbiemri@hotmail.com');

insert into automjeti(lloji,shasia,markaTipi,targat,ngjyra) values ('AUTOMOBIL','2222','Kia seltos','22 111 2A','I kalter');

select * from personisiguruar;
select * from automjeti;
