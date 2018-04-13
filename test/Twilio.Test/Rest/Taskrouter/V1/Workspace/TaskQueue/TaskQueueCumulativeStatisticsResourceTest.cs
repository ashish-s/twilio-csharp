/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue;

namespace Twilio.Tests.Rest.Taskrouter.V1.Workspace.TaskQueue 
{

    [TestFixture]
    public class TaskQueueCumulativeStatisticsTest : TwilioTest 
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Taskrouter,
                "/v1/Workspaces/WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/TaskQueues/WQXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/CumulativeStatistics",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                TaskQueueCumulativeStatisticsResource.Fetch("WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "WQXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"reservations_created\": 100,\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservations_rejected\": 100,\"tasks_completed\": 100,\"end_time\": \"2015-07-30T20:00:00Z\",\"tasks_entered\": 100,\"tasks_canceled\": 100,\"reservations_accepted\": 100,\"task_queue_sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservations_timed_out\": 100,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/CumulativeStatistics\",\"wait_duration_until_canceled\": {\"avg\": 0,\"min\": 0,\"max\": 0,\"total\": 0},\"wait_duration_until_accepted\": {\"avg\": 0,\"min\": 0,\"max\": 0,\"total\": 0},\"split_by_wait_time\": {\"5\": {\"above\": {\"tasks_canceled\": 0,\"reservations_accepted\": 0},\"below\": {\"tasks_canceled\": 0,\"reservations_accepted\": 0}},\"10\": {\"above\": {\"tasks_canceled\": 0,\"reservations_accepted\": 0},\"below\": {\"tasks_canceled\": 0,\"reservations_accepted\": 0}}},\"start_time\": \"2015-07-30T20:00:00Z\",\"tasks_moved\": 100,\"reservations_canceled\": 100,\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"tasks_deleted\": 100,\"reservations_rescinded\": 100,\"avg_task_acceptance_time\": 100}"
                                     ));

            var response = TaskQueueCumulativeStatisticsResource.Fetch("WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "WQXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}