using System;

namespace Xamarin.FacebookBinding.Model {

	[global::Android.Runtime.Annotation ("com.facebook.model.PropertyName")]
	public partial class PropertyNameAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
