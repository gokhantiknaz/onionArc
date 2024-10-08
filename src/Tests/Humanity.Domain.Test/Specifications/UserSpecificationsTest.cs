using Xunit;
using Humanity.Domain.Specifications;
using Humanity.Domain.Entities;
using Humanity.Domain.Enums;
using Humanity.Domain.Test.Helpers;

namespace Humanity.Domain.Test.Specifications
{
    public class UserSpecificationsTest
    {
        private readonly List<User> _users;
        public UserSpecificationsTest()
        {
            _users = new List<User>{
                new User
                {
                    FirstName = "Nilav",
                    LastName = "Patel",
                    EmailId = "nilavpatel1992@gmail.com",
                    Password = "Test123",
                    Status = UserStatus.Active
                },
                new User
                {
                    FirstName = "Nilav1",
                    LastName = "Patel",
                    EmailId = "nilav1patel1992@gmail.com",
                    Password = "Test1234",
                    Status = UserStatus.InActive
                },
                new User
                {
                    FirstName = "Nilav2",
                    LastName = "Patel",
                    EmailId = "nilav2patel1992@gmail.com",
                    Password = "Test1235",
                    Status = UserStatus.Active
                }
            };
        }

        [Fact]
        public void Given_ValidData_When_GetUserByEmailAndPasswordSpec_Then_ReturnValidData()
        {
            // Arrange
            var spec = UserSpecifications.GetUserByEmailAndPasswordSpec("nilavpatel1992@gmail.com", "Test123");

            // Act
            var count = SpecificationEvaluatorTestHelper<User>.GetQuery(_users.AsQueryable(), spec).Count();

            // Assert
            Assert.Equal(1, count);
        }

        [Fact]
        public void Given_ValidData_When_GetAllActiveUsersSpec_Then_ReturnValidData()
        {
            // Arrange
            var spec = UserSpecifications.GetAllActiveUsersSpec();

            // Act
            var count = SpecificationEvaluatorTestHelper<User>.GetQuery(_users.AsQueryable(), spec).Count();

            // Assert
            Assert.Equal(2, count);
        }
    }
}