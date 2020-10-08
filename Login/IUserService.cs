﻿using System.Collections.Generic;
 using Assignment1.Login;

 namespace Assignment1.Login
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
        void AddUser(string username, string password, string role);
        List<User> getUsers();
        void RemoveUser(User toRemove);
    }
}