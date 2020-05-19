/*
 * 
 * <copyright file = "Exceptions"   Developer: João Veloso </copyright>
 * <author>jngveloso</author>
 * <email>jngveloso@gmail.com</email>
 * <date>5/19/2020 3:56:13 PM</date>
 * <description></description>
 * 
 */




using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBarcelos
{
    public class DateExceptions : ApplicationException
    {
        public DateExceptions() : base("Wrong Date")
        {
        }

        public DateExceptions(string s) : base(s) { }

        public DateExceptions(string s, Exception exception)
        {
            throw new DateExceptions(exception.Message + " - " + s);
        }




    }
}