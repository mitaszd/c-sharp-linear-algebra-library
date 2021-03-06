﻿using System;
using Amedian.LinearAlgebra;
using Amedian.LinearAlgebraTest.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amedian.LinearAlgebraTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestGetter()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float expectedResult = 4f;

            // Act
            float actualResult = m1.Get(1, 0);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSetter()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float expectedResult = 50f;

            // Act
            m1.Set(0, 0, 50f);
            float actualResult = m1.Get(0, 0);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestToString()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            string expectedResult = "[ 1 2 3 ]" + Environment.NewLine + "[ 4 5 6 ]" + Environment.NewLine;

            // Act
            string actualResult = "" + m1;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestGetRowLength()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            int expectedResult = 2;

            // Act
            int actualResult = m1.GetRowLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestGetColumnLength()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            int expectedResult = 3;

            // Act
            int actualResult = m1.GetColumnLength();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAdd()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[2, 3] { { 7f, 8f, 9f }, { 10f, 11f, 12f } });
            Matrix expectedResult = new Matrix(new float[2, 3] { { 8f, 10f, 12f }, { 14f, 16f, 18f } });

            // Act
            Matrix actualResult = m1 + m2;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestScalarAdd()
        {
            // Assign
            Matrix m = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float scalar = 3f;
            Matrix expectedResult = new Matrix(new float[2, 3] { { 4f, 5f, 6f }, { 7f, 8f, 9f } });

            // Act
            Matrix actualResult1 = m + scalar;
            Matrix actualResult2 = scalar + m;

            // Assert
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void TestEqualMatricies()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            bool expectedIsEqualOperatorResult = true;
            bool expectedNotEqualOperatorResult = false;
            bool expectedEqualsResult = true;

            // Act
            bool actualIsEqualOperatorResult = m1 == m2;
            bool actualNotEqualOperatorResult = m1 != m2;
            bool actualEqualsResult = m1.Equals(m2);

            // Assert
            Assert.AreEqual(expectedIsEqualOperatorResult, actualIsEqualOperatorResult);
            Assert.AreEqual(expectedNotEqualOperatorResult, actualNotEqualOperatorResult);
            Assert.AreEqual(expectedEqualsResult, actualEqualsResult);
        }

        [TestMethod]
        public void TestNotEqualMatricies()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[2, 3] { { 9f, 2f, 3f }, { 4f, 5f, 6f } });
            bool expectedIsEqualOperatorResult = false;
            bool expectedNotEqualOperatorResult = true;
            bool expectedIsEqualResult = false;

            // Act
            bool actualIsEqualOperatorResult = m1 == m2;
            bool actualNotEqualOperatorResult = m1 != m2;
            bool actualEqualsResult = m1.Equals(m2);

            // Assert
            Assert.AreEqual(expectedIsEqualOperatorResult, actualIsEqualOperatorResult);
            Assert.AreEqual(expectedNotEqualOperatorResult, actualNotEqualOperatorResult);
            Assert.AreEqual(expectedIsEqualResult, actualEqualsResult);
        }

        [TestMethod]
        public void TestSub()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[2, 3] { { 8f, 2f, 4f }, { 1f, 3f, 5f } });
            Matrix expectedResult = new Matrix(new float[2, 3] { { -7f, 0f, -1f }, { 3f, 2f, 1f } });

            // Act
            Matrix actualResult = m1 - m2;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestScalarSubWhenFirstArgumentIsMatrix()
        {
            // Assign
            Matrix m = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float scalar = 3f;
            Matrix expectedResult = new Matrix(new float[2, 3] { { -2f, -1f, 0f }, { 1f, 2f, 3f } });

            // Act
            Matrix actualResult = m - scalar;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestScalarSubWhenFirstArgumentIsScalar()
        {
            // Assign
            Matrix m = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float scalar = 3f;
            Matrix expectedResult = new Matrix(new float[2, 3] { { 2f, 1f , 0 }, { -1f, -2f, -3f } });

            // Act
            Matrix actualResult = scalar - m;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestScalarMultiple()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            float multiplier = 4f;
            Matrix expectedResult = new Matrix(new float[2, 3] { { 4f, 8f, 12f }, { 16f, 20f, 24f } });

            // Act
            Matrix actualResult1 = multiplier * m1;
            Matrix actualResult2 = m1 * multiplier;

            // Assert
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void TestTranspose()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix expectedResult = new Matrix(new float[3, 2] { { 1f, 4f }, { 2f, 5f }, { 3f, 6f } });

            // Act
            Matrix actualResult = ~m1;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMultiple()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[3, 2] { { 1f, 4f }, { 2f, 5f }, { 3f, 6f } });
            Matrix expectedResult1 = new Matrix(new float[2, 2] { { 14f, 32f }, { 32f, 77f } });
            Matrix expectedResult2 = new Matrix(new float[3, 3] { { 17f, 22f, 27f }, { 22f, 29f, 36f }, { 27f, 36f, 45f } });

            // Act
            Matrix actualResult1 = m1 * m2;
            Matrix actualResult2 = m2 * m1;

            // Assert
            Assert.AreEqual(expectedResult1, actualResult1);
            Assert.AreEqual(expectedResult2, actualResult2);
        }

        [TestMethod]
        public void TestMultipleDifferentDimension()
        {
            // Assign
            Matrix m1 = new Matrix(new float[3, 2] { { 1f, 2f }, { 4f, 6f }, { 8f, -5f } });
            Matrix m2 = new Matrix(new float[2, 4] { { -4f, 2f, 5f, 3f }, { 8f, -12f, 3f, 2f } });
            Matrix expectedResult = new Matrix(new float[3, 4] { { 12f, -22f, 11f, 7f }, { 32f, -64f, 38f, 24f }, { -72f, 76f, 25f, 14f } });

            // Act
            Matrix actualResult = m1 * m2;

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestCustomMatrixFunction()
        {
            // Assign
            ExampleMatrixFunction f = new ExampleMatrixFunction();
            Matrix m1 = new Matrix(new float[3, 2] { { 1f, 2f }, { 4f, 6f }, { 8f, -5f } });
            Matrix expectedResult = new Matrix(new float[3, 2] { { 1f, 3f }, { 6f, 9f }, { 12f, 0f } });

            // Act
            Matrix actualResult1 = m1 * f;
            Matrix actualResult2 = f * m1;

            // Assert
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void TestMatrixIsIndependentFromConstructorElement()
        {
            // Assign
            float[,] providedValue = new float[1, 1] { { 1f } };
            float[,] expectedValue = (float[,])providedValue.Clone();
            Matrix m = new Matrix(providedValue);

            // Act
            providedValue[0, 0] = 2f;

            // Assert
            Assert.AreEqual(expectedValue[0, 0], m.Get(0, 0));
        }

        [TestMethod]
        public void TestCloneCreatesAValueIndependentMatrix()
        {
            // Assign
            float expectedValue = 5f;
            Matrix m1 = new Matrix(new float[1,1] { { expectedValue } });

            // Act
            Matrix m2 = m1.Clone();
            m1.Set(0, 0, expectedValue + 1f);

            // Assert
            Assert.AreEqual(expectedValue, m2.Get(0, 0));
        }

        [TestMethod]
        public void TestElementwiseMultiply()
        {
            // Assign
            Matrix m1 = new Matrix(new float[2, 3] { { 1f, 2f, 3f }, { 4f, 5f, 6f } });
            Matrix m2 = new Matrix(new float[2, 3] { { 10f, 20f, 30f }, { 40f, 50f, 60f } });
            Matrix expectedResult = new Matrix(new float[2, 3] { { 10f, 40f, 90f }, { 160f, 250f, 360f } });

            // Act
            Matrix actualResult1 = m1.ElementwiseMultiply(m2);
            Matrix actualResult2 = m2.ElementwiseMultiply(m1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }
    }
}
