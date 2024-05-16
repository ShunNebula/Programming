using MyProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram.Resourses
{
    public class MyInstitution
    {
        private string _title;
        private string _address;
        private string _category;
        private double _rating;

        public string Title
        { get { return _title; } set {  _title = value; } }

        public string Address
        { get { return _address; } set { _address = value; } }

        public string Category
        { get { return _category; } set { _category = value; } }

        public double Rating
        { 
            get { return _rating; } 
            set 
            { 

                _rating = value; 
            } 
        }

        public MyInstitution()
        {
            
        }

        public MyInstitution(string title, string address, string category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
        }
    }
}
