namespace WatchShop.Areas.Administrator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Họ tên KH")]
        public string HoTenKH { get; set; }

        [Required]
        [StringLength(200)]
        public string EmailKH { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Địa chỉ")]
        public string DiaChiKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
