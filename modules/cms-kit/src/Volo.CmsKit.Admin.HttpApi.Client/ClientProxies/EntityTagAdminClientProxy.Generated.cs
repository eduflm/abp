// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.CmsKit.Admin.Tags;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Admin.Tags.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IEntityTagAdminAppService), typeof(EntityTagAdminClientProxy))]
    public partial class EntityTagAdminClientProxy : ClientProxyBase<IEntityTagAdminAppService>, IEntityTagAdminAppService
    {
        public virtual async Task AddTagToEntityAsync(EntityTagCreateDto input)
        {
            await RequestAsync(nameof(AddTagToEntityAsync), input);
        }

        public virtual async Task RemoveTagFromEntityAsync(EntityTagRemoveDto input)
        {
            await RequestAsync(nameof(RemoveTagFromEntityAsync), input);
        }

        public virtual async Task SetEntityTagsAsync(EntityTagSetDto input)
        {
            await RequestAsync(nameof(SetEntityTagsAsync), input);
        }
    }
}