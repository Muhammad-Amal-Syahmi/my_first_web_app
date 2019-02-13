
using System.Collections.Generic;
using my_first_web_app.Models;

namespace my_first_web_app.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}