DROP DATABASE SaleManagement

CREATE DATABASE SaleManagement
Go

USE SaleManagement
GO





CREATE TABLE Member
(
  MemberId INT NOT NULL PRIMARY KEY,
  Email  VARCHAR(100) NOT NULL,
  CompanyName VARCHAR(40) NOT NULL,
  City VARCHAR(15) NOT NULL,
  Country VARCHAR(15) NOT NULL,
  [Password] VARCHAR(30) NOT NULL,
);

CREATE TABLE [Order]
(
  OrderId INT NOT NULL PRIMARY KEY,
  OrderDate DATETIME NOT NULL,
  MemberId int not null,
  RequiredDate DATETIME NULL,
  ShippedDate DATETIME NULL,
  Freight MONEY NULL,
);

CREATE TABLE Product
(
  ProductId INT NOT NULL PRIMARY KEY,
  Category INT NOT NULL,
  ProductName VARCHAR(40) NOT NULL,
  [Weight] VARCHAR(20) NOT NULL,
  UnitPrice MONEY NOT NULL,
  UnitsInStock INT NOT NULL,
);

CREATE TABLE OrderDetail
(
  ProductId INT NOT NULL,
  OrderId INT NOT NULL,
  UnitPrice MONEY NOT NULL,
  Quantity INT NOT NULL,
  Discount FLOAT NOT NULL,
  PRIMARY KEY (ProductId,OrderId)
);

ALTER TABLE [Order]
ADD FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
ALTER TABLE OrderDetail
ADD FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
ALTER TABLE OrderDetail
ADD FOREIGN KEY (OrderId) REFERENCES [Order](OrderId)

