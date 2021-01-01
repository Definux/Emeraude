// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Emeraude Client Builder.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Definux.Emeraude.AutoGenerated.DataTransferObjects;
using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Definux.Emeraude.AutoGenerated.ServiceAgents
{
    public class EnumsServiceAgent : ServiceAgent, IEnumsServiceAgent
    {
        public EnumsServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
            : base(configuration, clientFactory)
        {
        }

        public async Task<ObservableCollection<EnumValueItemBindable>> GetEnumValueListAsync(string enumTypeName)
        {
	        return await GetAsync<ObservableCollection<EnumValueItemBindable>>($"/api/enums/{enumTypeName}");
        }

        public async Task<EnumValueItemBindable> GetEnumValueAsync(string enumTypeName, int value)
        {
	        return await GetAsync<EnumValueItemBindable>($"/api/enums/{enumTypeName}/{value}");
        }
    }
}