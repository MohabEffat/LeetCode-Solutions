/* Write your T-SQL query statement below */
Select *
from Cinema
where description != 'boring' and id % 2 != 0
order by rating desc