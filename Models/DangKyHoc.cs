namespace CSharpProject.Models
{
    public class DangKyHoc
    {
        public int MaHocVien { get; set; }
        public HocVien HocVien { get; set; } = new HocVien();
        public int HocVienId { get; set; }
        public KhoaHoc KhoaHoc { get; set; } = new KhoaHoc();
        public int KhoaHocId { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string TrangThai { get; set; } = string.Empty;
    }
}
