select ProductName adı, ProductID,UnitPrice  from Products --product sınıfından istenilen sutunları listeler
select * from Customers where Country='Germany'
select Country,ContactName from Customers where Country='Germany' --Customer tablosundan ülkesi almanya olanların adını ve ğlkesini listele
select ProductName from Products where CategoryID=1 or SupplierID=3 or CategoryID=4
select ProductName from Products where CategoryID=2 and UnitPrice>6
select ProductName,ProductID,UnitPrice from Products where categoryId=1 and UnitPrice>10 order by UnitPrice
select * from Customers where Country in('Spain','USA','France')--IN
select*from Customers where CustomerID in(select CustomerID from Orders)-- sipariş veren müşterileri seçer
select*from Customers where CustomerID not in(select CustomerID from Orders)-- sipariş vermeyen müşterileri seçer
select COUNT(*)  Adet from Products 
select CategoryID,COUNT(*)  from Products group by CategoryID
select CategoryID,COUNT(*)  from Products  group by CategoryID 
select CategoryID,COUNT(*)  from Products where UnitPrice>10 group by CategoryID 
select CategoryID,COUNT(*)  from Products  group by CategoryID having COUNT(*)>9
select CategoryID,COUNT(*)  from Products where UnitPrice>10 group by CategoryID having COUNT(*)>9
select Products.ProductName,Categories.CategoryName,Products.ProductID,Products.UnitPrice
from Products inner join Categories on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10
select * from Products left join [Order Details] on Products.ProductID=[Order Details].ProductID
select* from Customers inner join Orders on Customers.CustomerID=Orders.CustomerID
select* from Customers left join Orders on Customers.CustomerID=Orders.CustomerID-- solda olup sağda olmayanları da listele
select* from Customers left join Orders on Customers.CustomerID=Orders.CustomerID  where Orders.CustomerID is null 
--Insert Into
Insert Into Customers (CustomerID, CompanyName ,Address, City, PostalCode, Country)
Values ('AAAAB', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway')
select * from Customers

--Update komutu
Update Customers set Country='TURKEY',ContactName='Angelino Pery' where CustomerID='ALFKI'
select* from Customers
--Delete komutu
Delete from Customers where  Country='Norway'
select* from Customers
--Select Top
select top 5 CustomerID,City,Country from Customers where Country='Germany'
--Mın Max
select  MIN(UnitPrice) from Products
select  Max(UnitPrice)  Highestprice from Products
--sum
select * from [Order Details] where ProductID=50
select SUM(UnitPrice)from [Order Details]
select SUM(UnitPrice) toplamfiyat from [Order Details] where ProductID=50
Select SUM(Products.UnitPrice*[Order Details].Quantity)
as nolusatılantoplamurun from [Order Details] left join Products 
on [Order Details].ProductID=Products.ProductID where Products.ProductID=31
--avg
select AVG(unitprice)from Products where CategoryID=5
select* from Products where UnitPrice> (select AVG(UnitPrice)from Products)
--self joın
SELECT A.CustomerID AS Customerıd1, B.CustomerID AS Customerıd2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID and A.Country='MEXİCO'
AND A.City = B.City
ORDER BY A.City;
--Unıon
select Country,City from Customers
union 
select Country,City from Suppliers
select City from Customers where Country='Germany'
union
select City from Suppliers where Country='USA'
order by City
--GROUPBY
select Country,COUNT(*)  from Customers group by Country order by COUNT(*)
