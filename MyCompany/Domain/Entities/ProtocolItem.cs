using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ProtocolItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните заголовок сообщения")]
        [Display(Name = "Заголовок сообщения")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание сообщения")]
        public override string Subtitle { get; set; }

        [Display(Name = "Текст сообщения")]
        public override string Text { get; set; }

        [Display(Name = "Прикрепленный документ")]
        public string DocPath { get; set; }
    }
}
