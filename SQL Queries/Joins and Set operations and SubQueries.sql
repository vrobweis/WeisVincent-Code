--Part 1
insert into associates (associateName, associateState) values
('Vincent', 'CA'),
('Zar', 'MO'),
('JJ', 'CA'),
('Mann', 'TX'),
('Drew', 'AZ');

--Part 2
select * from associates where associateState = 'CA';

--Part 3
select associateState, count(*) from associates group by associateState order by count asc;
select associateState, count(*) from associates group by associateState order by count desc;

--Part 4a
select * from trainers left outer join batch on trainers.id=batch.trainerid where batch.trainerid is null;

--Part 4b
select distinct associatename, associatestate from associates inner join batch on associates.id = batch.associateid;

--Part 4c
select distinct associatename, associatestate from associates left outer join batch on associates.id = batch.associateid where batch.trainerid is null;
