using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IteratorDesignPattern {

    [TestClass]
    public partial class User {

        [TestMethod]
        public void TestMethod1() {

            var weekdays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // get an iterate and use it to print items of the collection...

            IIterator<string> iterator = new Iterator<string>(weekdays);

            while (iterator.MoveNext() == true) {

                Debug.WriteLine(iterator.Current.ToString());
            }
        }
    }
}
