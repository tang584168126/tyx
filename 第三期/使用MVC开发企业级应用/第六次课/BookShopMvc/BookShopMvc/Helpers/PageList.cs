﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShopMvc.Helpers
{
    public class PageList<T>:List<T>
    {
        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex { get; private set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// 总数据条数
        /// </summary>
        public int TotalCount { get; private set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { get; private set; }

        /// <summary>
        /// 分页数据源类构造函数
        /// </summary>
        /// <param name="source">全部数据</param>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        public PageList(List<T> source,int pageIndex,int pageSize,int totalCount)
        {
            pageIndex = pageIndex;
            pageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(TotalCount / (double)pageSize);
            this.AddRange(source.Skip((pageIndex - 1) * pageSize).Take(pageSize));
        }

        /// <summary>
        /// 当前页是否有上一页
        /// </summary>
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        /// <summary>
        /// 当前页是否有下一页
        /// </summary>
        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
    }
}