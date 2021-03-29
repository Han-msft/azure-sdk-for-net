// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.DocumentTranslation
{
    internal partial class DocumentTranslationGetOperationDocumentsStatusHeaders
    {
        private readonly Response _response;
        public DocumentTranslationGetOperationDocumentsStatusHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates how long to wait before making a new request. </summary>
        public int? RetryAfter => _response.Headers.TryGetValue("Retry-After", out int? value) ? value : null;
    }
}
