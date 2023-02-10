USE [MindBoxTestTask];

SELECT Products.ProductName, Categories.CategoryName
FROM Products, Categories, ProductCategories
WHERE Products.Id = ProductCategories.ProductId AND Categories.Id = ProductCategories.CategoryId