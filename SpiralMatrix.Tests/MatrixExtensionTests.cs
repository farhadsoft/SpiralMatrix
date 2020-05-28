using System;
using NUnit.Framework;
using SpiralMatrixTask;

namespace SpiralMatrix.Tests
{
    [TestFixture]
    public class MatrixExtensionTests
    {
        [Test]
        public void GetMatrix_Trivial_Spiral()
        {
            var expected = new[,]
            {
                {1}
            };
            Assert.AreEqual(expected, MatrixExtension.GetMatrix(1));
        }

        [Test]
        public void GetMatrix_Spiral_Of_Size_2()
        {
            var expected = new[,]
            {
                {1, 2},
                {4, 3}
            };
            Assert.AreEqual(expected, MatrixExtension.GetMatrix(2));
        }

        [Test]
        public void GetMatrix_Spiral_Of_Size_3()
        {
            var expected = new[,]
            {
                {1, 2, 3},
                {8, 9, 4},
                {7, 6, 5}
            };
            Assert.AreEqual(expected, MatrixExtension.GetMatrix(3));
        }

        [Test]
        public void GetMatrix_Spiral_Of_Size_4()
        {
            var expected = new[,]
            {
                {1, 2, 3, 4},
                {12, 13, 14, 5},
                {11, 16, 15, 6},
                {10, 9, 8, 7}
            };
            Assert.AreEqual(expected, MatrixExtension.GetMatrix(4));
        }

        [Test]
        public void GetMatrix_Spiral_Of_Size_5()
        {
            var expected = new[,]
            {
                {1, 2, 3, 4, 5},
                {16, 17, 18, 19, 6},
                {15, 24, 25, 20, 7},
                {14, 23, 22, 21, 8},
                {13, 12, 11, 10, 9}
            };
            Assert.AreEqual(expected, MatrixExtension.GetMatrix(5));
        }

        [TestCase(-100)]
        [TestCase(0)]
        public void GetMatrix_Size_Of_Matrix_Is_Negative_Throw_ArgumentException(int size)
        {
            Assert.Throws<ArgumentException>(() =>
                MatrixExtension.GetMatrix(size), $"Size of matrix '{size}' cannot be less or equal zero.");
        }
    }
}