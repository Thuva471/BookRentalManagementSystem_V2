using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V2
{
    internal class BookRepository
    {
       string conectionstring = "Data Source = BookRentalManagement.db";
        public void createdatabase()
        {
            using (var connection = new SqliteConnection(conectionstring))
            {
                connection.Open();
                var commad = connection.CreateCommand();
                commad.CommandText = @"CREATE TABLE BOOKS(
                  BookId INTEGER PRIMARY KEY AUTOINGERMENT,
                  Title TEXT NOT NULL,
                  Author TEXT NOT NULL,
                  RentalPrice REAL NOT NULL);


                 INSERT INTO BOOKS(BookId,Title,Author,RentalPrice)
                 VALUSE('BOOK_001','Jeans ','Shankar',1.00 );";
                
                var athoget =commad.ExecuteNonQuery();
                Console.WriteLine($"athoget :{athoget}");
            }




        }

    }
    
}
