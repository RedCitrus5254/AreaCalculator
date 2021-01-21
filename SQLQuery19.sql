SELECT Products.name, Categories.name
FROM Products left join Categories
ON Products.CategoryId = Categories.Id