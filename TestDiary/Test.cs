using NUnit.Framework;
using System;
namespace Typy.Tests
{
    [TestFixture()]
    public class DiaryTests
    {
        [Test()]
        public void CalculatemaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(9f);
            diary.AddRating(7f);
            diary.AddRating(7f);
            diary.AddRating(5f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(11f,stats.MaxGrade);
        }
    }
}