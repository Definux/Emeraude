// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Emeraude Client Builder.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Definux.Emeraude.AutoGenerated.DataTransferObjects
{
	public class NestedComplexTypeBindable : BindableBase
	{
		private Guid id;
		private ObservableCollection<DeepNestedComplexTypeBindable> deepCollection;

		public Guid Id 
		{ 
			get
			{
				return this.id;
			}
			set
			{
				SetProperty(ref this.id, value); 
			}
		}

		public ObservableCollection<DeepNestedComplexTypeBindable> DeepCollection 
		{ 
			get
			{
				return this.deepCollection;
			}
			set
			{
				SetProperty(ref this.deepCollection, value); 
			}
		}
	}
}
