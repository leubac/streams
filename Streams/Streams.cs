using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Streams
{
    public sealed class Streams : IEnumerable<Stream>, IDisposable
    {
        private readonly IEnumerable<Stream> streams;
        public Streams(IEnumerable<Stream> streams) => this.streams = streams;
        public void Dispose()
        {
            foreach (var stream in streams)
            {
                stream.Dispose();
            }
        }
        public IEnumerator<Stream> GetEnumerator() => streams.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
