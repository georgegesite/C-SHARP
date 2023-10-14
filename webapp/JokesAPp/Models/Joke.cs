using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JokesAPp.Models
{
    public class Joke
    {
        //Properties
        //prop - shorcut to create a propSerpty | hit tab twice to auto generate
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //Methods
        //ctor - create a consturctor method
        public Joke()
        {

        }

    }
}