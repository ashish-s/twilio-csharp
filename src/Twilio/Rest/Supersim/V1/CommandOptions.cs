/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Supersim.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Send a Command to a Sim.
    /// </summary>
    public class CreateCommandOptions : IOptions<CommandResource>
    {
        /// <summary>
        /// The sid or unique_name of the SIM to send the Command to
        /// </summary>
        public string Sim { get; }
        /// <summary>
        /// The message body of the command
        /// </summary>
        public string Command { get; }
        /// <summary>
        /// The HTTP method we should use to call callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call after we have sent the command
        /// </summary>
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// Construct a new CreateCommandOptions
        /// </summary>
        /// <param name="sim"> The sid or unique_name of the SIM to send the Command to </param>
        /// <param name="command"> The message body of the command </param>
        public CreateCommandOptions(string sim, string command)
        {
            Sim = sim;
            Command = command;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim.ToString()));
            }

            if (Command != null)
            {
                p.Add(new KeyValuePair<string, string>("Command", Command));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a Command instance from your account.
    /// </summary>
    public class FetchCommandOptions : IOptions<CommandResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCommandOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchCommandOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of Commands from your account.
    /// </summary>
    public class ReadCommandOptions : ReadOptions<CommandResource>
    {
        /// <summary>
        /// The SID or unique name of the Sim that Command was sent to or from.
        /// </summary>
        public string Sim { get; set; }
        /// <summary>
        /// The status of the Command
        /// </summary>
        public CommandResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The direction of the Command
        /// </summary>
        public CommandResource.DirectionEnum Direction { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (Direction != null)
            {
                p.Add(new KeyValuePair<string, string>("Direction", Direction.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}