﻿/*
 * ========================================================================
 * Copyright(c) 2013-2014 郑州优创科技有限公司, All Rights Reserved.
 * ========================================================================
 *  
 * 【实体类】
 *  
 *  
 * 作者：唐有炜   时间：2014-11-05 18:10:48
 * 文件名：TCusBase 
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
	[Table("T_cus_base")]
	public partial class TCusBase 
	{
	
		[Id("id",IsDbGenerated=true)]
		public Int32 Id { get;set; }
 
		[Column("cus_no")]
		public String CusNo { get;set; }
		[Column("comp_num")]
		public String CompNum { get;set; }
		[Column("cus_name")]
		public String CusName { get;set; }
		[Column("cus_sname")]
		public String CusSname { get;set; }
		[Column("cus_lastid")]
		public Int32? CusLastid { get;set; }
		[Column("cus_tel")]
		public String CusTel { get;set; }
		[Column("cus_city")]
		public String CusCity { get;set; }
		[Column("cus_industry")]
		public String CusIndustry { get;set; }
		[Column("cus_address")]
		public String CusAddress { get;set; }
		[Column("cus_note")]
		public String CusNote { get;set; }
		[Column("con_id")]
		public Int32 ConId { get;set; }
		[Column("user_id")]
		public Int32 UserId { get;set; }
		[Column("con_team")]
		public String ConTeam { get;set; }
		[Column("con_is_pub")]
		public Int32 ConIsPub { get;set; }
		[Column("con_back")]
		public Int32 ConBack { get;set; }
		[Column("cus_createTime")]
		public DateTime? CusCreateTime { get;set; }
		[Column("cus_fields")]
		public String CusFields { get;set; }
 
 
 
	}
  
}




