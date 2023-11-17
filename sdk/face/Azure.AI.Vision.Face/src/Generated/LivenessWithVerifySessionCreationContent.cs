// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.Vision.Face
{
    /// <summary> Request of liveness with verify session creation. </summary>
    public partial class LivenessWithVerifySessionCreationContent
    {
        /// <summary> Initializes a new instance of LivenessWithVerifySessionCreationContent. </summary>
        /// <param name="parameters"> The json for creating liveness session. </param>
        /// <param name="verifyImage"> The image stream for verify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> or <paramref name="verifyImage"/> is null. </exception>
        public LivenessWithVerifySessionCreationContent(LivenessSessionCreationContent parameters, BinaryData verifyImage)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(verifyImage, nameof(verifyImage));

            Parameters = parameters;
            VerifyImage = verifyImage;
        }

        /// <summary> The json for creating liveness session. </summary>
        public LivenessSessionCreationContent Parameters { get; }
        /// <summary>
        /// The image stream for verify.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData VerifyImage { get; }
    }
}
