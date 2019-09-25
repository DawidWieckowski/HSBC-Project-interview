CREATE TABLE #employee 
(
	id int,
	name VARCHAR(20),
	surname VARCHAR(20)
)

CREATE TABLE #sales
(
	id int,
	employee int,
	day DATETIME,
	sum int
)

INSERT INTO #employee
VALUES (1, 'Damian', 'Damianowski'),
	(2, 'Mateusz', 'Mateuszowski'),
	(3, 'Andrzej', 'Andrzejowski'),
	(4, 'Bartek', 'Bartkowski');
	
INSERT INTO #sales
VALUES (1, 1, '9/9/2018', 200),
	(2, 1, '10/9/2019', 300),
	(3, 3, '9/9/2018', 500),
	(4, 2, '10/9/2019', 900);
	
select * 
from #employee

select *
from #sales
	
-- a)
select day, SUM(sum) as sum
from #sales
group by day

-- b)
select emp.id, SUM(ISNULL(sal.sum, 0)) as sum
from #employee emp
left join #sales sal on emp.id = sal.employee
group by emp.id

-- c)
select top 1 emp.id, SUM(ISNULL(sal.sum, 0)) as sum
from #employee emp
left join #sales sal on emp.id = sal.employee
group by emp.id
order by sum asc 

drop table #employee;
drop table #sales
