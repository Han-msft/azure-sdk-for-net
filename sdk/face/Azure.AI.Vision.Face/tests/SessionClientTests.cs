// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Vision.Face.Tests
{
    public class SessionClientTests : RecordedTestBase<FaceSessionTestEnvironment>
    {
        public const string TEST_DEVICE_CORELATION_ID = "dummy-test-id";
        public const string TEST_LIVENESS_OPERATION_MODE = "Passive";

        public SessionClientTests(bool isAsync) : base(isAsync)
        {
            SanitizedHeaders.Add("Ocp-Apim-Subscription-Key");
        }

        public SessionClient CreateClient()
        {
            return InstrumentClient(new SessionClient(
                TestEnvironment.GetUrlVariable("FACE_ENDPOINT"),
                TestEnvironment.GetKeyVariable("FACE_SUBSCRIPTION_KEY"),
                InstrumentClientOptions(new SessionClientOptions())));
        }

        private async Task TestWithCreateAndDeleteSessionsAsync(int numberOfSessions, Func<SessionClient, IList<string>, Task> testFunc)
        {
            var client = CreateClient();
            var sessionIds = new List<string>();
            try
            {
                var request = new LivenessSessionCreationContent(TEST_DEVICE_CORELATION_ID, TEST_LIVENESS_OPERATION_MODE);

                for (int i = 0; i < numberOfSessions; i++)
                {
                    var response = await client.CreateLivenessSessionAsync(request);
                    sessionIds.Add(response.Value.SessionId);
                }

                await testFunc(client, sessionIds);
            }
            finally
            {
                foreach (var sessionId in sessionIds)
                {
                    await client.DeleteLivenessSessionAsync(sessionId);
                }
            }
        }

        [RecordedTest]
        public async Task GetLivenessSessionAuditEntries()
        {
            const string sessionId = "461269e4-acff-4e3d-8f24-ffaff65d838c";
            const int numberOfEntries = 3;
            const int topLimit = 1;

            var client = CreateClient();
            var responseAll = await client.GetLivenessSessionAuditEntriesAsync(sessionId);
            var entriesAll = responseAll.Value;
            Assert.AreEqual(numberOfEntries, entriesAll.Count);

            foreach (var entry in entriesAll)
            {
                Assert.AreEqual(sessionId, entry.SessionId);
                Assert.That(entry.RequestId, Is.Not.Null.Or.Empty);
                Assert.That(entry.ClientRequestId, Is.Not.Null.Or.Empty);
                Assert.That(entry.ReceivedDateTime, Is.Not.Null.Or.Empty);
                Assert.That(entry.Digest, Is.Not.Null.Or.Empty);
                Assert.That(entry.Request.Url, Is.Not.Null.Or.Empty);
                Assert.That(entry.Request.Method, Is.Not.Null.Or.Empty);
                Assert.That(entry.Request.ContentType, Is.Not.Null.Or.Empty);
                Assert.That(entry.Response.Body, Is.Not.Null.Or.Empty);
                Assert.That(entry.Response.StatusCode, Is.Not.Null.Or.Empty);
                Assert.That(entry.Response.LatencyInMilliseconds, Is.Not.Null.Or.Empty);
            }

            var responseWithQuery = await client.GetLivenessSessionAuditEntriesAsync(sessionId, start: entriesAll[0].Id.ToString(), top: topLimit);
            Assert.AreEqual(topLimit, responseWithQuery.Value.Count);
            Assert.AreEqual(entriesAll[1].Id, responseWithQuery.Value.First().Id);
        }

        [RecordedTest]
        public async Task GetLivenessSessions()
        {
            const int numberOfSessions = 3;

            await TestWithCreateAndDeleteSessionsAsync(numberOfSessions, async (client, _) =>
            {
                var response = await client.GetLivenessSessionsAsync();
                Assert.AreEqual(numberOfSessions, response.Value.Count);

                foreach (var session in response.Value)
                {
                    Assert.AreEqual(TEST_DEVICE_CORELATION_ID, session.DeviceCorrelationId);
                    Assert.AreEqual(600, session.AuthTokenTimeToLiveInSeconds);
                    Assert.AreEqual(false, session.SessionExpired);
                    Assert.That(session.CreatedDateTime, Is.Not.Null.Or.Empty);
                }

                // Not working now
                //var responseWithQuery = await client.GetLivenessSessionsAsync(start: response.Value[0].Id.ToString(), top: 1);
                //Assert.AreEqual(1, responseWithQuery.Value.Count);
                //Assert.AreEqual(response.Value[1].Id, responseWithQuery.Value.First().Id);
            });
        }

        [RecordedTest]
        [TestCase("Passive")]
        [TestCase("PassiveActive")]
        public async Task Create_Get_Delete_LivenessSession(string livenessOperationMode)
        {
            var client = CreateClient();

            var request = new LivenessSessionCreationContent(TEST_DEVICE_CORELATION_ID, livenessOperationMode);

            var createResponse = await client.CreateLivenessSessionAsync(request);
            Assert.That(createResponse.Value.SessionId, Is.Not.Null.Or.Empty);
            Assert.That(createResponse.Value.AuthToken, Is.Not.Null.Or.Empty);
            var sessionId = createResponse.Value.SessionId;

            var getResponse = await client.GetLivenessSessionAsync(sessionId);
            var session = getResponse.Value;
            Assert.AreEqual(sessionId, session.Id);
            Assert.AreEqual(SessionStatus.NotStarted, session.Status);
            Assert.AreEqual(TEST_DEVICE_CORELATION_ID, session.DeviceCorrelationId);
            Assert.AreEqual(600, session.AuthTokenTimeToLiveInSeconds);
            Assert.AreEqual(false, session.SessionExpired);
            Assert.That(session.CreatedDateTime, Is.Not.Null.Or.Empty);

            var deleteResponse = await client.DeleteLivenessSessionAsync(sessionId);
            Assert.AreEqual(200, deleteResponse.Status);
        }
    }
}
