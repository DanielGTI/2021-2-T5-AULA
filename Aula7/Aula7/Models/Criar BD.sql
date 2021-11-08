use[AVA5]

DROP TABLE aluno;

CREATE TABLE aluno(
	id		int primary key not null identity(1,1),
	nome	varchar(100),
	ra		varchar(15),
	cpf		varchar(15),
	idade	int
);

SELECT * FROM aluno;
