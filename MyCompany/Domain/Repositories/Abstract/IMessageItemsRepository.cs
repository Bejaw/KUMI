using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IMessageItemsRepository
    {
        IQueryable<MessageItem> GetMessageItems();
        MessageItem GetMessageItemById(Guid id);
        void SaveMessageItem(MessageItem entity);
        void DeleteMessageItem(Guid id);
    }
}
