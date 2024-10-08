using Xunit;
using Humanity.Application.Services;
using Humanity.Application.Models.Requests;
using Humanity.Domain.Entities;
using Humanity.Domain.Enums;
using Humanity.Domain.Exceptions;
using Humanity.Domain.Core.Specifications;
using Humanity.Application.Core.Services;
using Moq;
using Humanity.Domain.Core.Repositories;

namespace Humanity.Application.Test.Services
{
    public class UserServiceTest
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock = new Mock<IUnitOfWork>();
        private readonly Mock<ILoggerService> _loggerMock = new Mock<ILoggerService>();
        private readonly UserService _userService;

        public UserServiceTest()
        {
            _userService = new UserService(_unitOfWorkMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async void Given_WithValidData_When_CreateUser_Then_SuccessfullyCreateUser()
        {
            // Arrange
            var id = Guid.NewGuid();
            _unitOfWorkMock.Setup(x => x.Repository<User>().AddAsync(It.IsAny<User>()))
                .ReturnsAsync(new User
                {
                    Id = id,
                    FirstName = "Nilav",
                    LastName = "Patel",
                    EmailId = "nilavpatel1992@gmail.com",
                    Password = "Test123",
                    Status = UserStatus.Active
                });
            _unitOfWorkMock.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            var result = await _userService.CreateUser(new CreateUserReq
            {
                FirstName = "Nilav",
                LastName = "Patel",
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123",
                Status = UserStatus.Active
            });

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Data);
            Assert.Equal(id, result.Data.Id);
        }

        [Fact]
        public async void Given_UserNotExist_When_ValidateUser_Then_ThrowException()
        {
            // Arrange
            _unitOfWorkMock.Setup(x => x.Repository<User>().FirstOrDefaultAsync(It.IsAny<ISpecification<User>>()))
                .ReturnsAsync((User)null);

            // Act
            await Assert.ThrowsAsync<UserNotFoundException>(async () => await _userService.ValidateUser(new ValidateUserReq
            {
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123"
            }));
        }

        [Fact]
        public async void Given_UserIsNotActive_When_ValidateUser_Then_ThrowException()
        {
            // Arrange
            var id = Guid.NewGuid();
            User user = new User
            {
                Id = id,
                FirstName = "Nilav",
                LastName = "Patel",
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123",
                Status = UserStatus.InActive
            };

            _unitOfWorkMock.Setup(x => x.Repository<User>().FirstOrDefaultAsync(It.IsAny<ISpecification<User>>()))
                .ReturnsAsync(user);

            // Act
            await Assert.ThrowsAsync<UserIsNotActiveException>(async () => await _userService.ValidateUser(new ValidateUserReq
            {
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123"
            }));
        }

        [Fact]
        public async void Given_ValidData_When_ValidateUser_Then_ReturnsResult()
        {
            // Arrange
            var id = Guid.NewGuid();
            User user = new User
            {
                Id = id,
                FirstName = "Nilav",
                LastName = "Patel",
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123",
                Status = UserStatus.Active
            };

            _unitOfWorkMock.Setup(x => x.Repository<User>().FirstOrDefaultAsync(It.IsAny<ISpecification<User>>()))
                .ReturnsAsync(user);

            // Act
            var result = await _userService.ValidateUser(new ValidateUserReq
            {
                EmailId = "nilavpatel1992@gmail.com",
                Password = "Test123"
            });

            // Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
        }
    }
}