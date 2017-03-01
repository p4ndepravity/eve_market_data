﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Eve_Market_Data.ItemOrderListPageJsonTypes;

namespace Eve_Market_Data.ItemOrderListPageJsonTypes
{

    public class Location
    {

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Type
    {

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Item
    {

        [JsonProperty("volume_str")]
        public string VolumeStr { get; set; }

        [JsonProperty("buy")]
        public bool Buy { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volumeEntered")]
        public int VolumeEntered { get; set; }

        [JsonProperty("minVolume")]
        public int MinVolume { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("duration_str")]
        public string DurationStr { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("minVolume_str")]
        public string MinVolumeStr { get; set; }

        [JsonProperty("volumeEntered_str")]
        public string VolumeEnteredStr { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }
    }

}

namespace Eve_Market_Data
{

    public class ItemOrderListPage
    {

        [JsonProperty("totalCount_str")]
        public string TotalCountStr { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("pageCount_str")]
        public string PageCountStr { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }

}