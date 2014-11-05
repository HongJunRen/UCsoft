﻿/*
 * ========================================================================
 * Copyright(c) 2013-2014 郑州优创科技有限公司, All Rights Reserved.
 * ========================================================================
 *  
 * 【实体类】
 *  
 *  
 * 作者：唐有炜   时间：2014-11-05 18:10:48
 * 文件名：TCusCon 
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
	[Table("T_cus_con")]
	public partial class TCusCon 
	{
	
		[Id("id",IsDbGenerated=true)]
		public Int32 Id { get;set; }
 
		[Column("cus_id")]
		public Int32 CusId { get;set; }
		[Column("comp_num")]
		public String CompNum { get;set; }
		[Column("con_name")]
		public String ConName { get;set; }
		[Column("con_tel")]
		public String ConTel { get;set; }
		[Column("con_qq")]
		public String ConQq { get;set; }
		[Column("con_email")]
		public String ConEmail { get;set; }
		[Column("con_bir")]
		public DateTime? ConBir { get;set; }
		[Column("con_note")]
		public String ConNote { get;set; }
		[Column("con_is_main")]
		public Int32 ConIsMain { get;set; }
		[Column("user_id")]
		public Int32 UserId { get;set; }
		[Column("con_fields")]
		public String ConFields { get;set; }
 
 
 
	}
  
}




