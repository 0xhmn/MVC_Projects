using System;
using System.Diagnostics;
using System.Linq;
using GeekQuiz.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private TriviaContext db = new TriviaContext();
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            //var test = db.TriviaQuestions.Where(q => q.Id == 2).ToString();
            var test = db.TriviaQuestions.Take(100);
            foreach (var item in test)
            {
                //TestContext.WriteLine(item.ToString());
                //Console.WriteLine(item.ToString());
                System.Diagnostics.Debug.WriteLine(item.ToString());
            }
            System.Diagnostics.Debug.WriteLine("from test condolw");
        }
    }
}
