create database AddressBook
use AddressBook
create table Addressbook
(
	FirstName	varchar(50),
	LastName	varchar (50),
	Address		varchar(150),
	City		varchar(25),
	State		varchar(25),
	zip			BigInt,
	PhoneNumber BigInt,
	Email		varchar(50)
	)
	Insert into Addressbook
	(
	[FirstName] ,[LastName],[Address] ,[City],[State],[zip],[PhoneNumber],[Email]
	)
	Values
			('Vijay','kumar','rajpath','Patna','Bihar',8000001,87654321287,'vijya87348@gmail.com'),
			('Nitish','kumar','gandhi maidan','Patna','Bihar', 800005,654321287,'vijya87348@gmail.com'),
			('Rahul','Yadav','Rohini','Delhi','New Delhi',534342,43523254234,'rahul@gmail.com'),
			('Rohal','Goyal','pratap nagar','Delhi','New Delhi',534342,76523254234,'rohan@gmail.com')

	UPDATE Addressbook Set  address = 'nalanda' , City = 'Hilsa' where FirstName = 'Vijay' ;

	delete from Addressbook where FirstName = 'Rahul';

	Select * From Addressbook where City = 'Patna';
	Select * From Addressbook where State = 'New Delhi';

	SELECT COUNT(City) From Addressbook;
	SELECT COUNT(State) From Addressbook;
	SELECT COUNT(City)  From Addressbook where City = 'Patna';
	SELECT COUNT(State) From Addressbook where State = 'New Delhi';

	SELECT * FROM Addressbook Where City = 'Patna'
	Order by FirstName ASc; 

	Alter table AddressBook ADD type varchar(30);
	SELECT * FROM Addressbook;
	UPDATE Addressbook Set type = 'Friend' where FirstName = 'Vijay' or FirstName = 'Nitish' ;
	UPDATE Addressbook Set type = 'Family' where FirstName = 'Rahul';
	Select * From Addressbook where type = 'Friend';

	Select COUNT(type) From Addressbook 
	Select COUNT (type) From Addressbook where type = 'Friend';
	Select * From Addressbook