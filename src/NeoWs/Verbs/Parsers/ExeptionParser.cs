using CommandLine;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeoWs.Verbs.Parsers
{
    public class ExeptionParser
    {
        public Task<int> ExceptionHandling(IEnumerable<Error> errors)
        {
            Console.WriteLine("Something went wrong.");
            return Task.FromResult(0);
        }
    }
}
