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
(select * from openrowset(bulk 'C:\Users\�����\Desktop\�����\������� �� ������\�������� 1 �� ��� ���\���������\PigStep.png', SINGLE_BLOB) AS Picture)),
('Lena Raine','Otherside',
(select * from openrowset(bulk 'C:\Users\�����\Desktop\�����\������� �� ������\�������� 1 �� ��� ���\���������\Otherside.png', SINGLE_BLOB) AS Picture)),
('C418','Wait',
(select * from openrowset(bulk 'C:\Users\�����\Desktop\�����\������� �� ������\�������� 1 �� ��� ���\���������\Wait.png', SINGLE_BLOB) AS Picture)),
('C418','Mall',
(select * from openrowset(bulk 'C:\Users\�����\Desktop\�����\������� �� ������\�������� 1 �� ��� ���\���������\Mall.png', SINGLE_BLOB) AS Picture))