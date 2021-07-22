﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        // primary key - generated by database
        public int ContactId { get; set; }         

        [Required(ErrorMessage = "Please enter a first name.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        public string Email { get; set; }

        public string Organization { get; set; } 
        public DateTime DateAdded { get; set; }   

        // Step 2: foreign key code goes here

        [Range(0, 100000000, ErrorMessage ="Please Enter a Category.")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        // Step 4: Modify slug here
        public string Slug => Lastname?.Replace(' ', '-').ToLower() 
        + ContactId.ToString();
    }
}