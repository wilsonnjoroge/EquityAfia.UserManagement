﻿using EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity;
using System;

namespace EquityAfia.UserManagement.Contracts.Authentication.RegisterUser
{
    public class RegisterResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public string Location { get; set; }
        public string? LicenseNumber { get; set; }
        public List<string> UserRoles { get; set; }
        public List<PractitionerType>? PractitionerType { get; set; }
    }
}
