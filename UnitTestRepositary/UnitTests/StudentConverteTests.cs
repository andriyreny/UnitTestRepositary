using UnitTestRepositary.Models;

namespace UnitTestRepositary.UnitTests
{
    public class StudentConverteTests
    {
        private readonly StudentConverte _converter;

        public StudentConverteTests()
        {
            _converter = new StudentConverte();
        }

        [Fact]
        public void ConvertStudents_HighAchiever_ReturnsHonorRollTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Alice", Age = 21, Grade = 91 }
            };

            // Act
            var result = _converter.ConvertStudents(students);

            // Assert
            Assert.Single(result);
            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void ConvertStudents_ExceptionalYoungHighAchiever_ReturnsExceptionalTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Bob", Age = 20, Grade = 95 }
            };

            // Act
            var result = _converter.ConvertStudents(students);

            // Assert
            Assert.Single(result);
            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void ConvertStudents_PassedStudent_ReturnsPassedTrue()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Charlie", Age = 22, Grade = 80 }
            };

            // Act
            var result = _converter.ConvertStudents(students);

            // Assert
            Assert.Single(result);
            Assert.True(result[0].Passed);
        }

        [Fact]
        public void ConvertStudents_FailedStudent_ReturnsPassedFalse()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "David", Age = 19, Grade = 70 }
            };

            // Act
            var result = _converter.ConvertStudents(students);

            // Assert
            Assert.Single(result);
            Assert.False(result[0].Passed);
        }

        [Fact]
        public void ConvertStudents_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            var students = new List<Student>();

            // Act
            var result = _converter.ConvertStudents(students);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertStudents_NullInput_ThrowsException()
        {
            // Arrange
            var converter = new StudentConverte();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(null));
        }
    }
}
