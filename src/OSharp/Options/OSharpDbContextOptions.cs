﻿// -----------------------------------------------------------------------
//  <copyright file="DbContextConfig.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-03 0:54</last-date>
// -----------------------------------------------------------------------

using System;

using OSharp.Entity;


namespace OSharp.Options
{
    /// <summary>
    /// 数据上下文配置节点
    /// </summary>
    public class OSharpDbContextOptions
    {
        /// <summary>
        /// 初始化一个<see cref="OSharpDbContextOptions"/>类型的新实例
        /// </summary>
        public OSharpDbContextOptions()
        {
            AuditEntityEnabled = true;
        }

        /// <summary>
        /// 获取 上下文类型
        /// </summary>
        public Type DbContextType => string.IsNullOrEmpty(DbContextTypeName) ? null : Type.GetType(DbContextTypeName);

        /// <summary>
        /// 获取或设置 上下文类型全名
        /// </summary>
        public string DbContextTypeName { get; set; }

        /// <summary>
        /// 获取或设置 连接字符串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 获取或设置 数据库类型
        /// </summary>
        public DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// 获取或设置 是否允许审计实体
        /// </summary>
        public bool AuditEntityEnabled { get; set; }
    }
}