﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace PassPro.Entities
{
    /// <summary>
    /// 实体类pass。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("passes")]
    [Serializable]
    public partial class pass : Entity
    {
        #region Model
		private string _id;
		private string _title;
		private string _pwd;
		private string _remark;
		private DateTime _updatetime;
		private string _category;
		private bool _isdel;
		private string _userid;

		/// <summary>
		/// 
		/// </summary>
		[Field("id")]
		public string id
		{
			get{ return _id; }
			set
			{
				this.OnPropertyValueChange("id");
				this._id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("title")]
		public string title
		{
			get{ return _title; }
			set
			{
				this.OnPropertyValueChange("title");
				this._title = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("pwd")]
		public string pwd
		{
			get{ return _pwd; }
			set
			{
				this.OnPropertyValueChange("pwd");
				this._pwd = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("remark")]
		public string remark
		{
			get{ return _remark; }
			set
			{
				this.OnPropertyValueChange("remark");
				this._remark = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("updatetime")]
		public DateTime updatetime
		{
			get{ return _updatetime; }
			set
			{
				this.OnPropertyValueChange("updatetime");
				this._updatetime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("category")]
		public string category
		{
			get{ return _category; }
			set
			{
				this.OnPropertyValueChange("category");
				this._category = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("isdel")]
		public bool isdel
		{
			get{ return _isdel; }
			set
			{
				this.OnPropertyValueChange("isdel");
				this._isdel = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("userid")]
		public string userid
		{
			get{ return _userid; }
			set
			{
				this.OnPropertyValueChange("userid");
				this._userid = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.id,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.id,
				_.title,
				_.pwd,
				_.remark,
				_.updatetime,
				_.category,
				_.isdel,
				_.userid,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._title,
				this._pwd,
				this._remark,
				this._updatetime,
				this._category,
				this._isdel,
				this._userid,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "passes");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field title = new Field("title", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field pwd = new Field("pwd", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field remark = new Field("remark", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field updatetime = new Field("updatetime", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field category = new Field("category", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field isdel = new Field("isdel", "passes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field userid = new Field("userid", "passes", "");
        }
        #endregion
	}
}