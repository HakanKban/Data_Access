using EF_LINQ_SQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_LINQ_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db = new NORTHWNDEntities();
        private void button1_Click(object sender, EventArgs e)
        {
          // tolist()
            dataGridView1.DataSource = db.Products
                .ToList();

            //where
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .ToList();

            //orderby()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .OrderBy(x => x.ProductID)
                .ToList();

            //thenby()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .OrderBy(x => x.ProductID)
                .ThenBy(x => x.UnitsInStock)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

            //groupby()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 50).OrderBy(x => x.ProductID).ThenBy(x => x.UnitsInStock).ThenByDescending(x => x.UnitPrice).GroupBy(x => x.Categories.CategoryName).ToList();

            //tolookup()
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 50).OrderBy(x => x.ProductID).ThenBy(x => x.UnitsInStock).ThenByDescending(x => x.UnitPrice).ToLookup(x => x.Categories.CategoryName).ToList();

            //select()
            dataGridView1.DataSource = db.Products
                .Where(x => x.UnitsInStock >= 50)
                .Select(x =>
                new
                {
                    x.ProductID,
                    x.ProductName,
                    x.UnitPrice,
                    x.Category,
                    x.UnitsInStock
                }).OrderBy(x => x.ProductID)
                .ThenBy(x => x.UnitsInStock)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

            //all()
            bool isTrue = db.Products.All(x => x.UnitsInStock >= 50);
            switch (isTrue)
            {
                case false:
                    MessageBox.Show("Not All Elements >= 50");
                    break;
                default:
                    MessageBox.Show("All Elements >= 50");

                    break;
            }

            //any()
            bool isTrue1 = db.Products.Any(x => x.UnitsInStock >= 50);
            switch (isTrue1)
            {
                case false:
                    MessageBox.Show("Not All Elements >= 50");
                    break;
                default:
                    MessageBox.Show("At Least One Element >= 50");

                    break;
            }

            dataGridView1.DataSource = db.Products

                .Where(x => x.UnitsInStock >= 50 && x.ProductName.Contains("a"))
                .Select(x =>
                new {
                    x.ProductID,
                    x.ProductName,
                    x.UnitPrice,
                    x.Category,
                    x.UnitsInStock
                }).ToList();


            //Performs a custom aggregation operation on the values in the collection.
            List<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var customAggregate = strList.Aggregate((s1, s2) => s1 + "<=> " + s2);

            MessageBox.Show(customAggregate);

            //average
            decimal? average = db.Products.Average(x => x.UnitPrice);

            MessageBox.Show($"Average Of UnitPrice: {average.ToString()}");

            //count()
            var productCount = db.Products.
                Where(x => x.ProductName.Contains("a"))
                .Count(x => x.UnitPrice < 25);

            MessageBox.Show($"Count Of Products :{productCount}");

            //min()
            var min = db.Products.Min(x => x.UnitPrice);

            MessageBox.Show($"Min Of Products :{min}");

            //max()
            var max = db.Products.Max(x => x.UnitPrice);

            MessageBox.Show($"Max Of Products :{max}");

            //sum()
            var sum = db.Products.Sum(x => x.UnitsInStock);

            MessageBox.Show(sum.ToString());

            //first()
            Categories category = db.Categories.First(x => x.CategoryName == "SeaFood");

            MessageBox.Show($"{category.CategoryName}");

            //firstordefault does not throws exception
            Categories categoryy = db.Categories.FirstOrDefault(x => x.CategoryID == 1);

            MessageBox.Show($"{categoryy.CategoryName}");

        }

        public void Employees1()
        {
            var emp = from x in db.Employees
                      select new
                      {
                          x.FirstName,
                          x.LastName,
                          x.Title,
                          x.BirthDate

                      };
            dataGridView1.DataSource = emp.ToList();


        }

        public void Employees2()
        {
            var emp = from x in db.Employees
                      where x.EmployeeID >= 2 && x.EmployeeID < 8
                      select new
                      {
                          x.FirstName,
                          x.LastName,
                          x.Title,
                          x.BirthDate

                      };
            dataGridView1.DataSource = emp.ToList();
        }
  
        public void Employees3()
        {
            var result = from emp in db.Employees
                        where emp.TitleOfCourtesy == "Mr." && SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now) > 60
                         select new
                         {
                             Adı = emp.FirstName,
                            Soyadı = emp.LastName,
                             Title = emp.TitleOfCourtesy,
                            Yas = SqlFunctions.DateDiff("Year", emp.BirthDate, DateTime.Now)
                         };

                             dataGridView1.DataSource = result.ToList();
        }

        public void OrderDetails()
        {

            var result = from od in db.Order_Details
                         orderby od.Quantity * od.UnitPrice * (int)Math.Floor(1 - od.Discount)
                         group od by od.OrderID into ky
                         select new
                         {
                             OrderId = ky.Key,
                             Total = ky.Sum(x => x.Quantity * x.UnitPrice * (int)Math.Floor(1 - x.Discount) )
                         };
            dataGridView1.DataSource = result.ToList();


        }
        public void Join1()
        {
            dataGridView1.DataSource = db.Categories
                .Join(db.Products, c => c.CategoryID, p => p.CategoryID, (c, p) => new { c, p })
                .GroupBy(x => x.c.CategoryName)
                .Select(x => new
                {

                    categoryName = x.Key,
                    Count = x.Sum(z => z.p.UnitsInStock)
                }
                )
                .OrderByDescending(x => x.Count)
                .ToList();



        }
        public void Join2()
        {
            dataGridView1.DataSource =
                db.Employees.Join(db.Orders, emp => emp.EmployeeID, o => o.EmployeeID, (emp, o) => new { emp, o })
                .Join(db.Order_Details, ord => ord.o.OrderID, od => od.OrderID, (ord, od) => new { ord, od })
                .GroupBy(x => x.ord.emp.FirstName)
                .Select(x => new
                {
                    Calisan = x.Key,
                    Toplam = x.Sum(z => z.od.Quantity * z.od.UnitPrice * (int)Math.Floor(1 - z.od.Discount))



                })
                .OrderByDescending(x => x.Toplam).ToList();
        }
        public void Join3()
        {
            dataGridView1.DataSource =
               db.Products.Join(db.Order_Details, p => p.ProductID, od => od.ProductID, (p, od) => new { p, od })
                           .GroupBy(x => x.p.ProductName)
                           .Select(x => new
                          {
                              UrunAdi = x.Key,
                              Miktar = x.Sum(z => z.od.Quantity),
                               Gelir = x.Sum(z => z.od.Quantity * z.od.UnitPrice * (int)Math.Floor(1 - z.od.Discount))
                           })
                         .OrderByDescending(x => x.Gelir)
                          .ToList();
        }
    }
}
