using System;

namespace PartialTest
{
	public partial class Greetings
	{
		partial void SetHelloMessage ()
		{
			_helloMessage = "Hello from iOS!";
		}
	}
}

