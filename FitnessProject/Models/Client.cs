//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.appointments = new HashSet<appointment>();
            this.Posts = new HashSet<Post>();
            this.training_process = new HashSet<training_process>();
        }
    
        public int id { get; set; }
        public string Fullname { get; set; }
        public string gender { get; set; }
        public Nullable<double> weight { get; set; }
        public string anh { get; set; }
        public Nullable<double> height { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<training_process> training_process { get; set; }
    }
}