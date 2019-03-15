using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 查询分页的输出结果的常用包装类
    /// 用于逐渐取代PageRecords
    /// </summary>
    /// <typeparam name="TOutputDto"></typeparam>
    public class PagerQueryResult<TOutputDto>
    {
        public PagerQueryResult()
        {
            Result = new List<TOutputDto>();
            PageIndex = 1;
            PageSize = 10;
            TotalCount = 0;
        }

        public IList<TOutputDto> Result { get; set; }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPageCount
        {
            get
            {
                return (int)Math.Ceiling(TotalCount / (double)PageSize);
            }
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {

            get
            {
                return (PageIndex < TotalPageCount);
            }
        }
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagerQueryResult<TOutputDto> Create(IEnumerable<TOutputDto> source, int pageIndex, int pageSize, int totalCount)
        {
            var instance = new PagerQueryResult<TOutputDto>();

            //NbGuard.MakeSureBetweenInclusive(pageIndex, 1, int.MaxValue);
            //NbGuard.MakeSureBetweenInclusive(pageSize, 1, int.MaxValue);
            //NbGuard.MakeSureBetweenInclusive(totalCount, 0, int.MaxValue);

            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (pageIndex < 0 || pageSize < 0)
            {
                // Check: check if pageSize > totalCount.
                // Check: check if int parameters < 0.
                throw new ArgumentException("非法的参数");
            }

            foreach (var item in source)
            {
                instance.Result.Add(item);
            }

            instance.PageIndex = pageIndex;
            instance.PageSize = pageSize;
            instance.TotalCount = totalCount;

            return instance;
        }

        /// <summary>
        /// 返回空的结果
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagerQueryResult<TOutputDto> CreateEmpty(int pageIndex, int pageSize)
        {
            var instance = new PagerQueryResult<TOutputDto>();

            instance.PageIndex = pageIndex;
            instance.PageSize = pageSize;
            instance.TotalCount = 0;

            return instance;
        }
    }

    #region extensions

    /// <summary>
    /// 查询分页的输出结果的常用包装类的扩展
    /// </summary>
    public static class PagerQueryResultExtensions
    {
        /// <summary>
        /// 带分页的结果
        /// </summary>
        /// <typeparam name="TOutputDto"></typeparam>
        /// <param name="source"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PagerQueryResult<TOutputDto> WithPage<TOutputDto>(this IEnumerable<TOutputDto> source, int pageIndex, int pageSize, int totalCount)
        {
            return PagerQueryResult<TOutputDto>.Create(source, pageIndex, pageSize, totalCount);
        }
    }

    #endregion
}
