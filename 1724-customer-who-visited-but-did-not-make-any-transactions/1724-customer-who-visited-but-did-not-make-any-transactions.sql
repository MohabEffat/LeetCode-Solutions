/* Write your T-SQL query statement below */
select v.customer_id, COUNT(*) AS count_no_trans
from Visits v left join Transactions t
on V.visit_id = T.visit_id
where T.visit_id IS NULL
group by v.customer_id
