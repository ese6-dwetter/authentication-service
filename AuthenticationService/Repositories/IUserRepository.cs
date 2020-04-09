﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthenticationService.Entities;

namespace AuthenticationService.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets a list of all the users
        /// </summary>
        /// <returns>List of all the users</returns>
        Task<List<User>> Get();

        /// <summary>
        /// Gets a single user by their username
        /// </summary>
        /// <param name="username">The username to search for</param>
        /// <returns>User with the correct username</returns>
        Task<User> Get(string username);

        /// <summary>
        /// Gets a single user by their Guid
        /// </summary>
        /// <param name="id">The guid to search for</param>
        /// <returns>User with the correct guid</returns>
        Task<User> Get(Guid id);

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="user">User to be saved</param>
        /// <returns>Created user</returns>
        Task<User> Create(User user);

        /// <summary>
        /// Updates an existing user
        /// </summary>
        /// <param name="id">Guid of the user</param>
        /// <param name="userIn">User with updated fields</param>
        /// <returns>Updated user</returns>
        Task Update(Guid id, User userIn);

        /// <summary>
        /// Removes an user
        /// </summary>
        /// <param name="userIn">User to remove</param>
        void Remove(User userIn);

        /// <summary>
        /// Removes an user by their Guid
        /// </summary>
        /// <param name="id">Guid of the user to remove</param>
        /// <returns>Async task to await</returns>
        Task Remove(Guid id);
    }
}