using System;
using Xunit;
using IbuiltAZoo;
using IbuiltAZoo.Classes;

namespace TestIbuiltAZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestMammal()
        {
            Mammal lion = new Lion();
            Assert.Equal("Lion is Eating", lion.Eat());
        }

        [Fact]
        public void TestPet()
        {
            Pet cat = new Cat();
            Assert.Equal("Cat Sound: Meow", cat.Sound());
        }

        [Fact]
        public void TestPird()
        {
            Bird chicken = new Chicken();
            Assert.Equal("Chicken is Sleeping", chicken.Sleep());
        }

        [Fact]
        public void TestSeaAnimal()
        {
            SeaAnimal fish = new Fish();
            Assert.Equal("Fish is Eating", fish.Eat());
        }

        [Fact]
        public void TestIHomable()
        {
            Fish fish = new Fish();
            Assert.Equal("Fish is Loving", fish.Love());
        }

        [Fact]
        public void TestIHerbivores()
        {
            Fish fish = new Fish();
            Assert.Equal("Fish is Grinding HumHumHum", fish.Grind());
        }

        [Fact]
        public void TestAnimal()
        {
            Animal fish = new Fish();
            Assert.Equal("Fish is Eating", fish.Eat());
        }
    }
}
