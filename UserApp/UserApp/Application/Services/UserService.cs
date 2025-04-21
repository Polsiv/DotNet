using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddAsync(User entity)
        {
            var user = await _userRepository.GetByIdAsync(entity.Id);

            if (user != null)
            {
                throw new BadRequestException($"User with the Id: {entity.Id} already Exist!");
            }

            return await _userRepository.AddAsync(entity);
        }

        public async Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate)
        {
            return await _userRepository.FindAsync(predicate);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user is null)
            {
                throw new BadRequestException($"User with Id: {id} Not Found.");
            }

            return user;
        }

        public async Task RemoveAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new BadRequestException($"User with Id: {id} Not Found.");
            }

            await _userRepository.RemoveAsync(user);
        }

        public async Task<User> UpdateAsync(int id, User entity)
        {
            if (id != entity.Id)
            {
                throw new BadRequestException($"The Id: {id} not corresponding with Entity.Id: {entity.Id}");
            }

            var user = await _userRepository.GetByIdAsync(id);
            if (user is null)
            {
                throw new BadRequestException($"User with Id: {id} Not Found");
            }

            return await _userRepository.UpdateAsync(entity);
        }
    }
}
