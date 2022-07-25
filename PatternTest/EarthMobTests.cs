using PrototypePattern.Models;
using Xunit;

namespace EntitiesLib.UnitTests
{
    public class EarthMobTests
    {
        [Fact]
        public void MyClone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetEarthMob();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void Clone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetEarthMob();

            // Act
            var actual = expected.Clone();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void MyClone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetEarthMob();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
            Assert.Equal(expected.StoneDamage, actual.StoneDamage);
        }

        [Fact]
        public void Clone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetEarthMob();

            // Act
            var actual = (EarthMob)expected.Clone();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
            Assert.Equal(expected.StoneDamage, actual.StoneDamage);
        }

        [Fact]
        public void MyClone_ChangeOriginObjectDoesNotChangeClonedObject()
        {
            // Arrange
            var expected = GetEarthMob();

            // Act
            var actual = expected.Copy();
            expected.Name = "ChangedName";

            // Assert
            Assert.NotEqual(expected.Name, actual.Name);
        }

        private EarthMob GetEarthMob()
        {
            return new EarthMob
            {
                Name = "TestFireMonster",
                Damage = 5,
                Defence = 10,
                Health = 100,
                MoneyDrop = 22,
                StoneDamage = 25
            };
        }
    }
}
