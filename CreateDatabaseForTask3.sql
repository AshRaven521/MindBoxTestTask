CREATE DATABASE MindBoxTestTask;

USE [MindBoxTestTask];
CREATE TABLE Products (
	Id INT PRIMARY KEY,
	ProductName NVARCHAR(200)
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(100)
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Products(Id, ProductName) VALUES
	(1, 'Lenovo Thinkpad X1'),
	(2, 'Oak table'),
	(3, 'Nissan Teana'),
	(4, 'Logitech keyboard'),
	(5, 'Leather chair');

INSERT INTO Categories(Id, CategoryName) VALUES
	(1, 'Computer'),
	(2, 'Furniture'),
	(3, 'Car'),
	(4, 'Computer device'),
	(5, 'Everyday items');

INSERT INTO ProductCategories(ProductId, CategoryId) VALUES
	(1, 1),
	(2, 2),
	(2, 5),
	(3, 3),
	(4, 4),
	(4, 5),
	(5, 4),
	(5, 5);
