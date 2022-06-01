DROP DATABASE IF  EXISTS bbanco;

CREATE DATABASE bbanco;

use bbanco;
CREATE TABLE agente
 (
 IdAgente int NOT NULL, 
 nome varchar (45) ,
 endereco varchar (45) ,
 nascimento date ,
 habilidade varchar(45),
 sexo varchar(45) ,
 email varchar(45),
 PRIMARY KEY (IdAgente)
 ) ENGINE=InnoDB;
 
 CREATE TABLE vilao
 (
 IdVilao int NOT NULL, 
 nome varchar (45) not null ,
 num_crimes int not null ,
 PRIMARY KEY (IdVilao)
 ) ENGINE=InnoDB;
 
 CREATE TABLE missao
 (
 Idmissao int NOT NULL, 
 ddata date not null,
 nome varchar (45) not null ,
 llocal varchar (45) ,
 duracao int,
 vilao_idvilao int not null,
 PRIMARY KEY (Idmissao),
 FOREIGN KEY (vilao_idvilao) REFERENCES vilao(IdVilao)

 ) ENGINE=InnoDB;
 
CREATE TABLE Agente_has_missao
 (
 Agente_idAgente int not null,
 missao_id_missao int not null,
 
 PRIMARY KEY (Agente_idAgente,missao_id_missao),
 FOREIGN KEY (missao_id_missao) REFERENCES missao(Idmissao),
 FOREIGN KEY (Agente_idAgente) REFERENCES agente(IdAgente)

 ) ENGINE=InnoDB;
	
    INSERT INTO agente (IdAgente, nome, endereco, nascimento, habilidade, sexo, email) VALUES (1, 'JOSE DE ALENCAR', 'RUA DAS ALMAS', '1911-11-11', 'tiro', 'masculino', 'alencar@literario.com');
    INSERT INTO agente (IdAgente, nome, endereco, nascimento, habilidade, sexo, email) VALUES (2, 'James Bond', 'RUA MI6', '1965-03-01', 'disfarce', 'masculino', 'bondejames@mi6.com');
    INSERT INTO agente (IdAgente, nome, endereco, nascimento, habilidade, sexo, email) VALUES (3, 'Lara Croft', 'RUA 6', '1985-03-01', 'exploracao', 'feminino', 'croftlara@gmail.com');
    INSERT INTO agente (IdAgente, nome, endereco, nascimento, habilidade, sexo, email) VALUES (4, 'Steve Rogers', 'RUA A', '1935-03-01', 'corpo a corpo', 'masculino', 'caprogers@avengers.com');
    INSERT INTO agente (IdAgente, nome, endereco, nascimento, habilidade, sexo, email) VALUES (5, ' Tony Stark', 'RUA A', '1975-03-01', 'armadura', 'masculino', 'tony@avengers.com');

    INSERT INTO vilao (IdVilao, nome, num_crimes) VALUES (1, 'Ultron', 4000);
	INSERT INTO vilao (IdVilao, nome, num_crimes) VALUES (2, 'Thanos', 999999);
	INSERT INTO vilao (IdVilao, nome, num_crimes) VALUES (3, 'Jaqueta Amarela', 200);
	INSERT INTO vilao (IdVilao, nome, num_crimes) VALUES (4, 'capanga', 2);
	INSERT INTO vilao (IdVilao, nome, num_crimes) VALUES (5, 'capanga armado', 2);

	INSERT INTO missao (Idmissao, ddata, nome, llocal, duracao, vilao_idvilao ) VALUES (1, '2021-11-11', 'Ataque na selva', 'Amazonia', 11, 4);
	INSERT INTO missao (Idmissao, ddata, nome, llocal, duracao, vilao_idvilao ) VALUES (2, '2022-11-11', 'Espionagem', 'Londres', 10, 5);
	INSERT INTO missao (Idmissao, ddata, nome, llocal, duracao, vilao_idvilao ) VALUES (3, '2012-11-11', 'Ataque a sokovia', 'Sokivia', 100, 1);
	INSERT INTO missao (Idmissao, ddata, nome, llocal, duracao, vilao_idvilao ) VALUES (4, '2014-11-11', 'Ataque a pinCorp', 'PinnCorp', 100, 3);
	INSERT INTO missao (Idmissao, ddata, nome, llocal, duracao, vilao_idvilao ) VALUES (5, '2014-11-11', 'Ataque ao universo', 'Terra', 900, 2);

	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (1,3);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (2,2);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (2,3);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (3,1);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (3,4);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (3,5);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (5,5);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (5,4);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (5,3);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (5,2);
	INSERT INTO Agente_has_missao (missao_id_missao, Agente_idAgente) VALUES (5,1);
    
    select agente.nome as NomeAgente, agente.email as Email,  missoes.nome as NomeMissao, missoes.ddata as dataMissao
    from agente 
    join (select missao.nome as nome  , missao.ddata as ddata, Agente_has_missao.Agente_idAgente as idagente from missao inner join Agente_has_missao on Agente_has_missao.missao_id_missao = missao.Idmissao)as missoes
	on missoes.idagente = agente.IdAgente;
	
    select agente.nome as NomeAgente, missoes.nome as NomeMissao, vilao.nome as NomeVilao
    from agente 
    join (
    (select missao.nome as nome  , missao.ddata as ddata, missao.duracao as duracao, Agente_has_missao.Agente_idAgente as idagente, missao.vilao_idvilao as vilaoid 
    from missao 
    inner join Agente_has_missao on Agente_has_missao.missao_id_missao = missao.Idmissao)
    as missoes 
    inner join vilao 
    on missoes.vilaoid = vilao. IdVilao)    
	on missoes.idagente = agente.IdAgente;

	select missao.nome as NomeMissao, missao.ddata as DataMissao, missao.duracao as Duracao, vilao.nome as NomeVilao
    from missao
    inner join vilao
    on vilao.IdVilao = missao.vilao_idvilao



	


 