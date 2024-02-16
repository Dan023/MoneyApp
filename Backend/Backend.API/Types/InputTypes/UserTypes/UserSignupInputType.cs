﻿using Backend.Core.Enums;

namespace Backend.API.Types.InputTypes.UserTypes
{
    public class UserSignupInputType
    {
        public required string Name { get; init; }
        public required string Surname { get; init; }
        public required string Email { get; init; }
        public required string Password { get; init; }
        public required Currency SelectedCurrency { get; init; }
    }
}
