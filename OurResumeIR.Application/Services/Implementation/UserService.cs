﻿using OurResumeIR.Application.Services.Interfaces;
using OurResumeIR.Domain.Enums;
using OurResumeIR.Domain.Interfaces;
using OurResumeIR.Domain.Models;
using OurResumeIR.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurResumeIR.Application.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public async Task<RegisterResult> RegisterUser(RegisterViewModel viewModel)
        {
            if (await _userRepository.EmailIsExist(viewModel.Email)) 
            {
               return RegisterResult.DupplicateEmail;
            }

            if (viewModel.Password != viewModel.RePassword) 
            {
                return RegisterResult.UnequalPassAndRePass;
            }


            var user = new User
            {
                Email = viewModel.Email,
                PasswordHash = viewModel.Password,
            };

          await  _userRepository.CreateUser(user);
           await _userRepository.SaveChanges();


            return RegisterResult.Success;
        }
    }
}
