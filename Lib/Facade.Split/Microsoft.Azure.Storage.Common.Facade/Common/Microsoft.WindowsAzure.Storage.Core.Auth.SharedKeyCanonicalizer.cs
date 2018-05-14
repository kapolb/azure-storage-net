using Microsoft.Azure.Storage.Core.Util;
using System;
using System.Collections.Generic;
using System.Net;


namespace Microsoft.Azure.Storage.Core.Auth
{
public sealed class SharedKeyCanonicalizer : ICanonicalizer
{
    private static SharedKeyCanonicalizer instance = new SharedKeyCanonicalizer();
    private const string SharedKeyAuthorizationScheme = "SharedKey";

    public static SharedKeyCanonicalizer Instance
    {
        get
        {
            throw new System.NotImplementedException();
        }
    }

    public string AuthorizationScheme
    {
        get
        {
            throw new System.NotImplementedException();
        }
    }

    private SharedKeyCanonicalizer()
    {
        throw new System.NotImplementedException();
    }

}

}