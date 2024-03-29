﻿using Exadel.Compreface.Configuration;
using Exadel.Compreface.Services;
using Microsoft.Extensions.Configuration;

namespace Exadel.Compreface;

public class ComprefaceClient
{
    public ExampleSubjectService ExampleSubjectService { get; private set; }

    public SubjectService SubjectService { get; private set; }

    public RecognitionService RecognitionService { get; private set; }

    public ComprefaceClient(string apiKey, string host) : this(new ComprefaceConfiguration(apiKey, host))
    { }

    public ComprefaceClient(IConfiguration configuration, string sectionForApiKey, string sectionForBaseUrl) : this(new ComprefaceConfiguration(configuration, sectionForApiKey, sectionForBaseUrl))
    { }

    public ComprefaceClient(ComprefaceConfiguration comprefaceConfiguration)
    {
        ExampleSubjectService = new ExampleSubjectService(comprefaceConfiguration);
        SubjectService = new SubjectService(comprefaceConfiguration);
        RecognitionService = new RecognitionService(comprefaceConfiguration);
    }
}