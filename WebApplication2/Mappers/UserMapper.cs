using WebApplication2.Dtos.User;
using WebApplication2.Models.User;

namespace WebApplication2.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User user, string title)
        {
            return new UserDto
            {
                User = user,
                Header = title

            };
        }
    }
}
