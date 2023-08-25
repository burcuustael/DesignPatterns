﻿namespace DesignPattern.Decorator.DAL
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageSender { get; set; }
        public string MessageReceiver { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
    }
}
