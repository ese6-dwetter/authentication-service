﻿namespace UserMicroservice.Settings
{
    public class TokenSettings
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
