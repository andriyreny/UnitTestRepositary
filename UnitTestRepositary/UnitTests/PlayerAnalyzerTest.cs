using UnitTestRepositary.Models;

namespace UnitTestRepositary.UnitTests
{
    public class PlayerAnalyzerTests
    {
        [Fact]
        public void CalculateScore_NormalPlayer_ReturnsScore()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Name = "John", Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
            };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(25 * 5 * 2, score);
        }

        [Fact]
        public void CalculateScore_JuniorPlayer_ReturnsScore()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Name = "Alice", Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
            };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(15 * 3 * 3 * 0.5, score);
        }

        [Fact]
        public void CalculateScore_SeniorPlayer_ReturnsScore()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Name = "Bob", Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
            };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(35 * 15 * 4 * 1.2, score);
        }

        [Fact]
        public void CalculateScore_MultiplePlayers_ReturnsSumOfScores()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Name = "John", Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
                new Player { Name = "Alice", Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
            };

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal((25 * 5 * 2) + (15 * 3 * 3 * 0.5), score);
        }

        [Fact]
        public void CalculateScore_SkillsIsNull_ThrowsException()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Name = "David", Age = 20, Experience = 4, Skills = null }
            };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => PlayerAnalyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_EmptyArray_ReturnsZero()
        {
            // Arrange
            var players = new List<Player>();

            // Act
            var score = PlayerAnalyzer.CalculateScore(players);

            // Assert
            Assert.Equal(0, score);
        }
    }
}
