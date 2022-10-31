﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Testsuite
    {
      private float result = 0.0f;

        // A Test behaves as an ordinary method
        [Test]
        
        public void TestAddition()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestSubtraction()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestMultiplication()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestDivision()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void TestSqrt()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(2, 9, "√");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestPow()
        {
            // Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }
        [UnityTest]
        public IEnumerator TestUnitySqrt()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(2, 9, "√");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityPow()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "^");
            Assert.AreEqual(result, 25);
        }
    }
}
