using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy.Tests
{
    [TestClass]
    public class DiaryTests
    {
        [TestMethod]
        public void calculatemaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(9f);
            diary.AddRating(8f);
            diary.AddRating(7f);
            diary.AddRating(5f);
            diary.AddRating(3f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(9f, stats.MaxGrade);
        }
        [TestMethod]
        public void passByvalueclass()
        {
            Diary diary = new Diary();
            diary.Name  "Jacek";
            SetName(diary);
        }

        private void SetName(Diary diary)
        {

        }
    }
}
