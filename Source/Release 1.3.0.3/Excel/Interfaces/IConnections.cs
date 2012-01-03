//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IConnections SupportByLibraryAttribute Excel, 12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IConnections : COMObject ,IEnumerable<NetOffice.ExcelApi.WorkbookConnection>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IConnections);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConnections(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConnections(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConnections(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConnections() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IConnections(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.WorkbookConnection get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.WorkbookConnection AddFromFile(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Description">string Description</param>
		/// <param name="ConnectionString">object ConnectionString</param>
		/// <param name="CommandText">object CommandText</param>
		/// <param name="lCmdtype">optional object lCmdtype</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText, object lCmdtype)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText, lCmdtype);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Description">string Description</param>
		/// <param name="ConnectionString">object ConnectionString</param>
		/// <param name="CommandText">object CommandText</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 12,14)]
		public NetOffice.ExcelApi.WorkbookConnection Add(string name, string description, object connectionString, object commandText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, description, connectionString, commandText);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.WorkbookConnection this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.ExcelApi.WorkbookConnection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.WorkbookConnection.LateBindingApiWrapperType) as NetOffice.ExcelApi.WorkbookConnection;
				return newObject;
			}
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.WorkbookConnection> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
        public IEnumerator<NetOffice.ExcelApi.WorkbookConnection> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.WorkbookConnection item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}