using Database;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UnitTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4 })]
        public void TestValidConstructor(int[] values)
        {
            DatabaseClass database = new DatabaseClass(values);

            FieldInfo fieldInfo = typeof(DatabaseClass)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(x => x.FieldType == typeof(int[]));

            IEnumerable<int> currentValues = ((int[])fieldInfo.GetValue(database)).Take(values.Length);

            Assert.That(currentValues, Is.EquivalentTo(values));
        }

        [Test]
        public void TestInvalidConstructor()
        {
            int[] values = new int[17];
            Assert.That(() => new DatabaseClass(values), Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(3)]
        [TestCase(8)]
        [TestCase(16)]
        public void TestAddMethodValid(int value)
        {
            DatabaseClass database = new DatabaseClass();
            database.Add(value);

            FieldInfo fieldInfo = typeof(DatabaseClass)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(x => x.FieldType == typeof(int[]));

            int firstValue = ((int[])fieldInfo.GetValue(database)).First();

            Assert.That(firstValue, Is.EqualTo(value));
        }

        [Test]
        public void TestAddMethodInvalid()
        {
            DatabaseClass database = new DatabaseClass();

            FieldInfo currentIndex = typeof(DatabaseClass)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(x => x.FieldType == typeof(int));

            currentIndex.SetValue(database, 16);

            Assert.That(() => database.Add(1), Throws.InvalidOperationException);

        }

        [Test]
        [TestCase((new int[] { 1, 2, 3, 4 }))]
        public void TestRemoveMethodValid(int[] values)
        {
            DatabaseClass database = new DatabaseClass();

            FieldInfo fieldInfo = typeof(DatabaseClass)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(x => x.FieldType == typeof(int[]));

            fieldInfo.SetValue(database, values);

            FieldInfo currentIndex = typeof(DatabaseClass)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .First(x => x.FieldType == typeof(int));

            currentIndex.SetValue(database, values.Length);

            database.Remove();

            int[] fieldValues = (int[])fieldInfo.GetValue(database);

            int[] newValues = values.Take(values.Length).ToArray();
            Assert.That(fieldValues, Is.EquivalentTo(newValues));

        }

        [Test]
        public void TestRemoveMethodInvalid()
        {
            DatabaseClass database = new DatabaseClass();

            FieldInfo fieldInfo = typeof(DatabaseClass)
               .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
               .First(x => x.FieldType == typeof(int));

            fieldInfo.SetValue(database, 0);

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }

    }
}
