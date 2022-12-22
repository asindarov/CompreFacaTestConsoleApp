﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ComprefaceTestApp.DTOs.ExampleSubject.DownloadImageById
{
    public class DownloadImageByIdRequest : ImageBase
    {
        public Guid RecognitionApiKey { get; set; }
    }
}
