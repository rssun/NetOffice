//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface Operations SupportByLibraryAttribute Access, 14
	///</summary>
	[SupportByLibraryAttribute("Access", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Operations : COMObject ,IEnumerable<NetOffice.AccessApi.Operation>
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
                    _type = typeof(Operations);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Operations(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Operations(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Operations(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Operations() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Operations(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Access", 14)]
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
		/// SupportByLibrary Access 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Access", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.AccessApi.Operation this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.AccessApi.Operation newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.AccessApi.Operation.LateBindingApiWrapperType) as NetOffice.AccessApi.Operation;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Access", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibraryAttribute("Access", 14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion

        #region IEnumerable<NetOffice.AccessApi.Operation> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Access, 14
		/// </summary>
		[SupportByLibraryAttribute("Access", 14)]
        public IEnumerator<NetOffice.AccessApi.Operation> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.AccessApi.Operation item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Access, 14
		/// </summary>
		[SupportByLibraryAttribute("Access", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
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