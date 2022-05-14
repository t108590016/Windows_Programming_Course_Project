using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2.Tests
{
    [TestClass()]
    public class ClassTimeTests
    {
        PrivateObject _classTimePrivate;
        ClassTime _testClassTime;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _testClassTime = new ClassTime();
            _classTimePrivate = new PrivateObject(_testClassTime);
        }

        //測試IsNull()
        [TestMethod()]
        public void IsNullTest()
        {
            Assert.AreEqual(true, _testClassTime.IsNull());
        }


        //測試CheckSameTime
        [TestMethod()]
        public void CheckSameTimeTest()
        {
            List<string> time = new List<string>();
            List<string> anotherTime = new List<string>();
            time.Add("1 2 3");
            anotherTime.Add( "3 4 5" );
            for (int i = 0; i < 6; i++)
            {
                time.Add("");
                anotherTime.Add("");
            }
            _testClassTime._classTimeList = time;
            ClassTime anotherClassTime = new ClassTime(anotherTime);

            Assert.IsTrue(_testClassTime.CheckSameTime(anotherClassTime));
        }

        //測試Equal
        [TestMethod()]
        public void CheckEqual()
        {
            List<string> time = new List<string>();
            List<string> anotherTime = new List<string>();
            time.Add("1 2 3");
            anotherTime.Add("3 4 5");
            for (int i = 0; i < 6; i++)
            {
                time.Add("");
                anotherTime.Add("");
            }
            _testClassTime._classTimeList = time;
            ClassTime anotherClassTime = new ClassTime(anotherTime);
            Assert.IsFalse(_testClassTime.Equal(anotherClassTime));
            anotherClassTime._classTimeList = time;
            Assert.IsTrue(_testClassTime.Equal(anotherClassTime));
        }
    }
}