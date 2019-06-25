﻿using Newtonsoft.Json;
using PKISharp.WACS.Plugins.Base;
using PKISharp.WACS.Services;
using PKISharp.WACS.Plugins.Base.Options;
using PKISharp.WACS.Services.Serialization;

namespace PKISharp.WACS.Plugins.ValidationPlugins.Dns
{
    [Plugin("aa57b028-45fb-4aca-9cac-a63d94c76b4a")]
    class AzureOptions : ValidationPluginOptions<Azure>
    {
        public override string Name => "Azure";
        public override string Description => "Change records in Azure DNS";
        public override string ChallengeType { get => Constants.Dns01ChallengeType; }

        public string ClientId { get; set; }
        public string ResourceGroupName { get; set; }

        [JsonProperty(propertyName: "SecretSafe")]
        [JsonConverter(typeof(ProtectedStringConverter))]
        public string Secret { get; set; }

        public string SubscriptionId { get; set; }
        public string TenantId { get; set; }
    }
}
