--select * from filecolumns
--delete  filecolumns

--truncate table filecolumns

--insert into filecolumns(ColumnName) values('1');
--insert into filecolumns(ColumnName) values('2');
--insert into filecolumns(ColumnName) values('3');

--select * from filecolumns where Columnname in (

select Id,a.ColumnName,b.Cnt from fileColumns a inner join 
(select ColumnName,count(1) cnt from filecolumns group by ColumnName having count(ColumnName)>1) b
on a.ColumnName = b.ColumnName 
order by a.ColumnName

select Distinct a.ColumnName from fileColumns a inner join 
(select ColumnName,count(1) cnt from filecolumns group by ColumnName having count(ColumnName)>1) b
on a.ColumnName = b.ColumnName 
order by a.ColumnName



select distinct ColumnName from filecolumns