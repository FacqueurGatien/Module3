using FizzBuzz.Model;

namespace FizzBuzz.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Donne_Nombre_Quand_FizzBuzzPourNombre_Alors_Retourn_Nombre_En_String()
        {
            //Arrange
            string retour;
            int nombre = 1;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("1", retour);
        }
        [TestMethod]
        public void Donne_Nombre_3_Quand_FizzBuzzPourNombre_3_Alors_Retourn_Fizz_String()
        {
            //Arrange
            string retour;
            int nombre = 3;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Fizz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_6_Quand_FizzBuzzPourNombre_6_Alors_Retourn_Fizz_String()
        {
            //Arrange
            string retour;
            int nombre = 6;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Fizz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_Multiple_3_Quand_FizzBuzzPourNombre_6_Alors_Retourn_Fizz_String()
        {
            //Arrange
            string retour;
            int nombre = 6;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Fizz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_5_Quand_FizzBuzzPourNombre_5_Alors_Retourn_Buzz_String()
        {
            //Arrange
            string retour;
            int nombre = 5;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Buzz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_10_Quand_FizzBuzzPourNombre_5_Alors_Retourn_Buzz_String()
        {
            //Arrange
            string retour;
            int nombre = 20;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Buzz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_Multiple_5_Quand_FizzBuzzPourNombre_20_Alors_Retourn_Buzz_String()
        {
            //Arrange
            string retour;
            int nombre = 20;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("Buzz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_15_Quand_FizzBuzzPourNombre_15_Alors_Retourn_FizzBuzz_String()
        {
            //Arrange
            string retour;
            int nombre = 15;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("FizzBuzz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_30_Quand_FizzBuzzPourNombre_30_Alors_Retourn_FizzBuzz_String()
        {
            //Arrange
            string retour;
            int nombre = 30;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("FizzBuzz", retour);
        }
        [TestMethod]
        public void Donne_Multiple_de_3_et_Multiple_de_5_Quand_FizzBuzzPourNombre_30_Alors_Retourn_FizzBuzz_String()
        {
            //Arrange
            string retour;
            int nombre = 30;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("FizzBuzz", retour);
        }
        [TestMethod]
        public void Donne_Nombre_0_Quand_FizzBuzzPourNombre_0_Alors_Retourn_0_String()
        {
            //Arrange
            string retour;
            int nombre = 0;
            //Act
            retour = FzBz.FizzBuzzPourNombre(nombre);
            //Assert
            Assert.AreEqual("0", retour);
        }

    }
}