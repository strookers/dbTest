using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using DAL;

namespace BLL
{
    public class MovieCtr
    {
        public List<Movie> GetMovieList()
        {
            return DBMovie.GetMovieList();
        }

        public DataSet GetMovieSet()
        {
            return DBMovie.GetMovieSet();
        }

        public Movie FindMovieById(int id)
        {
            return DBMovie.FindMovieById(id);
        }

        public Movie FindMovieByTitle(string title)
        {
            return DBMovie.FindMovieByTitle(title);
        }

        public void CreateMovie(Movie m)
        {
            DBMovie.CreateMovie(m.Title, m.Description, m.Premiere);
        }
    }
}
