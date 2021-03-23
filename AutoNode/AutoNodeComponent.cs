using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace DotSee
{
    public class AutoNodeComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            // Append our component to the collection of Components
            // It will be the last one to be run
            composition.Components().Append<AutoNodeComponent>();
        }
    }

    public class AutoNodeComponent : IComponent
    {
        // initialize: runs once when Umbraco starts
        public void Initialize()
        {            
            ContentService.Saved += ContentService_Saved;
            ContentService.Published += ContentService_Published;
        }

        private void ContentService_Saved(IContentService sender, ContentSavedEventArgs e)
        {
            foreach (var node in e.SavedEntities)
            {
                AutoNode.Instance.Run(node);
            }
        }

        private void ContentService_Published(IContentService sender, ContentPublishedEventArgs e)
        {
            foreach (var node in e.PublishedEntities)
            {
                AutoNode.Instance.RunPublish(node);
            }
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {
            //unsubscribe during shutdown
            ContentService.Saved -= ContentService_Saved;
            ContentService.Published -= ContentService_Published;
        }
    }
}
