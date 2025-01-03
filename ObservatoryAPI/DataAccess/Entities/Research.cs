﻿using System.Text.Json.Serialization;

namespace ObservatoryAPI.DataAccess.Entities;

public class Research
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int SpaceobjectId { get; set; }
    [JsonIgnore]
    public SpaceObject SpaceObject { get; set; }
}
