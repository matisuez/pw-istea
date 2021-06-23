
use WebProgrammingFinalExam;

create table Person (
	Id int IDENTITY(1,1),
	Name varchar(50) not null,
	Surname varchar(50) not null,
	Email varchar(150) not null,
	Available bit not null
);

insert into Person values('Matias','Suez','matisuez@gmail.com', 1);