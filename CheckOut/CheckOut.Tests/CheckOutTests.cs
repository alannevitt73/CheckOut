using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Tests
{
    public class CheckOutTests
    {
        private ICheckout _CheckOut;

        [SetUp]
        public void CheckOutSetUp()
        {
            _CheckOut = new CheckOut();
        }

        [Test]
        public void EnsureEmptyCartZero()
        {

            for (int i = 0; i <= 3; i++)
            {
                _CheckOut.Scan(new Banana());
            }

            Assert.That(_CheckOut.Total, Is.EqualTo(2));
        }

        [Test]
        public void Test4Bananas()
        {
            // 4 bananas should cost £2

            Assert.That(_CheckOut.Total, Is.EqualTo(0));
        }

        [Test]
        public void Test5Bananas()
        {
            // 5 bananas should cost 2.7 (4 for £2 and 1 for .70) 
            for (int i = 0; i <= 4; i++)
            {
                _CheckOut.Scan(new Banana());
            }
            
            Assert.That(_CheckOut.Total, Is.EqualTo(2.7));
        }

        [Test]
        public void Test6Oranges()
        {
            // 6 Oranges should cost £1.8 (3 for .90p)

            for (int i = 0; i <= 5; i++)
            {
                _CheckOut.Scan(new Orange());
            }

            Assert.That(_CheckOut.Total, Is.EqualTo(1.8));
        }

        [Test]
        public void Test7Oranges()
        {
            // 7 Oranges should cost £2.25 (3 for .90p and 1 for 45p)
            for (int i = 0; i <= 6; i++)
            {
                _CheckOut.Scan(new Orange());
            }

            Assert.That(_CheckOut.Total, Is.EqualTo(2.25));
        }

        [Test]
        public void Test3Apples()
        {
            // 3 Apples should cost £1.5
            for (int i = 0; i <= 2; i++)
            {
                _CheckOut.Scan(new Apple());
            }

            Assert.That(_CheckOut.Total, Is.EqualTo(1.5));
        }


        [Test]
        public void TestMixedCheckout()
        {
            //3 apples (1.5)
            //3 bananas (1.7)
            //5 Oranges (.9 + .9 = 1.8)
            //  total = £5
            _CheckOut.Scan(new Apple());
            _CheckOut.Scan(new Banana());

            _CheckOut.Scan(new Orange());
            _CheckOut.Scan(new Orange());

            _CheckOut.Scan(new Apple());
            _CheckOut.Scan(new Banana());

            _CheckOut.Scan(new Orange());
            _CheckOut.Scan(new Orange());

            _CheckOut.Scan(new Apple());
            _CheckOut.Scan(new Banana());


            _CheckOut.Scan(new Orange());


            Assert.That(_CheckOut.Total, Is.EqualTo(5));
        }
    }
}
