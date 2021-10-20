--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers
Select * from Customers where City='Berlin'

select*from Products where CategoryID=1 or CategoryID=3
select*from Products where CategoryID=1 and UnitPrice>=10

select*from Products where CategoryID=1 order by UnitPrice desc  --asc-ascending/artan desc-azalan/descending

select count(*)  Adet from Products where CategoryID=2

--hangi kategoride kaç farklı ürün var
select CategoryID,count(*) from Products group by CategoryID having COUNT(*)<10

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10


select  Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where products.UnitPrice>10
 
--DTO/ Data Transformation Object

select*from Products p inner join [Order Details] od
on p.ProductID=od.ProductID 
inner join Orders o
on o.OrderID=od.OrderID

select*from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null