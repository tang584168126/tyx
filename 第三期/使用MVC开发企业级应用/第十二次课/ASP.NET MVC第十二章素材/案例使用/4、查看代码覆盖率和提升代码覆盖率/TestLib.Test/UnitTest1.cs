using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestLib;
namespace TestLib.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEvaluateScore()
        {
            ResultService srv = new ResultService();
            ScoreType actual;//实际值

            double score = 95;
            ScoreType expected = ScoreType.Advance;//期望值
            actual = srv.EvaluateScore(score);
            Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");

            score = 85;
            expected = ScoreType.Good;//期望值
            actual = srv.EvaluateScore(score);//实际值
            Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");

            score = 75;
            expected = ScoreType.Nomal;//期望值
            actual = srv.EvaluateScore(score);//实际值
            Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");

            score = 65;
            expected = ScoreType.Nomal;//期望值
            actual = srv.EvaluateScore(score);//实际值
            Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");

            score = 50;
            expected = ScoreType.Bad;//期望值
            actual = srv.EvaluateScore(score);//实际值
            Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");
        }

        [TestMethod]
        public void TestIsDigit()
        {
            bool expected1 = new ResultService().IsDigit("97.5");
            Assert.IsTrue(expected1);

            bool expected2 = new ResultService().IsDigit("123o9");
            Assert.IsFalse(expected2);
        }

        //[TestMethod]
        //public void TestEvaluateScore_ShouldBe_Advance()
        //{
        //    double score = 95;
        //    ScoreType expected = ScoreType.Advance;//期望值

        //    ResultService srv = new ResultService();

        //    ScoreType actual;//实际值
        //    actual = srv.EvaluateScore(score);
        //    Assert.AreEqual(expected, actual, "ResultService.EvlauateScore()方法错误");
        //}
    }
}
