﻿using Umbraco.Core.Logging;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;

using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace DotSee.AutoNode
{
    public class AutoNodeBootstrapper : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<SubscribeToContentServicePublishedComponent>();
        }
    }

    public class SubscribeToContentServicePublishedComponent : IComponent
    {

        private readonly ILogger _logger;
        private readonly IContentService _cs;
        private readonly IContentTypeService _cts;
        private readonly IRuleProvider _rp;
        private readonly AutoNode _autoNode;

        public SubscribeToContentServicePublishedComponent(ILogger logger, IContentService cs, IContentTypeService cts)
        {
            _logger = logger;
            _cs = cs;
            _cts = cts;
            _rp = new ConfigFileRuleProvider();
            _autoNode = new AutoNode(_logger, _cs, _cts, _rp);

        }
        public void Initialize()
        {
            ContentService.Published += ContentServicePublished;
        }

        private void ContentServicePublished(IContentService sender, ContentPublishedEventArgs e)
        {
            
            foreach (var node in e.PublishedEntities)
            {
                _autoNode.Run(node);
            }
        }

        public void Terminate()
        {
        }
    }
}