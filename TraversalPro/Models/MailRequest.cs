﻿namespace TraversalPro.Models
{
    public class MailRequest //mailkit indirilmedi
    {
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; } //alıcı
        public string Subject { get; set; } //konu
        public string Body { get; set; }
    }
}