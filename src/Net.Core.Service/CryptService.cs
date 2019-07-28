using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Service
{
    public class CryptService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IConfiguration _configuration;

        public CryptService(IDataProtectionProvider dataProtectionProvider, IConfiguration configuration)
        {
            _dataProtectionProvider = dataProtectionProvider;
            _configuration = configuration;
        }

        public string Encrypt(string input)
        {
            var key = _configuration.GetSection("SecuritySettings").Get<SecuritySettings>().CryptKey;
            var protector = _dataProtectionProvider.CreateProtector(key);

            return protector.Protect(input);
        }

        public string Decrypt(string cipherText)
        {
            var key = _configuration.GetSection("SecuritySettings").Get<SecuritySettings>().CryptKey;
            var protector = _dataProtectionProvider.CreateProtector(key);

            return protector.Unprotect(cipherText);
        }

        private class SecuritySettings
        {
            public string CryptKey { get; set; }
        }
    }
}
