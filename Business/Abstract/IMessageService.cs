﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        List<Message> GetIsDraft();
        List<Message> GetTrash();
        List<Message> GetReadList();
        List<Message> GetUnReadList();
     
        void MessageAdd(Message message);
        Message GetById(int id);
        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}
