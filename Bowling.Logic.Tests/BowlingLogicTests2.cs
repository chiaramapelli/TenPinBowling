using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling.Logic.Tests
{
    public class BowlingLogicTests2
    {
        [Test]
        public void Given_An_Empty_Frame_For_Every_Bowl_I_Should_See_0_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(0, 0);

            var score = bowlingLogic.GetScore();
            
            // Assert
            Assert.AreEqual(0, score);
        }

        [Test]
        public void Given_A_Bowl_Of_1_I_Should_See_1_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(1, 0);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(1, score);
        }

        [Test]
        public void Given_A_Bowl_Of_1_And_2_I_Should_See_3_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(1, 2);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(3, score);
        }

        [Test]
        public void Given_A_Spare_And_A_Bowl_Of_0_I_Should_See_10_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(5, 5);
            bowlingLogic.AddFrameScore(0, 0);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(10, score);
        }

        [Test]
        public void Given_A_Spare_And_A_Bowl_Of_5_I_Should_See_20_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(5, 5);
            bowlingLogic.AddFrameScore(5, 0);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(20, score);
        }

        [Test]
        public void Given_2_Spares_And_A_Bowl_Of_5_per_Bowl_I_Should_See_25_For_The_Total_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(5, 5);
            bowlingLogic.AddFrameScore(5, 5);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(25, score);
        }

        [Test]
        public void Given_A_Strike_And_A_Bowl_Of_0_per_Bowl_I_Should_See_10_For_The_Total_Score()               
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(0, 0);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(10, score);
        }

        [Test]
        public void Given_A_Strike_And_Bowls_Of_3_2_per_Bowl_I_Should_See_20_For_The_Total_Score()              //FAILED
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(3, 2);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(20, score);
        }

        [Test]
        public void Given_The_Last_Frame_Is_Not_A_Spare_Or_A_Strike_I_Should_See_9_For_The_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);

            bowlingLogic.AddFrameScore(5, 4);
            

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(9, score);
        }

        [Test]
        public void Given_The_Last_Frame_Is_A_Spare_I_Should_See_20_For_The_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);

            bowlingLogic.AddFrameScore(5, 5);
            bowlingLogic.AddFrameScore(5, 5);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(20, score);
        }

        [Test]
        public void Given_The_Last_Frame_Is_A_Strike_I_Should_See_30_For_The_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);
            bowlingLogic.AddFrameScore(0, 0);

            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(5, 5);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(30, score);
        }

        [Test]
        public void Given_All_Frames_Are_A_Strike_I_Should_See_300_For_The_Score()
        {
            // Arrange 
            var bowlingLogic = new BowlingLogic2();

            // Act
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);
            bowlingLogic.AddFrameScore(10, 0);

            var score = bowlingLogic.GetScore();

            // Assert
            Assert.AreEqual(300, score);
        }
    }
}
