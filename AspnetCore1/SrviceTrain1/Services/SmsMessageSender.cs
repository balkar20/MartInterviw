﻿namespace SrviceTrain1.Services
{
    public class SmsMessageSender:IMessageSender
    {
        public string Send()
        {
            return "Sent by SMS";
        }
    }
}