﻿
namespace CompliaShield.Sdk.Cryptography.Encryption.Keys
{
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IPublicKey : IDisposable
    {
        string KeyLocator { get; }

        string Actor { get; set; }

        string KeyId { get; }

        DateTime NotBefore { get; }

        DateTime NotAfter { get; }

        bool Disabled { get; }

        //PublicKey PublicKey { get; }

        Task<bool> VerifyAsync(byte[] digest, byte[] signature, string algorithm);

        Task<bool> VerifyAsync(byte[] digest, byte[] signature, string algorithm, CancellationToken token);
        
        Task<bool> VerifyAsync(byte[] digest, string signature, string algorithm);

        Task<bool> VerifyAsync(byte[] digest, string signature, string algorithm, CancellationToken token);

        Task<bool> VerifyAsync(string hex, string signature);

        Task<bool> VerifyAsync(string hex, string signature, CancellationToken token);

        Task<byte[]> WrapKeyAsync(byte[] key);

        Task<byte[]> WrapKeyAsync(byte[] key, CancellationToken token);

        //string PublicKeyToPEM();

    }
}
