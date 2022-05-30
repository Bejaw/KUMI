using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IMessageItemsRepository MessageItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IMessageItemsRepository MessageItemsRepository)
        {
            TextFields = textFieldsRepository;
            MessageItems = MessageItemsRepository;

        }
    }
}
