using System;
using System.Collections.Generic;

namespace Mocking
{
    public class MailBox
    {
        List<Mail> MailList = new List<Mail>(); 
        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

        public void Add(Mail incomingMail)
        {
          new Mail();
           MailList.Add(incomingMail);
            NumReceivedMessages += 1;
            
        }

        public string GetLatestMessageText()
        {
            return MailList[NumReceivedMessages - 1].Content;
        }
    }
}