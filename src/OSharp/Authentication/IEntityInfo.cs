﻿// -----------------------------------------------------------------------
//  <copyright file="IEntityInfo.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-04 9:18</last-date>
// -----------------------------------------------------------------------

using System.Collections.Generic;


namespace OSharp.Authentication
{
    /// <summary>
    /// 定义数据实体信息
    /// </summary>
    public interface IEntityInfo
    {
        /// <summary>
        /// 获取或设置 实体名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 获取或设置 实体类型名称
        /// </summary>
        string ClassFullName { get; set; }

        /// <summary>
        /// 获取或设置 是否启用数据日志
        /// </summary>
        bool DataLogEnabled { get; set; }

        /// <summary>
        /// 获取 实体属性信息字典
        /// </summary>
        IDictionary<string, string> PropertyNames { get; }
    }
}