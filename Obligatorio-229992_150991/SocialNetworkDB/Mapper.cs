using SocialNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkDB
{
    class Mapper
    {
        public UserEntity UserToEntity(User user)
        {
            PasswordEntity password = PasswordToEntity(user.Password);
            DirectionEntity direction = DirectionToEntity(user.Direction);
            UserEntity userEntity = new UserEntity
            {
                Username = user.Username,
                Name = user.Name,
                LastName = user.Lastname,
                Password = password,
                DateOfBirth = user.DateOfBirth,
                Direction = direction,
                Avatar = user.Avatar,
                Admin = user.Admin
            };
            return userEntity;
        }
        public User EntityToUser(UserEntity userEntity)
        {
            PasswordEntity entityPass = userEntity.Password;
            DirectionEntity entityDirection = userEntity.Direction;
            Password password = EntityToPassword(entityPass);
            Direction direction = EntityToDirection(entityDirection);
            User user = new User(userEntity.Username, password, userEntity.Name, userEntity.LastName, userEntity.DateOfBirth, direction, userEntity.Avatar, userEntity.Admin)
            {
                Id = userEntity.Id
            };
            return user;
        }
        public PasswordEntity PasswordToEntity(Password pass)
        {
            PasswordEntity passwordEntity = new PasswordEntity
            {
                Hashpassword = pass.Hashpassword
            };
            return passwordEntity;
        }
        public Password EntityToPassword(PasswordEntity passwordEntity)
        {
            Password password = new Password()
            {
                Id = passwordEntity.Id
            };
            return password;
        }
        public DirectionEntity DirectionToEntity(Direction direction)
        {
            DirectionEntity directionEntity = new DirectionEntity
            {
                Id = direction.Id,
                Street = direction.Street,
                City = direction.City,
                Counrty = direction.Counrty
            };
            return directionEntity;
        }
        public Direction EntityToDirection(DirectionEntity directionEntity)
        {
            Direction direction = new Direction()
            {
                Id = directionEntity.Id
            };
            return direction;
        }
    }
}
