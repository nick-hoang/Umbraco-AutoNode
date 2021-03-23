using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Core.Persistence;
using Umbraco.Core;
using Umbraco.Core.Persistence.Querying;
using Umbraco.Core.Services;
using Umbraco.Core.Persistence.DatabaseModelDefinitions;

namespace DotSee
{
    internal static class Extensions
    {
        public static bool HasChildren(this IContent content)
        {
            return Umbraco.Core.Composing.Current.Services.ContentService.HasChildren(content.Id);
        }

        public static int CountChildren(this IContent content, string childDocType = null)
        {
            return Umbraco.Core.Composing.Current.Services.ContentService.CountChildren(content.Id, childDocType);
        }

        /// <summary>
        /// Get last children
        /// </summary>
        /// <param name="content"></param>
        /// <param name="order">Default is sortOrder</param>
        /// <param name="predicate">filter</param>
        /// <returns></returns>
        public static IContent LastChildren(this IContent content, 
            string order = "sortOrder", Direction direction = Direction.Ascending, 
            Expression<Func<IContent, bool>> predicate = null)
        {
            long total;
            IQuery<IContent> filter = null;
            if (predicate != null)
            {
                var _sqlContext = Umbraco.Core.Composing.Current.Factory.GetInstance<ISqlContext>();
                filter = _sqlContext.Query<IContent>().Where(predicate);
            }
            
            Ordering ordering = null;            
            if (!string.IsNullOrEmpty(order))
            {
                var real_direction = direction == Direction.Ascending ? Direction.Descending : Direction.Ascending;
                ordering = Ordering.By(order, real_direction, null, false);                                
            }

            return Umbraco.Core.Composing.Current.Services.ContentService.GetPagedChildren(content.Id, 0, 1, out total, filter, ordering).FirstOrDefault();
        }

        /// <summary>
        /// Get last children
        /// </summary>
        /// <param name="content"></param>
        /// <param name="order">Default is sortOrder</param>
        /// <param name="predicate">filter</param>
        /// <returns></returns>
        public static IContent FirstChildren(this IContent content,
            string order = "sortOrder", Direction direction = Direction.Ascending, 
            Expression<Func<IContent, bool>> predicate = null)
        {
            long total;
            IQuery<IContent> filter = null;
            if (predicate != null)
            {
                var _sqlContext = Umbraco.Core.Composing.Current.Factory.GetInstance<ISqlContext>();
                filter = _sqlContext.Query<IContent>().Where(predicate);
            }

            Ordering ordering = null;
            if (!string.IsNullOrEmpty(order))
            {
                ordering = Ordering.By(order, direction, null, false);
            }

            return Umbraco.Core.Composing.Current.Services.ContentService.GetPagedChildren(content.Id, 0, 1, out total, filter, ordering).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IContent IsExistChildren(this IContent parent, Expression<Func<IContent, bool>> predicate = null)
        {
            long total;

            IQuery<IContent> filter = null;
            if (predicate != null)
            {
                var _sqlContext = Umbraco.Core.Composing.Current.Factory.GetInstance<ISqlContext>();
                filter = _sqlContext.Query<IContent>().Where(predicate);
            }            

            var result = Umbraco.Core.Composing.Current.Services.ContentService.GetPagedChildren(parent.Id, 0, 1, out total, filter);
            return result.FirstOrDefault();
        }

        public static IEnumerable<IContent> Children(this IContent parent, int top, Expression<Func<IContent, bool>> predicate = null, 
            string order = "sortOrder", 
            Direction direction = Direction.Ascending)
        {
            if (top <= 0) return null;

            long total;
            IQuery<IContent> filter = null;
            if (predicate != null)
            {
                var _sqlContext = Umbraco.Core.Composing.Current.Factory.GetInstance<ISqlContext>();
                filter = _sqlContext.Query<IContent>().Where(predicate);
            }
            Ordering ordering = null;
            if (!string.IsNullOrEmpty(order))
            {                
                ordering = Ordering.By(order, direction, null, false);
            }

            return Umbraco.Core.Composing.Current.Services.ContentService.GetPagedChildren(parent.Id, 0, top, out total, filter);            
        }
    }
}
