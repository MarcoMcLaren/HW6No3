SELECT * from sales.orders
SELECT * from sales.order_items
SELECT * from production.products
SELECT * from production.categories

SELECT * FROM sales.orders
INNER JOIN sales.order_items  ON sales.orders.order_id = sales.order_items.order_id
INNER JOIN production.products ON production.products.product_id = production.products.product_id
INNER JOIN production.categories ON production.products.category_id = production.categories.category_id
WHERE production.categories.category_id = 6
ORDER BY sales.orders.order_date



