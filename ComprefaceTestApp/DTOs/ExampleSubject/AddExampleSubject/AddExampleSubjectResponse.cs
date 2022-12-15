﻿using System.Text.Json.Serialization;

namespace ComprefaceTestApp.DTOs.ExampleSubject.AddExampleSubject;

public class AddExampleSubjectResponse
{
    [JsonPropertyName("image_id")]
    public Guid ImageId { get; set; }

    public string Subject { get; set; }
}