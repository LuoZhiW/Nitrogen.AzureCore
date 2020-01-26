﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nitrogen.Foundation.Page
{
    /// <summary>
    /// 分页参数.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// 每页行数.
        /// </summary>
        public int rows { get; set; }

        /// <summary>
        /// 当前页.
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 排序列.
        /// </summary>
        public string sidx { get; set; }

        /// <summary>
        /// 排序类型.
        /// </summary>
        public string sord { get; set; }

        /// <summary>
        /// 总记录数.
        /// </summary>
        public int records { get; set; }

        public int total
        {
            get
            {
                if (records > 0)
                {
                    return records % this.rows == 0 ? records / this.rows : records / this.rows + 1;
                }
                else 
                {
                    return 0;
                }
            
            }
        }

        /// <summary>
        /// 查询条件json.
        /// </summary>
        public string conditionJson { get; set; }
    }
}
