﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B2Net.Models
{
    public class B2DownloadAuthorization
    {
	    public string BucketId { get; set; }
	    public string FileNamePrefix { get; set; }
	    public string AuthorizationToken { get; set; }
    }
}
