Create Database Minecraft_Music
Use Minecraft_Music

Create Table Music
(
	ID_Music int Primary Key identity,
	Author varchar(255),
	Name varchar(255),
	Picture varbinary(max)
)

insert into  Music(Author,Name,Picture)
values
('Lena Raine','Pigstep',
(select * from openrowset(bulk 'C:\Users\Вадим\Desktop\Учеба\Задания по Аскару\Практика 1 на гит хаб\Материалы\PigStep.png', SINGLE_BLOB) AS Picture)),
('Lena Raine','Otherside',
(select * from openrowset(bulk 'C:\Users\Вадим\Desktop\Учеба\Задания по Аскару\Практика 1 на гит хаб\Материалы\Otherside.png', SINGLE_BLOB) AS Picture)),
('C418','Wait',
(select * from openrowset(bulk 'C:\Users\Вадим\Desktop\Учеба\Задания по Аскару\Практика 1 на гит хаб\Материалы\Wait.png', SINGLE_BLOB) AS Picture)),
('C418','Mall',
(select * from openrowset(bulk 'C:\Users\Вадим\Desktop\Учеба\Задания по Аскару\Практика 1 на гит хаб\Материалы\Mall.png', SINGLE_BLOB) AS Picture))