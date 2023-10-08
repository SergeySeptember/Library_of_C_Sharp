namespace Code_Library_Console
{
    public class PracticeDB
    {
        /*
            Напишите LINQ запрос, чтобы выбрать всех клиентов из базы данных, у которых страна равна "USA".
            var resLINQ = db.customers.Where(x => x.country == "USA");
            var resSQL = db.customers.FromSqlRaw("SELECT * FROM customers WHERE country = 'USA'");

            Получите список всех продуктов из базы данных, отсортированных по имени в алфавитном порядке.
            var resLINQ = db.products.OrderBy(x => x.product_name);
            var resSQL = db.products.FromSqlRaw("SELECT * FROM products ORDER BY product_name");

            Сгруппируйте заказы по странам клиентов и подсчитайте количество заказов для каждой страны.
            var resLINQ = db.orders
                            .Join(db.customers, order => order.customer_id, customer => customer.customer_id, (order, customer) => 
                            new { Order = order, Customer = customer })
                            .GroupBy(result => result.Customer.country)
                            .Select(group => new
                            {
                                Country = group.Key,
                                OrderCount = group.Count()
                            });
            var resSQL = db.products.FromSqlRaw("SELECT c.country, count(o.order_id) from customers c join orders o using (customer_id) group by c.country ");

            Получите список продуктов и соответствующих им поставщиков, используя соединение таблиц.
            var resLINQ = db.products
                            .Join(db.suppliers, products => products.supplier_id, suppliers => suppliers.supplier_id, (product, supplier) =>
                            new { Product = product, Supplier = supplier });
            var resSQL = db.products.FromSqlRaw("select p.product_name, s.company_name from products p join suppliers s using (supplier_id)");

            Найдите общее количество продуктов, доступных в магазине, и среднюю цену продукта.
            var resLINQ = db.products.Sum(product => product.units_in_stock);
            var resLINQ2 = db.products.Average(product => product.unit_price);
            var resSQL = db.products.FromSqlRaw("select SUM(p.units_in_stock) , AVG(p.unit_price) from products p");

            Выберите заказы, у которых сумма больше 100 долларов.
            var resLINQ = db.order_details.Count(od => od.unit_price > 100);
            var resSQL = db.order_details.FromSqlRaw("select COUNT(order_id) from order_details od where od.unit_price > 100");

            // Напишите LINQ запрос, чтобы получить список клиентов, которые сделали заказы в течение последних 3 месяцев (дата взята из последнего заказа т.к. заказаов не было 25 лет в БД).
            var maxDate = db.orders.Max(order => order.order_date);
            var tempDate = (DateTime)maxDate;
            DateTime threeMonthsAgo = tempDate.AddMonths(-3).ToUniversalTime();

            var resLINQ = db.customers.Join(db.orders, customer => customer.customer_id, order => order.customer_id, (customer, order) =>
                                       new { Customer = customer, Order = order })
                                       .Where(x => x.Order.order_date > threeMonthsAgo)
                                       .Select(x => x.Customer.company_name)
                                       .Distinct()
                                       .ToList();

            var resSQL = db.customers.FromSqlRaw("select distinct c.company_name from customers c join orders o using(customer_id)where o.order_date >= (select Max(o.order_date)from orders o limit 1) - interval '3 month'");
            */
    }
}
