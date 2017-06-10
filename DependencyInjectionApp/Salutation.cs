using System;

namespace DependencyInjectionApp
{ 
    public class Salutation
    {
        private readonly IMessageWriter _writer;
        public Salutation(IMessageWriter writer)
        {
            _writer = writer ?? throw new ArgumentNullException("writer");
        }

        public void Exclaim()
        {
            _writer.Write("Hello DI!");
        }
    } 
}
