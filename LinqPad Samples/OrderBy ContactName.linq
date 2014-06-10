<Query Kind="Expression">
  <Connection>
    <ID>2885a0de-049d-4fec-8965-e0a039e01567</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cust in Customers
where cust.City == "London" //&& cust.ContactName.Contains("Devon")
orderby cust.ContactName
select cust
