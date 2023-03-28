﻿using DataBindingPractice.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingPractice.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = new List<Person>();

        public PeopleViewModel()
        {
            People.Add(new Person() 
            { 
                Name = "John", 
                Age = 42, 
                Married = true, 
                BirthDate = new DateTime(1980, 1, 1), 
                Weight = 80, 
                LunchTime = new TimeSpan(12, 30, 0) 
            });
            People.Add(new Person() 
            { 
                Name = "Mary",
                Age = 35,
                Married = false, 
                BirthDate = new DateTime(1980, 1, 1),
                Weight = 60, 
                LunchTime = new TimeSpan(13, 30, 0) 
            });
            People.Add(new Person() 
            { 
                Name = "Bob",
                Age = 25,
                Married = true,
                BirthDate = new DateTime(1980, 1, 1), 
                Weight = 40, 
                LunchTime = new TimeSpan(14, 30, 0) 
            });
            People.Add(new Person()
            { 
                Name = "Jane",
                Age = 22,
                Married = false,
                BirthDate = new DateTime(1980, 1, 1),
                Weight = 30,
                LunchTime = new TimeSpan(15, 30, 0)
            });
            People.Add(new Person() 
            { 
                Name = "Jack", 
                Age = 18, 
                Married = true, 
                BirthDate = new DateTime(1980, 1, 1),
                Weight = 20, 
                LunchTime = new TimeSpan(16, 30, 0)
            });
        }
    }
}