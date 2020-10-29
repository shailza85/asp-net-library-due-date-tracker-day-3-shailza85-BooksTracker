﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksTracker.Models.Exceptions
{
    public class BookTitleValidationException : Exception
    {
        // A list of exceptions to be thrown as one.
        public List<Exception> SubExceptions { get; set; } = new List<Exception>();

        // Override our message with a summary.
        public override string Message => $"There are {SubExceptions.Count} exceptions.";

        // When we construct this exception without a messsage, we get an empty sub-list which we can populate.
        public BookTitleValidationException() : base()
        { }

        public BookTitleValidationException(string message) : base()
        {
            // When we construct this exception with a message, it gets added to the subexceptions list.
            SubExceptions.Add(new Exception(message));
        }
    }
}