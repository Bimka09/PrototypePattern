using PrototypePattern.Models;
using Xunit;

namespace EntitiesLib.UnitTests
{
    public class BossEarthMobTests
    {
        [Fact]
        public void MyClone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetBossEarthMob();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void Clone_ObjectsAreNotTheSameInstance()
        {
            // Arrange
            var expected = GetBossEarthMob();

            // Act
            var actual = expected.Clone();

            // Assert
            Assert.NotSame(expected, actual);
        }

        [Fact]
        public void MyClone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetBossEarthMob();

            // Act
            var actual = expected.Copy();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
            Assert.Equal(expected.StoneDamage, actual.StoneDamage);
            Assert.Equal(expected.Ultimate, actual.Ultimate);
        }

        [Fact]
        public void Clone_FieldsAreCopied()
        {
            // Arrange
            var expected = GetBossEarthMob();

            // Act
            var actual = (BossEarthMob)expected.Clone();

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Damage, actual.Damage);
            Assert.Equal(expected.Defence, actual.Defence);
            Assert.Equal(expected.Health, actual.Health);
            Assert.Equal(expected.MoneyDrop, actual.MoneyDrop);
            Assert.Equal(expected.StoneDamage, actual.StoneDamage);
            Assert.Equal(expected.Ultimate, actual.Ultimate);
        }

        [Fact]
        public void MyClone_ChangeOriginObjectDoesNotChangeClonedObject()
        {
            // Arrange
            var expected = GetBossEarthMob();

            // Act
            var actual = expected.Copy();
            expected.Name = "ChangedName";

            // Assert
            Assert.NotEqual(expected.Name, actual.Name);
        }

        private BossEarthMob GetBossEarthMob()
        {
            return new BossEarthMob
            {
                Name = "TestBossEarthMob",
                Damage = 55,
                Defence = 100,
                Health = 500,
                MoneyDrop = 222,
                StoneDamage = 205,
                Artefact = "Awasome ring with stone attack",
                Ultimate = 1000
            };
        }
    }
}

