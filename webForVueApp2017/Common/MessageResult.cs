using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MessageResult
    {
        public MessageResult()
        {

        }
        public MessageResult(bool success, string message, object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static MessageResult CreateSuccessResult(string message = "成功", Object data = null)
        {
            MessageResult mr = CreateMessageResult(true, message);
            mr.Data = data;
            return mr;
        }

        public static MessageResult CreateFailResult(string message = "失败", Object data = null)
        {
            MessageResult mr = CreateMessageResult(false, message);
            mr.Data = data;
            return mr;
        }

        public static MessageResult CreateMessageResult(bool success, string message)
        {
            MessageResult mr = new MessageResult();
            mr.Success = success;
            mr.Message = message;
            return mr;
        }
        public override string ToString()
        {
            return string.Format("Success:{0}, Message:{1}, Data:{2}", Success, Message, Data);
        }
    }
}
