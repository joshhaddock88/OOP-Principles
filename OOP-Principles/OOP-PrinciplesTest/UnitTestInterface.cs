using System;
using Xunit;
using OOP_Principles.Classes.Animals.Birds.Hawk;
using OOP_Principles.Classes.Animals.Birds.Penguin;
using OOP_Principles.Classes.Animals.Reptiles.Chameleon;
using OOP_Principles.Classes.Animals.Mammals.FlyingFox;
using OOP_Principles.Classes.Animals.Mammals.Hippo;
using OOP_Principles.Classes.Animals.Mammals.Shrew;
using OOP_Principles.Classes.Animals;

namespace OOP_PrinciplesTest
{
    
    public class UnitTestInterface
    {
        Hawk myHawk = new Hawk();
        Penguin myPenguin = new Penguin();
        Chameleon myChameleon = new Chameleon();
        FlyingFox myFlyingFox = new FlyingFox();
        Hippo myHippo = new Hippo();
        Shrew myShrew = new Shrew();

        [Fact]
        public void HippoIsAnimal()
        {
            Assert.IsAssignableFrom<Animals>(myHippo);
        }
        [Fact]
        public void HippoSwimInterface()
        {
            
            Assert.False(myHippo.LivesUnderWater);
        }
        [Fact]
        public void HippoOverrideMethod()
        {
            Assert.Equal("Hippos are polygamists", myHippo.MatingHabits());
        }
        [Fact]
        public void HippoGroups()
        {
            Assert.Equal("Complex", myHippo.Hierarchy);
        }
        [Fact]
        public void ShrewHasInterFace()
        {
            Assert.True(myShrew.Venomous);
        }
        [Fact]
        public void FlyingFoxHasInterface()
        {
            Assert.False(myFlyingFox.Venomous);
        }
        [Fact]
        public void PenguinDoesNotLiveUnderWater()
        {
            Assert.False(myPenguin.LivesUnderWater);
        }
    }
}
