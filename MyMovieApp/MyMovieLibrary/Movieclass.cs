using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace MyMovieLibrary
{
    public class Movieclass
    {
        // creating object of Database Entity Connection
        MovieDetailsEntities movieDetails = new MovieDetailsEntities();

        // Method to insert data into table
        public string InsertData(movie obj)
        {
            movieDetails.movies.Add(obj);
            movieDetails.SaveChanges();
            return "Inserted";
        }

        public string UpdateData(movie obj)
        {
            movieDetails.Entry(obj).State = EntityState.Modified;
            movieDetails.SaveChanges();
            return "Updated";
        }

        public string DeleteData(movie obj)
        {
            movieDetails.Entry(obj).State = EntityState.Deleted;
            movieDetails.SaveChanges();
            return "Deleted";
        }



    }
}
