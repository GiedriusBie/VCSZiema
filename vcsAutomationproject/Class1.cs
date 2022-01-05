using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vcsAutomationproject
{
    public class Class1
    {
        // 4 yra lyginis skaicius
        //   dabar 18h

        [Test]
        public static void Testif4IsEven()
        {

            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even!");

        }

        [Test]
        public static void Testnow17()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(10, currentTime.Hour, "dabar ne 17 valanda");
        }


        [Test]
        public static void TestIf995IsEven()
        {

            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "turejo buti be liekanos");

        }
        [Test]
        public static void TestIsTodayIsMonday()
        {
            DateTime currentTime= DateTime.Now;
            Assert.AreEqual(DayOfWeek.Monday, currentTime.DayOfWeek, "Siandien ne pirmadienis");

        }
        [Test]
        public static void TestWait5Seconds()
        {
            Thread.Sleep(5000);
        }



    }
}
