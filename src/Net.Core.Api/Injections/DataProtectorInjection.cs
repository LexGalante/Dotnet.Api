using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;

namespace Net.Core.Api.Injections
{
    public static class DataProtectorInjection
    {
        public static void AddCryptProtection(this IServiceCollection services)
        {
            services.AddDataProtection()
               .UseCryptographicAlgorithms(new AuthenticatedEncryptorConfiguration()
               {
                   EncryptionAlgorithm = EncryptionAlgorithm.AES_256_GCM,
                   ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
               });
        }
    }
}
