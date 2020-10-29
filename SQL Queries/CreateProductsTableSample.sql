CREATE TYPE "ProductType" AS ENUM ('Physical', 'Cognitive', 'Metaphysical');
create table "Products"
(
	id serial primary key,
	name varchar(100) not null,
	price numeric(20,2) not null,
	type "ProductType" not null,
	description varchar(500)
);
insert into "Products" (name, price, type, description) values
('Burning',20.00,'Physical','The sensation of being on fire, usually because one is on fire.'),
('Crying', 3.00, 'Physical', 
	"The rapid leaking of one's dihydrogen monoxide content from one or more eye sockets. \nA critical wound that must be cauterized to stem the moisture loss.\nAlso a delicacy in French film.");
('Soul Crushing',70.00,'Metaphysical',"The crushing of one's soul. Actually a pretty simple concept, all things considered.");
select * from "Products";