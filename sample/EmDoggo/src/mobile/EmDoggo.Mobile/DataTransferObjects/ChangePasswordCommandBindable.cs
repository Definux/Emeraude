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
	public class ChangePasswordCommandBindable : BindableBase
	{
		private Guid? userId;
		private string currentPassword;
		private string newPassword;
		private string confirmedPassword;

		public Guid? UserId 
		{ 
			get
			{
				return this.userId;
			}
			set
			{
				SetProperty(ref this.userId, value); 
			}
		}

		public string CurrentPassword 
		{ 
			get
			{
				return this.currentPassword;
			}
			set
			{
				SetProperty(ref this.currentPassword, value); 
			}
		}

		public string NewPassword 
		{ 
			get
			{
				return this.newPassword;
			}
			set
			{
				SetProperty(ref this.newPassword, value); 
			}
		}

		public string ConfirmedPassword 
		{ 
			get
			{
				return this.confirmedPassword;
			}
			set
			{
				SetProperty(ref this.confirmedPassword, value); 
			}
		}
	}
}