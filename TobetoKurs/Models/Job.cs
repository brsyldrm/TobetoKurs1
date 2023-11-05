using System.ComponentModel.DataAnnotations;

namespace TobetoKurs.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        [Display(Name = "Özet",Prompt ="job summary")]
        [Required(ErrorMessage ="Özet alanı boş geçilemez"), StringLength(160,MinimumLength =10,ErrorMessage ="Özet alanı minimum 10 ve maksimum 160 karakter olabilir.")]
        public string Summary { get; set; }
        [Display(Name = "Açıklama")]
        [MaxLength(300,ErrorMessage ="Açıklama alanı maksimum 300 karakter olabilir.")]
        public string Description { get; set; }
        [Display(Name = "Tamamlandı")]
        public bool IsCompleted { get; set; }
        [Display(Name = "Görev Sahibi")]
        [Required(ErrorMessage ="Görev sahibi boş geçilemez")]
        public string Assignee { get; set; }
    }
}
