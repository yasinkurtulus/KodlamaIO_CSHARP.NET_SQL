select ProductName adı, ProductID,UnitPrice  from Products --product sınıfından istenilen sutunları listeler
select * from Customers where Country='Germany'
select ContactName,Country from Customers where Country='Germany' --Customer tablosundan ülkesi almanya olanların adını ve ğlkesini listele
select ProductName from Products where CategoryID=1 or SupplierID=3 or CategoryID=4
select ProductName from Products where CategoryID=2 and UnitPrice>6
select ProductName,ProductID,UnitPrice from Products where categoryId=1 and UnitPrice>10 order by UnitPrice
select COUNT(*) Adet from Products 
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
