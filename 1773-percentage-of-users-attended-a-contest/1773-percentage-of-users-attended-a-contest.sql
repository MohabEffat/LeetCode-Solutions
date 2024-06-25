/* Write your T-SQL query statement below */
select r.contest_id, Round(count(DISTINCT user_id) * 100.0/(select count(user_id) from users), 2) as percentage
from  Register r 
group by r.contest_id
ORDER BY percentage DESC,contest_id;