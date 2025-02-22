﻿using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    class LibraryTest
    {
        [Test]
        public void shouldAddToStock()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks", "JJ Abrams", "jjabrams@gmail.com", "abramsbooks.com");

            library.addToStock(article);
            library.getStocks();

            Assert.IsTrue(library.getStocks().Count == 1);
        }

        [Test]
        public void shouldnotCheckIn()
        {
            Library library = new Library();

            Assert.IsTrue(library.checkIn("Jagasgaecks") == "item is not part of the library's collection");
        }

        [Test]
        public void shouldCheckOut()
        {
            Library library = new Library();
            Article article = new Article("JUnit Rocks", "JJ Abrams", "jjabrams@gmail.com", "abrams.net");

            Assert.IsTrue(library.checkOut("JUnit Rocks") == "item has been checked out");
            // Assert.Equals("item is currently on loan", article.checkOut());

        }
    }
}
