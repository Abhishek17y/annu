﻿using Annu.Models.ViewModel;
using Annu.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Annu.Respository.Contract
{
    public interface IUser
    {
        SignUp Register(SignUp model);
        AuthoEnum AuthenticateUser(SignIn model);
        VerifyAccountEnum VerifyAccount(string Otp);
        bool UpdateProfile(string Email, string Path);
    }
}
