//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataStorage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public Question()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual QuestionStatus QuestionStatus { get; set; }
    }
}
