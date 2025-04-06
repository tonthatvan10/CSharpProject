namespace CSharpProject.Models
{
    public class KhoaHoc
    {
        public int MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; } = string.Empty;
        public string GiangVien { get; set; } = string.Empty;
        public DateTime ThoiGianKhaiGiang { get; set; }
        public decimal HocPhi { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; } = string.Empty;

        public ICollection<DangKyHoc> DangKyHocs { get; set; } = new List<DangKyHoc>();

    }
}
