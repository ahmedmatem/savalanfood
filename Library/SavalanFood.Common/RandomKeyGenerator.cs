namespace SavalanFood.Common
{
    using System;

    public static class RandomKeyGenerator
    {
        public static string GenerateKey()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
