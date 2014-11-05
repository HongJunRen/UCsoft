﻿/*
 * ========================================================================
 * Copyright(c) 2013-2014 郑州优创科技有限公司, All Rights Reserved.
 * ========================================================================
 *  
 * 【实体类】
 *  
 *  
 * 作者：唐有炜   时间：2014-11-05 18:10:48
 * 文件名：TSysUser 
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
	[Table("T_sys_user")]
	public partial class TSysUser 
	{
	
		[Id("id",IsDbGenerated=true)]
		public Int32 Id { get;set; }
 
		[Column("comp_num")]
		public String CompNum { get;set; }
		[Column("user_lname")]
		public String UserLname { get;set; }
		[Column("user_password")]
		public String UserPassword { get;set; }
		[Column("user_tname")]
		public String UserTname { get;set; }
		[Column("user_sex")]
		public Int32 UserSex { get;set; }
		[Column("user_phone")]
		public String UserPhone { get;set; }
		[Column("user_email")]
		public String UserEmail { get;set; }
		[Column("user_tel")]
		public String UserTel { get;set; }
		[Column("user_qq")]
		public String UserQq { get;set; }
		[Column("dep_id")]
		public Int32 DepId { get;set; }
		[Column("role_id")]
		public Int32 RoleId { get;set; }
		[Column("data_ids")]
		public String DataIds { get;set; }
		[Column("data_type")]
		public Int32? DataType { get;set; }
		[Column("user_position")]
		public String UserPosition { get;set; }
		[Column("user_jobstatus")]
		public Int32? UserJobstatus { get;set; }
		[Column("user_enable")]
		public Int32 UserEnable { get;set; }
		[Column("user_regDate")]
		public DateTime? UserRegDate { get;set; }
 
		[ManyToOne(ThisKey="DepId",OtherKey="Id")]
		public TSysDepartment Dep { get;set; }
 
 
	}

}




