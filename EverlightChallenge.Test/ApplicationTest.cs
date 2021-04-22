using EverlightChallenge.Applications;
using EverlightChallenge.DataStructures;
using EverlightChallenge.Enums;
using EverlightChallenge.Helpers;
using EverlightChallenge.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverlightChallenge.Test
{
    [TestClass]
	public class ApplicationTest
	{
        [TestMethod]
		public void Should_be_able_to_predict_unfilled_node()
		{
			// Arrange
			var tree = new Tree(3);
			var root = tree.RootNode;

			root.Switch = SwitchType.Left;
			root.Right.Switch = SwitchType.Left; ;
			root.Right.Right.Switch = SwitchType.Left;

            var application = GetApplication();
            application.Tree = tree;

			// Act
			application.PredictResult();

			// Assert
			Assert.AreEqual(8, application.PredictedResult);
		}

        [TestMethod]
        public void Should_be_able_to_return_actualResult_after_running_balls()
        {
            // Arrange
            var tree = new Tree(3);
            var root = tree.RootNode;

            root.Switch = SwitchType.Left;
            root.Right.Switch = SwitchType.Left; ;
            root.Right.Right.Switch = SwitchType.Right;

            var application = GetApplication();
            application.Tree = tree;
            // Act
           
            application.RunBallsThrough();
            application.GetActualResult();

            // Assert
            Assert.AreEqual(7, application.ActualResult);
        }

        [TestMethod]
        public void Prediction_and_running_through_should_return_the_same_result()
        {
            // Arrange
            var tree = new Tree(3);
            var root = tree.RootNode;

            root.Switch = SwitchType.Left;
            root.Right.Switch = SwitchType.Left; ;
            root.Right.Right.Switch = SwitchType.Right;

            var application = GetApplication();
            application.Tree = tree;

            // Act
            application.PredictResult();
            application.RunBallsThrough();
            application.GetActualResult();

            // Assert
            Assert.AreEqual(application.PredictedResult, application.ActualResult);
        }

        private Application GetApplication()
        {
            return new Application(new Logger(), new BallRunner(), new ResultHelper());
        }
    }
}