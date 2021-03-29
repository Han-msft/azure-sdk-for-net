// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class FileSystemList
    {
        internal static FileSystemList DeserializeFileSystemList(JsonElement element)
        {
            Optional<IReadOnlyList<FileSystem>> filesystems = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filesystems"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FileSystem> array = new List<FileSystem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FileSystem.DeserializeFileSystem(item));
                    }
                    filesystems = array;
                    continue;
                }
            }
            return new FileSystemList(Optional.ToList(filesystems));
        }
    }
}
