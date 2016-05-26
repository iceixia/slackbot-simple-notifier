using System;
using System.Net;
using System.IO;
using System.Text;

namespace confluence.slackbot
{
    public class notifier
    {
        public class config
        {
            public string team;
            public string token;
            public string channel;
        }
        public static bool send(config cfg, string message)
        {
            bool result = false;

            try
            {
                WebRequest request = WebRequest.Create(@"https://" + cfg.team + @".slack.com/services/hooks/slackbot?channel=" + cfg.channel + @"&token=" + cfg.token);
                request.Method = "POST";
                string postData = message.ToString();
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                if (responseFromServer == "ok")
                {
                    result = true;
                }

                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch(Exception)
            {
                result = false;
            }

            return result;
        }
    }
}