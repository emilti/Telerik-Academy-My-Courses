namespace MatrixTest
{
    using System;
    using MatrixCreator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void MatrixTestTheLastSquareToBeWithTheRightValueSize5()
        {
            Matrix matrix = new Matrix(5);
            Assert.AreEqual(matrix.MatrixData[3, 1], 25);
        }

        [TestMethod]
        public void MatrixTestTheLastSquareToBeWithTheRightValueSize3()
        {
            Matrix matrix = new Matrix(3);
            Assert.AreEqual(matrix.MatrixData[1, 2], 9);
        }

        [TestMethod]
        public void SearchEmptyCellShouldReturnFalseIfThereIsNotEmptyCell()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 2, 3, 5 } };
            int x = 0;
            int y = 0;
            bool result = matrix.SearchEmptyCell(matrixTest, out x, out y);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void SearchEmptyCellShouldReturnTrueIfThereIsEmptyCell()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 0, 3 } };
            int x = 0;
            int y = 0;
            bool result = matrix.SearchEmptyCell(matrixTest, out x, out y);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleDownMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 0, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, 1);
            Assert.AreEqual(dy, 0);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleDownLeftMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 0, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, 1);
            Assert.AreEqual(dy, -1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleLeftMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 0, 3, 4 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, 0);
            Assert.AreEqual(dy, -1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleUpLeftMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 0, 2, 3 }, { 2, 3, 4 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, -1);
            Assert.AreEqual(dy, -1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleUpMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 0, 3 }, { 2, 3, 4 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, -1);
            Assert.AreEqual(dy, 0);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleUpRightMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 0 }, { 2, 3, 4 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, -1);
            Assert.AreEqual(dy, 1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleRightMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 0 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, 0);
            Assert.AreEqual(dy, 1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnTrueIfThereIsPossibleDownRightMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 1 }, { 1, 1, 0 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, true);
            Assert.AreEqual(dx, 1);
            Assert.AreEqual(dy, 1);
        }

        [TestMethod]
        public void GetDirectionShouldReturnFalseIfThereIsNotPossibleMove()
        {
            Matrix matrix = new Matrix(3);
            int[,] matrixTest = new int[,] { { 1, 2, 3 }, { 2, 3, 1 }, { 1, 1, 3 } };
            int x = 1;
            int y = 1;
            int dx = 1;
            int dy = 1;
            int clockWisePosition = 0;
            bool result = matrix.GetDirection(matrixTest, x, y, out dx, out dy, ref clockWisePosition);
            Assert.AreEqual(result, false);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IfMatrixSizeIsNegativeMatrixShouldThrowArgumentException()
        {
            Matrix matrix = new Matrix(-3);
        }
    }
}
