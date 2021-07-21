using System;
using Xunit;
using OOP_Principles.Classes.Animals.Birds.Hawk;
using OOP_Principles.Classes.Animals.Birds.Penguin;
using OOP_Principles.Classes.Animals.Reptiles.Chameleon;
using OOP_Principles.Classes.Animals.Mammals.FlyingFox;
using OOP_Principles.Classes.Animals.Mammals.Hippo;
using OOP_Principles.Classes.Animals.Mammals.Shrew;

namespace OOP_PrinciplesTest
{
    
    public class UnitTestInheritence
    {
        Hawk myHawk = new Hawk();
        Penguin myPenguin = new Penguin();
        Chameleon myChameleon = new Chameleon();
        FlyingFox myFlyingFox = new FlyingFox();
        Hippo myHippo = new Hippo();
        Shrew myShrew = new Shrew();
        [Fact]
        public void HawkLegPerchingInherit()
        {
            Assert.True(myHawk.Perching);
        }
        [Fact]
        public void HawkSpeedInherit()
        {
            Assert.Equal(15, myHawk.Speed);
        }
        [Fact]
        public void PenguinLegNumberInherit()
        {
            Assert.Equal(2, myPenguin.LegNumber);
        }
        [Fact]
        public void PenguinLaysEggs()
        {
            Assert.True(myPenguin.LaysEggs);
        }
        [Fact]
        public void ChameleonExtendableTongue()
        {
            Assert.True(myChameleon.ExtendableTongue);
        }
        [Fact]
        public void ChameleonIsCarnivore()
        {
            Assert.True(myChameleon.Carnivore);
        }
        [Fact]
        public void FlyingFoxSpecies()
        {
            Assert.Equal("Flying Fox", myFlyingFox.Species);
        }
        [Fact]
        public void FlyingFoxWingspan()
        {
            Assert.Equal(6, myFlyingFox.WingSpan);
        }
        [Fact]
        public void HippoLaysEggs()
        {
            Assert.False(myHippo.LaysEggs);
        }
        [Fact]
        public void HippoLegNumber()
        {
            Assert.Equal(4, myHippo.LegNumber);
        }
        [Fact]
        public void ShrewIsCarnivore()
        {
            Assert.True(myShrew.Carnivore);
        }
        [Fact]
        public void ShrewIsShrew()
        {
            Assert.Equal("Shrew", myShrew.Species);
        }
    }
}
