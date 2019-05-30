﻿CREATE TABLE filmes (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	avaliacao DECIMAL(3,1),
	duracao DATETIME2,
	curtiu BIT, -- BOOLEAN 1 -> true , 0 -> false
	categoria VARCHAR(30),
	tem_sequencia BIT 
);

INSERT INTO filmes 
(nome, avaliacao , duracao , curtiu , categoria , tem_sequencia)
VALUES 
('Carros 3', 10.0, '2000-01-01 02:30:00', 1, 'Infantil', 1),
('Professor! (não) é Bipolar', 5.3, '2000-01-01 01:45:00' , 1, 'Ação', 0);

