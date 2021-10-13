using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMovieLibrary;

namespace MyMovieBusiness
{

    // This is business layer for Movie management application
    public class MyMovie
    {
        // Creating the object of Data layer class
        Movieclass movie = new Movieclass();

        // InsertData method calls Insert method in class of  Data layer 
        public string InsertData(movie obj)
        {
            return (movie.InsertData(obj));
        }

        // UpdateData method calls Update method in class of  Data layer 
        public string UpdateData(movie obj)
        {
            return (movie.UpdateData(obj));
        }

        // DeleteData method calls Delete method in class of  Data layer 
        public string DeleteData(movie obj)
        {
            return (movie.DeleteData(obj));
        }


    }
}
