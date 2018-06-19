# Streams

Allow to use the using/dispose pattern for many streams with a single using statement:

    using(var streams = new Streams(/*...*/))
	{
		//do something with streams, they all will be disposed when leaving the using
	}