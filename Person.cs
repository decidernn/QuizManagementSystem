//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int ID { get; set; }
        public Nullable<int> IDLearner { get; set; }
        public Nullable<int> IDOrganizer { get; set; }
    
        public virtual Learner Learner { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}