SELECT Name , Price From Products WHERE Price > 500;


------------------------------------------------------------------------------


Select YEAR(OrderDate) as year , COUNT(TotalAmount) as Total From Orders Group BY YEAR(OrderDate)



----------------------------------------------------------------------------------

SELECT  C.Name , SUM(O.TotalAmount) as Total
		FROM Orders AS O
		JOIN Products AS P
			ON O.ProductId=P.Id
			Join Categories AS C
			ON C.Id = P.CategoryId GROUP BY C.Name


----------------------------------------------------------------------------------

SELECT Name , Price From Products Order BY Price DESC



----------------------------------------------------------------------------------


SELECT   C.Name ,  Count(C.id) As CountOrder
		FROM Orders AS O
		JOIN Customers AS C
			ON O.CustomerId=C.Id
			GROUP BY C.Id , C.Name


-----------------------------------------------------------------------------------


			
			SELECT  C.Name , AVG(P.Price) as Average
		FROM Products AS P
		JOIN Categories AS C
			ON C.Id = P.CategoryId GROUP BY C.Name , C.Id


-------------------------------------------------------------------------------------

SELECT   P.Name AS NameProduct , C.Name As CategoryProduct
		FROM Products AS P
		JOIN Categories AS C
			ON C.Id = P.CategoryId Order By P.Name , c.Name


--------------------------------------------------------------------------------------

SELECT  C.Name , SUM(O.TotalAmount) as Total
		FROM Orders AS O
		JOIN Products AS P
			ON O.ProductId=P.Id
			Join Categories AS C
			ON C.Id = P.CategoryId 
			WHERE YEAR(O.OrderDate) = 2023
			GROUP BY C.Name

----------------------------------------------------------------------------------------

Select Month(OrderDate) as MonthDate , COUNT(Month(OrderDate)) as Total From Orders Group BY Month(OrderDate)
			


-----------------------------------------------------------------------------------------

SELECT O.CustomerId , C.Name , SUM(O.TotalAmount) From Orders O 
Join Customers C ON O.CustomerId = C.Id GROUP BY O.CustomerId , C.Name


------------------------------------------------------------------------------------------


SELECT C.Name , Count(C.Id) As CountOrder FROM Categories C
join Orders O ON C.Id = O.CustomerId
GROUP BY C.Name



----------------------------------------------------------------------------


Select C.Name , COUNT(O.CustomerId) As CountOrder  From Orders O 
join Customers C
On O.CustomerId = C.Id Group By O.CustomerId , C.Name
Order By CountOrder Desc


----------------------------------------------------------------------------

Select YEAR(OrderDate) as YearDate , COUNT(YEAR(OrderDate)) as Total From Orders Group BY Year(OrderDate)


-----------------------------------------------------------------------------


SELECT p.Name , COUNT(o.ProductId) As CountCustomer FROM Orders As O
join Customers As C On O.CustomerId = C.Id
join Products P On O.ProductId = P.Id 
Group By O.ProductId , p.Name
Order by CountCustomer Desc




Select * From Orders

Select * From Products

Select * From Categories


Select * From Customers