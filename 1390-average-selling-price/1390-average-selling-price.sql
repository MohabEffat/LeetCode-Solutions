/* Write your T-SQL query statement below */
Select p.product_id, round(COALESCE (cast(SUM(p.price * u.units)as decimal) / NULLIF(SUM(u.units), 0), 0), 2) AS average_price
from Prices P left join UnitsSold U
on p.product_id = u.product_id and u.purchase_date between p.start_date and p.end_date
group by p.product_id