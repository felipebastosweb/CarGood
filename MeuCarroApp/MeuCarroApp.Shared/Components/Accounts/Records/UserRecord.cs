using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Accounts.Records
{
    public record SignUpInput
    {
        public required string Username { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string Telephone { get; set; } = string.Empty;
        public bool AcceptTerms { get; set; } = false;
    }

    public record SignUpOutput
    {
        public required string Username { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
    }

    public record LoginInput
    {
        public required string Username { get; set; } = string.Empty;
        public required string Password { get; set; }
        public bool KeepConnected { get; set; } = false;
    }

    public record LoginOutput
    {
        public required string Username { get; set; } = string.Empty;
        public bool KeepConnected { get; set; } = false;
    }

    public record RecoveryAccountInput
    {
        public string? Email { get; set; }
    }


    public record RecoveryAccountOutput
    {
        public required string Username { get; set; } = string.Empty;
        public required string Token { get; set; } = string.Empty;
    }

    public record UserQuickAccess
    {
        public string? Username { get; set; }
        public string? TokenAccess { get; set; }
    }

    public record UserCreateInput
    {
        public required string Username { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string Telephone { get; set; } = string.Empty;
    }


    public record UserCreateOutput
    {
        public required string Username { get; set; } = string.Empty;
    }

}