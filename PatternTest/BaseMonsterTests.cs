using PrototypePattern.Models;
using System;
using Xunit;

namespace PatternTest
{
    public class BaseMonsterTests
    {
        [Fact]
        public void MyClone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetBaseMonster();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void Clone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetBaseMonster();

            // Act
            var actual = expected.Clone();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void MyClone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetBaseMonster();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
        }

        [Fact]
        public void Clone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetBaseMonster();

            // Act
            var actual = (BaseMob)expected.Clone();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
        }

        [Fact]
        public void MyClone_ChangeOriginObjectDoesNotChangeClonedObject()
        {
            // Arrange
            var expected = GetBaseMonster();

            // Act
            var actual = expected.Copy();
            expected.Name = "ChangedName";

            // Assert
            Assert.NotEqual(expected.Name, actual.Name);
        }

        private BaseMob GetBaseMonster()
        {
            return new BaseMob
            {
                Name = "TestBaseMonster",
                Damage = 5,
                Defence = 10,
                Health = 50,
                MoneyDrop = 2
            };
        }
    }
}
