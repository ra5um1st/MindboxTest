# MindboxTest

# Вопрос 2

DB Schema

ProductsTable		      ProductsCategoriesTable		      CategoriesTable
	-Id					                -Id							            -Id
	-Name	      1----N		      -ProductId			N-----1	    -Name
						                  -CategoryId					
						
select products.Name, categories.Name
from ProductsTable products
left join ProductsCategoriesTable productsCategories on products.Id = productsCategories.ProductId
left join CategoriesTable categories on productsCategories.CategoryId = categories.Id
