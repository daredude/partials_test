using System;

namespace PartialTest
{
	public partial class Greetings
	{
		/// <summary>
		/// since partial methods can not return string
		/// you need a field to assign result values;
		/// </summary>
		protected string _helloMessage;

		/// <summary>
		/// shared code on all platforms
		/// </summary>
		public string SayHello ()
		{
			SetHelloMessage ();
			return _helloMessage;
		}

		/// <summary>
		/// this method needs a platform specific implementation.
		/// having the definition here in the shared code gives you 
		/// intellisense in the associated class in the platform
		/// specific project. just type 'partial ' and see the method 
		/// definitions to implement.
		/// 
		/// this way your code is way cleaner than using compiler directives
		/// </summary>
		partial void SetHelloMessage ();
	}
}

