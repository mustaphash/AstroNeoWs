﻿using CommandLine;
using NeoWs.Verbs;
using NeoWs.Verbs.Parsers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeoWs
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Parser.Default.ParseArguments<MarsPhotoVerb,AsteroidVerb>(args)
                .MapResult(
                (MarsPhotoVerb opts)=> new MarsPhotoParser().PhotoParse(opts).GetAwaiter().GetResult(),
                (AsteroidVerb opts) => new AsteroidParser().ParseAstro().GetAwaiter().GetResult(),
                (IEnumerable<Error> errs) => new ExeptionParser().ExceptionHandling(errs).GetAwaiter().GetResult());
        }
        
}
}