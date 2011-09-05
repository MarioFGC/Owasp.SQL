using System;//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Owasp.SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            prepare();

            //sqlInjection();
            //sqlParameters();
            linq();
            viewData();
            Console.ReadLine();
        }

        static void prepare()
        {
            using (var db = new OwaspExampleDataContext("Data Source=(local);Initial Catalog=OwaspExample;Integrated Security=True"))
            {
                db.ExecuteCommand("delete from Cars");
                db.ExecuteCommand("delete from PrivateData");

                var pd1 = new PrivateData();
                pd1.Username = "Mario";
                pd1.Secret = "Secreto de la vida, el universo y de todo: 42";
                db.PrivateDatas.InsertOnSubmit(pd1);

                var pd2 = new PrivateData();
                pd2.Username = "Camilo";
                pd2.Secret = "Secreto de la vida, el universo y de todo: 44";
                db.PrivateDatas.InsertOnSubmit(pd2);


                var car1 = new Car();
                car1.CarName = "Bugatti Beyron";
                db.Cars.InsertOnSubmit(car1);

                var car2 = new Car();
                car2.CarName = "Ferrari FXX";
                db.Cars.InsertOnSubmit(car2);

                db.SubmitChanges();
            }
        }

        static void viewData()
        {
            using (var db = new OwaspExampleDataContext("Data Source=(local);Initial Catalog=OwaspExample;Integrated Security=True"))
            {
                var cars = (from c in db.Cars
                           select c).ToList();

                cars.ForEach( c => Console.WriteLine(c.CarName));

                var secrets = (from s in db.PrivateDatas select s).ToList();

                secrets.ForEach(s => Console.WriteLine("Usuario: " + s.Username + " Secreto: " + s.Secret));
            }
        }


        static void sqlInjection()
        {
            using (var connection = new SqlConnection("Data Source=(local);Initial Catalog=OwaspExample;Integrated Security=True"))
            {
                connection.Open();
                string carToInsert = "' DELETE PrivateData --";


                using (SqlCommand command = new SqlCommand())
                {

                    command.CommandText = "select CarId, CarName from Cars where Carname = '" + carToInsert + "'";
                    command.Connection = connection;
                    //var cars = db.ExecuteQuery<Car>(" '" + carToInsert + "'");

                    var reader = command.ExecuteReader();            
                }

            }
            
        }

        static void sqlParameters()
        {
            using (var connection = new SqlConnection("Data Source=(local);Initial Catalog=OwaspExample;Integrated Security=True"))
            {
                connection.Open();
                string carToInsert = "' DELETE PrivateData --";


                using (SqlCommand command = new SqlCommand())
                {

                    command.CommandText = "select CarId, CarName from Cars where Carname = '@carname'";
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("carname", carToInsert));
                    //var cars = db.ExecuteQuery<Car>(" '" + carToInsert + "'");

                    var reader = command.ExecuteReader();

                    if (reader.RecordsAffected > 0)
                        return;
                    reader.Close();
                }

                using (SqlCommand command = new SqlCommand())
                {

                    command.CommandText = "insert into cars (CarName) values (@carname)";
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("carname", carToInsert));
                    command.ExecuteNonQuery();
                }
            }
        }

        static void linq()
        {
            using (var db = new OwaspExampleDataContext("Data Source=(local);Initial Catalog=OwaspExample;Integrated Security=True"))
            {
                string carToInsert = "' DELETE PrivateData --";


                var existentCar = (from c in db.Cars
                                   where c.CarName == carToInsert
                                   select c)
                                  .SingleOrDefault();

                if(existentCar != null)
                    return;

                var newCar = new Car();
                newCar.CarName = carToInsert;

                db.Cars.InsertOnSubmit(newCar);
                db.SubmitChanges();

            }
        }


    }
}
