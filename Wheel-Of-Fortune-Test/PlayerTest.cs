using Wheel_Of_Fortune_MVP; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wheel_Of_Fortune_Test
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void NewPlayerTest()
        {
            //Arrange 
            Player player1 = new Player();


            //Act 
            string playerName = player1.playerName;

            //Assert
            Assert.AreEqual("Entry", playerName); 
        }
    }
}
