using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFMessageItemsRepository : IMessageItemsRepository
    {
        private readonly AppDbContext context;
        public EFMessageItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<MessageItem> GetMessageItems()
        {
            return context.MessageItems;
        }

        public MessageItem GetMessageItemById(Guid id)
        {
            return context.MessageItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMessageItem(MessageItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteMessageItem(Guid id)
        {
            context.MessageItems.Remove(new MessageItem() { Id = id });
            context.SaveChanges();
        }
    }
}
