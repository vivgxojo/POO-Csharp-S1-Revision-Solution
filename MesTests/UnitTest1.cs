using S1_Revision;

namespace MesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            string chaine = "Bonjour";
            int expected = 7;

            // Act
            int result = Fonctions.Longueur(chaine);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void TestEstMultiple10()
        {
            // Arrange
            int[] nombres = { 10, 0, 9, 11, -1, 20, 99, 100, 200};
            bool[] expected = { true, true, false, false, false, true, false, true, true };

            for (int i = 0; i < nombres.Length; i++)
            {
                // Act
                bool result = Fonctions.EstMultiple10(nombres[i]);

                // Assert
                Assert.Equal(expected[i], result);
            }

        }

    }

}