﻿/*
 * ========================================================================
 * Copyright(c) 2013-2014 郑州优创科技有限公司, All Rights Reserved.
 * ========================================================================
 *  
 * 【实体类】
 *  
 *  
 * 作者：唐有炜   时间：2014-11-05 18:10:48
 * 文件名：TSysLog 
 * 版本：V1.0.0
 * 
 * 修改者：唐有炜           时间：2014-11-05 18:10:48            
 * 修改说明：修改说明
 * ========================================================================
*/
using System;
using System.Collections.Generic;
using System.Linq;
using NLite.Data;
namespace UCsoft.Entity
{
	[Table("T_sys_log")]
	public partial class TSysLog 
	{
	
		[Id("id",IsDbGenerated=true)]
		public Int32 Id { get;set; }
 
		[Column("user_id")]
		public Int32 UserId { get;set; }
		[Column("user_lname")]
		public String UserLname { get;set; }
		[Column("log_action")]
		public String LogAction { get;set; }
		[Column("log_remark")]
		public String LogRemark { get;set; }
		[Column("log_ip")]
		public String LogIp { get;set; }
		[Column("log_place")]
		public String LogPlace { get;set; }
		[Column("log_time")]
		public DateTime? LogTime { get;set; }
 
 
 
	}
  
}




